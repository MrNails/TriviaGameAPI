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
                    Name = Guid.NewGuid().ToString(),
                    CharacterColor = characterColor,
                    IsGameOrganizer = availableRoom == null,
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

            await _dbContext.SaveChangesAsync();

            await OpponentJoined(player.Name, characterColor, player.IsGameOrganizer);

            if (!player.IsGameOrganizer)
                await CanPlay();
        }

        public async Task Send(string jsonData)
        {
            var gameplayRoom = await GetGameplayRoom();

            if (gameplayRoom != null)
                await Clients.Clients(gameplayRoom.Players.Where(p => p.ConnectionId != Context.ConnectionId).Select(p => p.ConnectionId!).ToList())
                   .SendAsync(nameof(Send), jsonData);
        }

        public async Task Leave()
        {
            var gameplayRoom = await GetGameplayRoom();

            if (gameplayRoom == null)
                return;

            var player = gameplayRoom.Players.FirstOrDefault(p => p.ConnectionId == Context.ConnectionId);

            if (player == null)
                return;

            await OpponentLeave();
            if (player.IsGameOrganizer)
            {
                player.IsGameOrganizer = false;
                gameplayRoom.Players.Clear();
                _dbContext.GameplayRooms.Remove(gameplayRoom);
            }
            else
                gameplayRoom.Players.Remove(player);

            await _dbContext.SaveChangesAsync();
        }

        public async Task OpponentJoined(string name, string characterColor, bool isGameOrganizer)
        {
            var gameplayRoom = await GetGameplayRoom();

            if (gameplayRoom != null)
                await Clients.Clients(gameplayRoom.Players.Select(p => p.ConnectionId!).ToList())
                    .SendAsync(nameof(OpponentJoined), name, characterColor, isGameOrganizer);
        }

        public async Task CanPlay()
        {
            var gameplayRoom = await GetGameplayRoom();

            if (gameplayRoom != null)
                await Clients.Clients(gameplayRoom.Players.Select(p => p.ConnectionId!).ToList())
                    .SendAsync(nameof(CanPlay));
        }

        public async Task OpponentLeave()
        {
            var gameplayRoom = await GetGameplayRoom();

            if (gameplayRoom != null)
            {
                var clients = Clients.Clients(gameplayRoom.Players.Where(p => p.ConnectionId != Context.ConnectionId).Select(p => p.ConnectionId!).ToList());
                await clients
                    .SendAsync(nameof(OpponentLeave));
            }
        }

        public async override Task OnDisconnectedAsync(Exception? exception)
        {
            if (exception != null)
                _logger.LogError(exception, "ConnectionId {ConnectionId}", Context.ConnectionId);

            await Leave();

            await base.OnDisconnectedAsync(exception);
        }

        //Fix this!!
        //It could be moved to in-memory chahe (ASP.NET build-in in-memory chache, Redis whatever)
        private async Task<GameplayRoom?> GetGameplayRoom()
        {
            var player = await _dbContext.Players.FirstOrDefaultAsync(p => p.ConnectionId == Context.ConnectionId);
            if (player == null)
                return null;

            var gamePlayeRoom = await _dbContext.GameplayRooms.FirstOrDefaultAsync(gr => gr.Players.FirstOrDefault(p => p.Id == player.Id) != null);

            if (gamePlayeRoom != null)
                _dbContext.GameplayRooms.Entry(gamePlayeRoom)
                        .Collection(g => g.Players)
                        .Load();

            return gamePlayeRoom;
        }

        protected override void Dispose(bool disposing)
        {
            _dbContext.Dispose();

            base.Dispose(disposing);
        }
    }
}
