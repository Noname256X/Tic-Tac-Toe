using System.Windows.Forms;

namespace Client_tic_tac_toe
{
    public partial class PageRegistration : Form
    {
        public PageRegistration()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNickname.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ApiClient.ShowError("Заполните все поля!");
                return;
            }

            var nickname = txtNickname.Text.Trim();
            var success = await ApiClient.Register(nickname, txtPassword.Text);

            if (success)
            {
                Properties.Settings.Default.CurrentUser = nickname;
                Properties.Settings.Default.Save();

                ApiClient.NavigateTo(this, new PageModeSelection());
            }
            else
            {
                ApiClient.ShowError("Никнейм уже занят");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var authForm = new FirstPage();
            authForm.Show();
            this.Hide();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtNickname.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return false;
            }
            return true;
        }
    }
}
