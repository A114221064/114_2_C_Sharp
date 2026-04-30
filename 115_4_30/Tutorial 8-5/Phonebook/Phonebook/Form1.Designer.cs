    namespace Phonebook
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
        /// 設計工具所需的方法 — 請勿使用程式碼編輯器修改此方法的內容。
        /// 以下已將所有元件的 Text 屬性改為繁體中文、字型大小統一為 18，並適度調整每個元件的大小與位置。
        /// 也加入了繁體中文註解來說明每一段設定。其他程式與事件綁定均維持原樣。
        /// </summary>
        private void InitializeComponent()
        {
            this.promptLabel = new System.Windows.Forms.Label();
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.selectedPhoneDescriptionLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            // 提示用標籤：顯示選取提示文字，已翻譯為繁體中文並設定較大的字型。
            this.promptLabel.AutoSize = true;
            this.promptLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.promptLabel.Location = new System.Drawing.Point(20, 12);
            this.promptLabel.Name = "promptLabel";
            // Size 參考字型大小自動調整，仍保留 Size 屬性以符合設計器產生的格式。
            this.promptLabel.Size = new System.Drawing.Size(140, 30);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "請選擇姓名";
            // 
            // nameListBox
            // 
            // 名單清單：用來顯示姓名列表，字型調大並增寬增高以便顯示較大字體。
            this.nameListBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.ItemHeight = 30;
            this.nameListBox.Location = new System.Drawing.Point(20, 50);
            this.nameListBox.Name = "nameListBox";
            // 增加高度與寬度，讓使用者可見多筆項目並符合 18pt 字型
            this.nameListBox.Size = new System.Drawing.Size(240, 240);
            this.nameListBox.TabIndex = 1;
            this.nameListBox.SelectedIndexChanged += new System.EventHandler(this.nameListBox_SelectedIndexChanged);
            // 
            // selectedPhoneDescriptionLabel
            // 
            // 描述用標籤：顯示「電話號碼」文字，已翻譯並設定大字型，位置相對於清單右側。
            this.selectedPhoneDescriptionLabel.AutoSize = true;
            this.selectedPhoneDescriptionLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.selectedPhoneDescriptionLabel.Location = new System.Drawing.Point(280, 50);
            this.selectedPhoneDescriptionLabel.Name = "selectedPhoneDescriptionLabel";
            this.selectedPhoneDescriptionLabel.Size = new System.Drawing.Size(110, 30);
            this.selectedPhoneDescriptionLabel.TabIndex = 2;
            this.selectedPhoneDescriptionLabel.Text = "電話號碼";
            // 
            // phoneLabel
            // 
            // 顯示電話用的標籤：使用邊框顯示被選取的電話，文字預設為「尚未選擇」。
            // 也將字型、大小與對齊方式調整為較大的易讀格式。
            this.phoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.phoneLabel.Location = new System.Drawing.Point(280, 90);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(260, 60);
            this.phoneLabel.TabIndex = 3;
            this.phoneLabel.Text = "尚未選擇";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            // 離開按鈕：文字已翻譯為繁體中文，字型放大並放置在視窗右下方，尺寸增加以便觸控或點選。
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(420, 300);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 40);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            // 主視窗：調整 ClientSize 以容納放大的元件，並將標題改為繁體中文「電話簿」。
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            // 保留原先的 AutoScaleMode 設定，以維持設計器行為一致性。
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // 增大視窗大小以符合 18pt 字型與元件調整。
            this.ClientSize = new System.Drawing.Size(560, 360);
            // 將所有控制項加入表單 (順序維持原本設計)
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.selectedPhoneDescriptionLabel);
            this.Controls.Add(this.nameListBox);
            this.Controls.Add(this.promptLabel);
            this.Name = "Form1";
            this.Text = "電話簿";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.Label selectedPhoneDescriptionLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

