using Microsoft.AspNetCore.SignalR.Client;
using System.Collections.Generic;

namespace Client_tic_tac_toe
{
    public partial class PageLobby : Form
    {
        private HubConnection _hubConnection;
        private string _currentUser;

        public PageLobby()
        {
            InitializeComponent();
            _currentUser = Properties.Settings.Default.CurrentUser;
            InitializeHubConnection();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private async void InitializeHubConnection()
        {
            _hubConnection = new HubConnectionBuilder()
                .WithUrl($"{ApiClient.GetBaseUrl()}/gamehub")
                .Build();
        }

        private void UpdateLobbyList(Dictionary<string, string> lobbies)
        {
            lobbyContainer.Controls.Clear();
            foreach (var lobby in lobbies)
            {
                var btn = new Button
                {
                    Text = $"Лобби: {lobby.Value}",
                    Size = new Size(220, 40),
                    Tag = lobby.Key
                };
                btn.Click += (s, e) => JoinLobby(lobby.Key);
                lobbyContainer.Controls.Add(btn);
            }
        }

        private async void JoinLobby(string lobbyId)
        {
            await _hubConnection.SendAsync("JoinLobby", lobbyId);
            var gameForm = new PageGame();
            gameForm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var modeSelection = new PageModeSelection();
            modeSelection.Show();
            this.Hide();
        }
    }
}
