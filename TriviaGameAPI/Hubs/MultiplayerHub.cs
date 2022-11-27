using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Net.WebSockets;
using TriviaGameAPI.DAL.Models;
using TriviaGameAPI.DAL.Repositories;

namespace TriviaGameAPI.Hubs
{
    public class MultiplayerHub : Hub
    {
        private static readonly int MaxPlayersPerRoom = 2;

        private readonly ILogger<MultiplayerHub> _logger;
        private readonly TriviaGameDBContext _dbContext;

        private GameplayRoom? _gameplayRoom;

        public MultiplayerHub(ILogger<MultiplayerHub> logger, TriviaGameDBContext dBContext)
        {
            _logger = logger;
            _dbContext = dBContext;
        }

        public async Task Join(string characterColor)
        {
            var player = await _dbContext.Players.FirstOrDefaultAsync(p => p.ConnectionId == Context.ConnectionId);
            var availableRoom = await _dbContext.GameplayRooms.FirstOrDefaultAsync(gr => gr.Players.Count + 1 <= gr.MaxPlayers);

            if (player == null)
            {
                player = new Player
                {
                    ConnectionId = Context.ConnectionId,
                    CharacterColor = characterColor,
                    IsGameOrganizer = true,
                    LastGameDate = DateTime.UtcNow,
                };

                _dbContext.Players.Add(player);
            }
            else player.CharacterColor = characterColor;

            if (availableRoom == null)
            {
                player.IsGameOrganizer = true;
                availableRoom = new GameplayRoom { MaxPlayers = MaxPlayersPerRoom };

                _dbContext.GameplayRooms.Add(availableRoom);
            }

            availableRoom.Players.Add(player);

            _gameplayRoom = availableRoom;

            await _dbContext.SaveChangesAsync();

            await OpponentJoined(player.Name, characterColor, player.IsGameOrganizer);

            if (!player.IsGameOrganizer)
                await CanPlay();
        }

        public Task Send(string jsonData)
        {
            if (_gameplayRoom != null)
                return Clients.Clients(_gameplayRoom.Players.Where(p => p.ConnectionId != Context.ConnectionId).Select(p => p.ConnectionId!).ToList())
                    .SendAsync(nameof(Send), jsonData);
            else
                return Task.CompletedTask;
        }

        public async Task Leave()
        {
            if (_gameplayRoom == null)
                return;

            var player = _dbContext.Players.First(p => p.ConnectionId == Context.ConnectionId);

            if (player.IsGameOrganizer)
            {
                _gameplayRoom.Players.Clear();
                _dbContext.GameplayRooms.Remove(_gameplayRoom);
            }
            else
                _gameplayRoom.Players.Remove(player);

            await _dbContext.SaveChangesAsync();
            await OpponentLeave();
        }

        public Task OpponentJoined(string name, string characterColor, bool isGameOrganizer)
        {
            if (_gameplayRoom != null)
                return Clients.Clients(_gameplayRoom.Players.Select(p => p.ConnectionId!).ToList())
                    .SendAsync(nameof(OpponentJoined), name, characterColor, isGameOrganizer);
            else
                return Task.CompletedTask;
        }

        public Task CanPlay()
        {
            if (_gameplayRoom != null)
                return Clients.Clients(_gameplayRoom.Players.Select(p => p.ConnectionId!).ToList())
                    .SendAsync(nameof(CanPlay));
            else
                return Task.CompletedTask;
        }

        public Task OpponentLeave()
        {
            if (_gameplayRoom != null)
                return Clients.Clients(_gameplayRoom.Players.Where(p => p.ConnectionId != Context.ConnectionId).Select(p => p.ConnectionId!).ToList())
                    .SendAsync(nameof(OpponentLeave));
            else
                return Task.CompletedTask;
        }

        public async override Task OnDisconnectedAsync(Exception? exception)
        {
            if (exception != null)
                _logger.LogError(exception, "ConnectionId {ConnectionId}", Context.ConnectionId);

            await Leave();

            await base.OnDisconnectedAsync(exception);
        }

        protected override void Dispose(bool disposing)
        {
            _dbContext.Dispose();

            base.Dispose(disposing);
        }
    }
}
