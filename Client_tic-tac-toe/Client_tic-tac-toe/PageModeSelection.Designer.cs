namespace Client_tic_tac_toe
{
    partial class PageModeSelection
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCreateGame;
        private System.Windows.Forms.Button btnJoinGame;
        private System.Windows.Forms.Button btnAccount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.btnJoinGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccount
            // 
            this.btnAccount.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnAccount.Location = new System.Drawing.Point(164, 10);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(126, 38);
            this.btnAccount.TabIndex = 0;
            this.btnAccount.Text = "Аккаунт";
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.Location = new System.Drawing.Point(87, 90);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(126, 38);
            this.btnCreateGame.TabIndex = 1;
            this.btnCreateGame.Text = "Создать игру";
            this.btnCreateGame.Click += new System.EventHandler(this.btnCreateGame_Click);
            // 
            // btnJoinGame
            // 
            this.btnJoinGame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnJoinGame.Location = new System.Drawing.Point(87, 172);
            this.btnJoinGame.Name = "btnJoinGame";
            this.btnJoinGame.Size = new System.Drawing.Size(126, 38);
            this.btnJoinGame.TabIndex = 2;
            this.btnJoinGame.Text = "Присоединиться";
            this.btnJoinGame.Click += new System.EventHandler(this.btnJoinGame_Click);
            // 
            // PageModeSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.btnJoinGame);
            this.Controls.Add(this.btnCreateGame);
            this.Controls.Add(this.btnAccount);
            this.Name = "PageModeSelection";
            this.Text = "Выбор режима";
            this.ResumeLayout(false);
        }

        #endregion
    }
}
