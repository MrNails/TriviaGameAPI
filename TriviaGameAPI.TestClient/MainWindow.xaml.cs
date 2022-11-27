using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TriviaGameAPI.TestClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly HubConnection _hubConnection;
        private bool _isGameOrginizer = false;

        public MainWindow()
        {
            InitializeComponent();

            PlayersDataDockPanel.Visibility = Visibility.Hidden;
            GameGrid.Visibility = Visibility.Hidden;

            _hubConnection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7180/trivia")
                .WithAutomaticReconnect()
                .Build();

            _hubConnection.On<string>("Send", str =>
            {
                Debug.WriteLine($"\n{str}\n");
            });

            _hubConnection.On<string, string, bool>("OpponentJoined", (name, opponentColor, isGameOrginizer) =>
            {
                _isGameOrginizer = isGameOrginizer;
                Debug.WriteLine($"\nOpponent joined: {name} {opponentColor} {isGameOrginizer}\n");

                Dispatcher.InvokeAsync(() =>
                {
                    MainGameButton.Tag = "2";
                    MainGameButton.Content = "Leave";
                    ShowLeaderBoardButton.Visibility = Visibility.Collapsed;

                    PlayersDataDockPanel.Visibility = Visibility.Visible;
                    GameGrid.Visibility = Visibility.Visible;
                });
            });

            _hubConnection.On("CanPlay", () => 
            {
                Debug.WriteLine("\nCan play\n");
            });

            _hubConnection.On("OpponentLeave", () =>
            {
                if (!_isGameOrginizer)
                {
                    Dispatcher.InvokeAsync(() =>
                    {
                        MainGameButton.Tag = "1";
                        MainGameButton.Content = "Find game";
                        ShowLeaderBoardButton.Visibility = Visibility.Visible;

                        PlayersDataDockPanel.Visibility = Visibility.Hidden;
                        GameGrid.Visibility = Visibility.Hidden;
                    });
                }

                Debug.WriteLine("\nOpponent leave\n");
            });

            _hubConnection.Closed += ex =>
            {
                Debug.WriteLine($"Disconected from server. {ex?.Message}");
                return Task.CompletedTask;
            };
        }

        private async void ConnectButton_Click(object sender, RoutedEventArgs e)
        {
            if (_hubConnection.State != HubConnectionState.Connected)
            {
                try
                {
                    await _hubConnection.StartAsync();

                    ShowLeaderBoardButton.IsEnabled = true;
                    MainGameButton.IsEnabled = true;
                    ConnectButton.IsEnabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unable connect to server. {ex.Message}", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private async void MainGameButton_Click(object sender, RoutedEventArgs e)
        {
            if (_hubConnection.State != HubConnectionState.Connected)
            {
                MessageBox.Show("You are not connected to server.", "Error", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var btn = sender as Button;

            if (btn == null)
                return;

            switch (btn.Tag?.ToString())
            {
                case "1":
                    await _hubConnection.InvokeAsync("Join", "#FFFFFF");
                    break;
                case "2":
                    await _hubConnection.InvokeAsync("Leave");
                    MainGameButton.Tag = "1";
                    MainGameButton.Content = "Find game";
                    ShowLeaderBoardButton.Visibility = Visibility.Visible;

                    PlayersDataDockPanel.Visibility = Visibility.Hidden;
                    GameGrid.Visibility = Visibility.Hidden;
                    break;
                default:
                    break;
            }
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_hubConnection.State != HubConnectionState.Connected)
            {
                MessageBox.Show("You are not connected to server.", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (MainGameButton.Tag?.ToString() == "1")
            {
                MessageBox.Show("You are not in game.", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            await _hubConnection.SendAsync("Send", $"Message from {_hubConnection.ConnectionId} [{DateTime.UtcNow}]");
        }

        private async void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_hubConnection.State == HubConnectionState.Connected)
            {
                await _hubConnection.SendAsync("Leave");
            }

            await _hubConnection.DisposeAsync();
        }
    }
}
