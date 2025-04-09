namespace Client_tic_tac_toe
{
    partial class PageLobby
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnBack;
        private FlowLayoutPanel lobbyContainer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.lobbyContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial", 10F);
            this.btnBack.Location = new System.Drawing.Point(87, 394);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 38);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Назад";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lobbyContainer
            // 
            this.lobbyContainer.AutoScroll = true;
            this.lobbyContainer.Location = new System.Drawing.Point(30, 30);
            this.lobbyContainer.Size = new System.Drawing.Size(240, 340);
            // 
            // PageLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(lobbyContainer);
            this.Controls.Add(btnBack);
            this.Name = "PageLobby";
            this.Text = "Лобби";
            this.ResumeLayout(false);
        }

        #endregion
    }
}
