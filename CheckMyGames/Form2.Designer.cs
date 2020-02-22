namespace CheckMyGames
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addGame = new System.Windows.Forms.Button();
            this.cancelWindow = new System.Windows.Forms.Button();
            this.gameTitle = new System.Windows.Forms.TextBox();
            this.platform = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addGame
            // 
            this.addGame.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addGame.BackColor = System.Drawing.Color.White;
            this.addGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGame.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGame.Location = new System.Drawing.Point(442, 361);
            this.addGame.Name = "addGame";
            this.addGame.Size = new System.Drawing.Size(189, 39);
            this.addGame.TabIndex = 6;
            this.addGame.Text = "ADD";
            this.addGame.UseVisualStyleBackColor = false;
            this.addGame.Click += new System.EventHandler(this.addGame_Click);
            // 
            // cancelWindow
            // 
            this.cancelWindow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancelWindow.BackColor = System.Drawing.Color.White;
            this.cancelWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelWindow.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelWindow.Location = new System.Drawing.Point(163, 361);
            this.cancelWindow.Name = "cancelWindow";
            this.cancelWindow.Size = new System.Drawing.Size(189, 39);
            this.cancelWindow.TabIndex = 7;
            this.cancelWindow.Text = "CANCEL";
            this.cancelWindow.UseVisualStyleBackColor = false;
            this.cancelWindow.Click += new System.EventHandler(this.cancelWindow_Click);
            // 
            // gameTitle
            // 
            this.gameTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gameTitle.Font = new System.Drawing.Font("Yu Gothic", 15.75F);
            this.gameTitle.Location = new System.Drawing.Point(163, 208);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(468, 41);
            this.gameTitle.TabIndex = 8;
            // 
            // platform
            // 
            this.platform.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.platform.Enabled = false;
            this.platform.Font = new System.Drawing.Font("Yu Gothic", 15.75F);
            this.platform.Location = new System.Drawing.Point(163, 98);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(468, 41);
            this.platform.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 15.75F);
            this.label1.Location = new System.Drawing.Point(158, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "PLATFORM";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 15.75F);
            this.label2.Location = new System.Drawing.Point(158, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "GAME TITLE";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.platform);
            this.Controls.Add(this.gameTitle);
            this.Controls.Add(this.cancelWindow);
            this.Controls.Add(this.addGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addGame;
        private System.Windows.Forms.Button cancelWindow;
        private System.Windows.Forms.TextBox gameTitle;
        private System.Windows.Forms.TextBox platform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}