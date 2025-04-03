using System.Windows.Forms;
using System;

namespace Client_tic_tac_toe
{
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            ApiClient.NavigateTo(this, new PageAutorization());
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            ApiClient.NavigateTo(this, new PageRegistration());
        }

        private void FirstPage_Load(object sender, EventArgs e)
        {

        }
    }
}
