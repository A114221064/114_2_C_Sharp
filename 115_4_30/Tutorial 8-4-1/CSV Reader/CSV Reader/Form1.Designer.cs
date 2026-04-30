namespace CSV_Reader
{
    partial class Form1
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
        /// 初始化表單元件
        /// 注意：本區塊為自動產生之 Designer 程式碼，已依使用者要求將所有元件的 Text 屬性改為繁體中文，
        /// 並將字型大小統一設定為 18，並適度調整每個元件大小與位置以配合較大的字型。
        /// 如需進一步調整請在設計工具內微調位置/大小。
        /// </summary>
        private void InitializeComponent()
        {
            this.averagesListBox = new System.Windows.Forms.ListBox();
            this.getScoresButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // averagesListBox
            // 
            // 說明：此 ListBox 用來顯示分數或平均值清單。
            // 字型已改為 18，並放大元件尺寸以容納較大的文字與項目。
            this.averagesListBox.FormattingEnabled = true;
            this.averagesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averagesListBox.ItemHeight = 29;
            this.averagesListBox.Location = new System.Drawing.Point(12, 12);
            this.averagesListBox.Name = "averagesListBox";
            this.averagesListBox.Size = new System.Drawing.Size(560, 242);
            this.averagesListBox.TabIndex = 0;
            // 
            // getScoresButton
            // 
            // 說明：按下後讀取 CSV 並顯示成績（按鈕文字已改為繁體中文）。
            this.getScoresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getScoresButton.Location = new System.Drawing.Point(120, 270);
            this.getScoresButton.Name = "getScoresButton";
            this.getScoresButton.Size = new System.Drawing.Size(160, 56);
            this.getScoresButton.TabIndex = 1;
            this.getScoresButton.Text = "取得成績";
            this.getScoresButton.UseVisualStyleBackColor = true;
            this.getScoresButton.Click += new System.EventHandler(this.getScoresButton_Click);
            // 
            // exitButton
            // 
            // 說明：關閉表單（按鈕文字已改為繁體中文）。
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(320, 270);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(160, 56);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            // 說明：整體表單標題已改為繁體中文，並將整個表單的字型設定為 18 以確保一致性與可讀性。
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getScoresButton);
            this.Controls.Add(this.averagesListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "CSV 讀取器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox averagesListBox;
        private System.Windows.Forms.Button getScoresButton;
        private System.Windows.Forms.Button exitButton;
    }
}

