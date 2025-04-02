namespace Client_tic_tac_toe
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм

        private void InitializeComponent()
        {
            this.btnJoinGame = new System.Windows.Forms.Button();
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJoinGame
            // 
            this.btnJoinGame.Location = new System.Drawing.Point(75, 392);
            this.btnJoinGame.Name = "btnJoinGame";
            this.btnJoinGame.Size = new System.Drawing.Size(126, 35);
            this.btnJoinGame.TabIndex = 1;
            this.btnJoinGame.Text = "Присоединиться";
            this.btnJoinGame.UseVisualStyleBackColor = true;
            this.btnJoinGame.Click += new System.EventHandler(this.btnJoinGame_Click);
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.Location = new System.Drawing.Point(75, 333);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(126, 35);
            this.btnCreateGame.TabIndex = 2;
            this.btnCreateGame.Text = "Создать игру";
            this.btnCreateGame.UseVisualStyleBackColor = true;
            this.btnCreateGame.Click += new System.EventHandler(this.btnCreateGame_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 439);
            this.Controls.Add(this.btnCreateGame);
            this.Controls.Add(this.btnJoinGame);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJoinGame;
        private System.Windows.Forms.Button btnCreateGame;
    }
}
