using System.Windows.Forms;
using System;

namespace Client_tic_tac_toe
{
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            var authForm = new PageAutorization();
            authForm.Show();
            this.Hide();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            var regForm = new PageRegistration();
            regForm.Show();
            this.Hide();
        }

        private void FirstPage_Load(object sender, EventArgs e)
        {

        }
    }
}
