using Microsoft.AspNetCore.SignalR.Client;
using System.Drawing;
using System;
using System.Windows.Forms;

namespace Client_tic_tac_toe
{
    public partial class Form1 : Form
    {
        private HubConnection _connection;
        private string _currentSessionId;
        private bool _isMyTurn;

        public Form1()
        {
            InitializeComponent();
            InitializeGameBoard();
            ConnectToServer();
        }

        private async void ConnectToServer()
        {
            _connection = new HubConnectionBuilder()
                //.WithUrl("http://localhost:5000/gamehub")
                .WithUrl("https://localhost:5001/gamehub")
                .Build();

            _connection.On<string>("GameCreated", sessionId =>
            {
                _currentSessionId = sessionId;
                MessageBox.Show($"Создана игра! ID: {sessionId}");
            });

            _connection.On("GameStarted", () =>
            {
                _isMyTurn = true;
                MessageBox.Show("Игра началась! Ваш ход - X");
            });

            _connection.On<int, string>("MoveMade", (cellIndex, sign) =>
            {
                Invoke((MethodInvoker)delegate
                {
                    var button = (Button)Controls.Find($"button{cellIndex}", true)[0];
                    button.Text = sign;
                    button.Enabled = false;
                    _isMyTurn = !_isMyTurn;
                });
            });

            try
            {
                await _connection.StartAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения: {ex.Message}");
            }
        }

        private void InitializeGameBoard()
        {
            for (var i = 0; i < 9; i++)
            {
                var button = new Button
                {
                    Name = $"button{i}",
                    Size = new Size(60, 60),
                    Location = new Point((i % 3) * 65, (i / 3) * 65),
                    Tag = i
                };
                button.Click += Button_Click;
                Controls.Add(button);
            }
        }

        private async void Button_Click(object sender, EventArgs e)
        {
            if (!_isMyTurn) return;

            var button = (Button)sender;
            var cellIndex = (int)button.Tag;

            try
            {
                await _connection.InvokeAsync("MakeMove", _currentSessionId, cellIndex);
                button.Text = _isMyTurn ? "X" : "O";
                button.Enabled = false;
                _isMyTurn = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private async void btnCreateGame_Click(object sender, EventArgs e)
        {
            await _connection.InvokeAsync("CreateGame");
        }

        private async void btnJoinGame_Click(object sender, EventArgs e)
        {
            var sessionId = Microsoft.VisualBasic.Interaction.InputBox("Введите ID игры:", "Присоединиться");
            if (!string.IsNullOrEmpty(sessionId))
                await _connection.InvokeAsync("JoinGame", sessionId);
        }
    }
}

