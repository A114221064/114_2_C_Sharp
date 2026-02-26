namespace Review_Q1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.PictureBox computerPictureBox;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.Label computerLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button stoneButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorButton;
        private System.Windows.Forms.Button exitButton;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            computerPictureBox = new PictureBox();
            playerPictureBox = new PictureBox();
            computerLabel = new Label();
            playerLabel = new Label();
            resultLabel = new Label();
            stoneButton = new Button();
            paperButton = new Button();
            scissorButton = new Button();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)computerPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).BeginInit();
            SuspendLayout();
            // 
            // computerPictureBox
            // 
            computerPictureBox.BorderStyle = BorderStyle.FixedSingle;
            computerPictureBox.Image = Properties.Resources.paper_computer;
            computerPictureBox.Location = new Point(63, 82);
            computerPictureBox.Name = "computerPictureBox";
            computerPictureBox.Size = new Size(240, 120);
            computerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            computerPictureBox.TabIndex = 2;
            computerPictureBox.TabStop = false;
            // 
            // playerPictureBox
            // 
            playerPictureBox.BorderStyle = BorderStyle.FixedSingle;
            playerPictureBox.Image = Properties.Resources.stone_player;
            playerPictureBox.Location = new Point(403, 82);
            playerPictureBox.Name = "playerPictureBox";
            playerPictureBox.Size = new Size(240, 120);
            playerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            playerPictureBox.TabIndex = 3;
            playerPictureBox.TabStop = false;
            // 
            // computerLabel
            // 
            computerLabel.AutoSize = true;
            computerLabel.Font = new Font("Segoe UI", 14F);
            computerLabel.Location = new Point(139, 25);
            computerLabel.Name = "computerLabel";
            computerLabel.Size = new Size(104, 38);
            computerLabel.TabIndex = 0;
            computerLabel.Text = "電腦出";
            // 
            // playerLabel
            // 
            playerLabel.AutoSize = true;
            playerLabel.Font = new Font("Segoe UI", 14F);
            playerLabel.Location = new Point(459, 25);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(104, 38);
            playerLabel.TabIndex = 1;
            playerLabel.Text = "玩家出";
            // 
            // resultLabel
            // 
            resultLabel.BorderStyle = BorderStyle.FixedSingle;
            resultLabel.Font = new Font("Segoe UI", 20F);
            resultLabel.Location = new Point(100, 254);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(520, 50);
            resultLabel.TabIndex = 4;
            resultLabel.Text = "玩家贏";
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // stoneButton
            // 
            stoneButton.Font = new Font("Microsoft JhengHei UI", 16F);
            stoneButton.Location = new Point(80, 324);
            stoneButton.Name = "stoneButton";
            stoneButton.Size = new Size(160, 60);
            stoneButton.TabIndex = 5;
            stoneButton.Text = "石頭";
            stoneButton.UseVisualStyleBackColor = true;
            stoneButton.Click += stoneButton_Click;
            // 
            // paperButton
            // 
            paperButton.Font = new Font("Microsoft JhengHei UI", 16F);
            paperButton.Location = new Point(290, 324);
            paperButton.Name = "paperButton";
            paperButton.Size = new Size(160, 60);
            paperButton.TabIndex = 6;
            paperButton.Text = "布";
            paperButton.UseVisualStyleBackColor = true;
            paperButton.Click += paperButton_Click;
            // 
            // scissorButton
            // 
            scissorButton.Font = new Font("Microsoft JhengHei UI", 16F);
            scissorButton.Location = new Point(500, 324);
            scissorButton.Name = "scissorButton";
            scissorButton.Size = new Size(160, 60);
            scissorButton.TabIndex = 7;
            scissorButton.Text = "剪刀";
            scissorButton.UseVisualStyleBackColor = true;
            scissorButton.Click += scissorButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Microsoft JhengHei UI", 14F);
            exitButton.Location = new Point(310, 404);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(140, 50);
            exitButton.TabIndex = 8;
            exitButton.Text = "結束遊戲";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 493);
            Controls.Add(exitButton);
            Controls.Add(scissorButton);
            Controls.Add(paperButton);
            Controls.Add(stoneButton);
            Controls.Add(resultLabel);
            Controls.Add(playerPictureBox);
            Controls.Add(computerPictureBox);
            Controls.Add(playerLabel);
            Controls.Add(computerLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "猜拳遊戲";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)computerPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
