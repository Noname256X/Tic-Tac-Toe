using System.Windows.Forms;

namespace Client_tic_tac_toe
{
    public partial class PageModeSelection : Form
    {
        public PageModeSelection()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            var accountForm = new PageAccount();
            accountForm.Show();
            this.Hide();
        }

        private void btnCreateGame_Click(object sender, EventArgs e)
        {
            var gameForm = new PageGame(true);
            gameForm.Show();
            this.Hide();
        }

        private void btnJoinGame_Click(object sender, EventArgs e)
        {
            var lobbyForm = new PageLobby();
            lobbyForm.Show();
            this.Hide();
        }

    }
}
