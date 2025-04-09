using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;

namespace Client_tic_tac_toe
{
    public partial class PageGame : Form
    {

        private HubConnection? _hubConnection;
        private string? _currentUser;
        private string? _gameSessionId;
        private bool _isHost;
        private string? _opponent;

        public PageGame(bool isHost = false)
        {
            InitializeComponent();
            _isHost = isHost;

            _currentUser = Properties.Settings.Default.CurrentUser;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeCellStyles();
            SetupEventHandlers();
            InitializeGame();


        }

        //private void InitializeCustomComponents()
        //{
        //    InitializeCellStyles();
        //    SetupEventHandlers();
        //    _currentUser = Properties.Settings.Default.CurrentUser;
        //    InitializeGame();
        //}

        private void InitializeCellStyles()
        {
            ApplyCellStyle(button1, 0);
            ApplyCellStyle(button2, 1);
            ApplyCellStyle(button3, 2);
            ApplyCellStyle(button4, 3);
            ApplyCellStyle(button5, 4);
            ApplyCellStyle(button6, 5);
            ApplyCellStyle(button7, 6);
            ApplyCellStyle(button8, 7);
            ApplyCellStyle(button9, 8);
        }

        private void SetupEventHandlers()
        {
            button1.Click += Cell_Click!;
            button2.Click += Cell_Click!;
            button3.Click += Cell_Click!;
            button4.Click += Cell_Click!;
            button5.Click += Cell_Click!;
            button6.Click += Cell_Click!;
            button7.Click += Cell_Click!;
            button8.Click += Cell_Click!;
            button9.Click += Cell_Click!;

            btnLeave.Click += BtnLeave_Click!;
        }

        private void ApplyCellStyle(Button btn, int index)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Arial", 24);
            btn.BackColor = Color.White;

            const int radius = 15;
            var path = new GraphicsPath();

            if (index == 0) path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            if (index == 2) path.AddArc(btn.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            if (index == 8) path.AddArc(btn.Width - radius * 2, btn.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            if (index == 6) path.AddArc(0, btn.Height - radius * 2, radius * 2, radius * 2, 90, 90);

            btn.Region = new Region(path);
        }

        private async Task JoinExistingGame()
        {
            try
            {
                var lobbies = await _hubConnection.InvokeAsync<Dictionary<string, string>>("GetActiveLobbies");
                if (lobbies?.Any() != true)
                {
                    MessageBox.Show("Нет доступных игр");
                    Close();
                    return;
                }

                var firstLobby = lobbies.First();
                _gameSessionId = firstLobby.Key;
                await _hubConnection.SendAsync("JoinLobby", _gameSessionId, _currentUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                Close();
            }
        }

        private async void InitializeGame()
        {
            _hubConnection = new HubConnectionBuilder()
                .WithUrl($"{ApiClient.GetBaseUrl()}/gamehub")
                .Build();

            SetupHubListeners();

            try
            {
                await _hubConnection.StartAsync();
                if (_isHost)
                    await _hubConnection.SendAsync("CreateGame", _currentUser);
                else
                    await JoinExistingGame();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения: {ex.Message}");
                Close();
            }
        }

        private void SetupHubListeners()
        {
            _hubConnection.On<string>("GameCreated", sessionId =>
            {
                _gameSessionId = sessionId;
                BeginInvoke((Action)(() => Text += " (Ожидание игрока...)"));
            });

            _hubConnection.On<string, string>("GameJoined", (player1, player2) =>
            {
                bool isPlayer1 = _currentUser == player1;
                _opponent = isPlayer1 ? player2 : player1;

                BeginInvoke((Action)(() =>
                {
                    lblPlayer1.Text = _currentUser;
                    lblPlayer2.Text = _opponent;

                    Text = "Игра";
                    EnableBoard(true);
                }));
            });

            _hubConnection.On<int, string>("MoveMade", (cellIndex, sign) =>
            {
                BeginInvoke((Action)(() => UpdateCell(cellIndex, sign)));
            });

            _hubConnection.On<string>("GameOver", (result) =>
            {
                BeginInvoke((Action)(() =>
                {
                    if (result == "draw")
                        MessageBox.Show("Ничья!");
                    else
                        MessageBox.Show(result == _currentUser ? "Вы победили!" : "Вы проиграли!");

                    ResetGame();
                }));
            });
        }

        private void UpdateCell(int index, string sign)
        {
            var button = GetButtonByIndex(index);
            if (button != null)
            {
                button.Text = sign;
                button.Enabled = false;
            }
        }

        private Button GetButtonByIndex(int index)
        {
            return index switch
            {
                0 => button1,
                1 => button2,
                2 => button3,
                3 => button4,
                4 => button5,
                5 => button6,
                6 => button7,
                7 => button8,
                8 => button9,
                _ => null
            };
        }

        private void EnableBoard(bool enable)
        {
            foreach (Control control in gameBoard.Controls)
            {
                if (control is Button btn)
                    btn.Enabled = enable && string.IsNullOrEmpty(btn.Text);
            }
        }

        private void ResetGame()
        {
            foreach (Control control in gameBoard.Controls)
            {
                if (control is Button btn)
                {
                    btn.Text = string.Empty;
                    btn.Enabled = false;
                }
            }
        }

        private async void Cell_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var cellIndex = (int)button.Tag;

            await _hubConnection.SendAsync("MakeMove", _gameSessionId, cellIndex);
        }

        private async void BtnLeave_Click(object sender, EventArgs e)
        {
            await _hubConnection.SendAsync("LeaveGame", _gameSessionId, _currentUser);
            ApiClient.NavigateTo(this, new PageModeSelection());
        }

        private void UpdatePlayersLabels(string player1, string player2)
        {
            lblPlayer1.Text = player1;
            lblPlayer2.Text = player2;
        }
    }
}