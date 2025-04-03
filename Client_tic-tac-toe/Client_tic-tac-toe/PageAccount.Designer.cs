namespace Client_tic_tac_toe
{
    partial class PageAccount
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.Label lblGamesPlayed;
        private System.Windows.Forms.Label lblWinRate;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblNickname = new System.Windows.Forms.Label();
            this.lblGamesPlayed = new System.Windows.Forms.Label();
            this.lblWinRate = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNickname
            // 
            this.lblNickname.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblNickname.AutoSize = true;
            this.lblNickname.Font = new System.Drawing.Font("Arial", 12F);
            this.lblNickname.Location = new System.Drawing.Point(164, 18); 
            this.lblNickname.Margin = new System.Windows.Forms.Padding(10);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(118, 18);
            this.lblNickname.TabIndex = 0;
            this.lblNickname.Text = "Никнейм: User";
            // 
            // lblGamesPlayed
            // 
            this.lblGamesPlayed.AutoSize = true;
            this.lblGamesPlayed.Font = new System.Drawing.Font("Arial", 12F);
            this.lblGamesPlayed.Location = new System.Drawing.Point(87, 80);
            this.lblGamesPlayed.Name = "lblGamesPlayed";
            this.lblGamesPlayed.Size = new System.Drawing.Size(119, 18);
            this.lblGamesPlayed.TabIndex = 1;
            this.lblGamesPlayed.Text = "Всего игр: 0";
            // 
            // lblWinRate 
            // 
            this.lblWinRate.AutoSize = true;
            this.lblWinRate.Font = new System.Drawing.Font("Arial", 12F);
            this.lblWinRate.Location = new System.Drawing.Point(87, 108);
            this.lblWinRate.Name = "lblWinRate";
            this.lblWinRate.Size = new System.Drawing.Size(157, 18);
            this.lblWinRate.TabIndex = 2;
            this.lblWinRate.Text = "Процент побед: 0%";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Arial", 10F);
            this.btnLogout.Location = new System.Drawing.Point(87, 184);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(126, 38);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Выйти из аккаунта";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial", 10F);
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack.Location = new System.Drawing.Point(87, 242);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 38);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Назад";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // PageAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblWinRate);
            this.Controls.Add(this.lblGamesPlayed);
            this.Controls.Add(this.lblNickname);
            this.Name = "PageAccount";
            this.Text = "Аккаунт";
            this.Load += new System.EventHandler(this.PageAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
