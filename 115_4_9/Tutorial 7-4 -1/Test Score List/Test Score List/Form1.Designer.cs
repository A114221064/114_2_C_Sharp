namespace Test_Score_List
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // ==============================
            // 初始化與共用設定（繁體中文註解）
            // 新增「搜尋成績」介面控制項（不包含任何搜尋邏輯），
            // 包含：說明標籤（搜尋分數：）、輸入框（TextBox）、搜尋按鈕（Button）、
            // 以及搜尋結果顯示欄（Label）。所有控制項字型皆為 18pt，
            // 並依字型大小調整控制項尺寸與版面，避免覆蓋既有控制項。
            // ==============================

            this.testScoresListBox = new System.Windows.Forms.ListBox();
            this.avgScoreDescriptionLabel = new System.Windows.Forms.Label();
            this.aboveAvgDescriptionLabel = new System.Windows.Forms.Label();
            this.belowAvgDescriptionLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.aboveAverageLabel = new System.Windows.Forms.Label();
            this.belowAverageLabel = new System.Windows.Forms.Label();
            this.getScoresButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();

            // 新增：搜尋介面控制項宣告
            this.searchPromptLabel = new System.Windows.Forms.Label();   // 「搜尋分數：」說明
            this.searchTextBox = new System.Windows.Forms.TextBox();    // 使用者輸入要搜尋的分數
            this.searchButton = new System.Windows.Forms.Button();      // 點擊搜尋（不實作功能）
            this.searchResultLabel = new System.Windows.Forms.Label();  // 顯示搜尋結果或「分數不存在」

            this.SuspendLayout();

            // --------------------------------------------------
            // testScoresListBox
            // --------------------------------------------------
            this.testScoresListBox.FormattingEnabled = true;
            this.testScoresListBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.testScoresListBox.ItemHeight = 30;
            this.testScoresListBox.Location = new System.Drawing.Point(12, 12);
            this.testScoresListBox.Name = "testScoresListBox";
            this.testScoresListBox.Size = new System.Drawing.Size(220, 244);
            this.testScoresListBox.TabIndex = 0;

            // --------------------------------------------------
            // avgScoreDescriptionLabel
            // --------------------------------------------------
            this.avgScoreDescriptionLabel.AutoSize = true;
            this.avgScoreDescriptionLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.avgScoreDescriptionLabel.Location = new System.Drawing.Point(250, 18);
            this.avgScoreDescriptionLabel.Name = "avgScoreDescriptionLabel";
            this.avgScoreDescriptionLabel.Size = new System.Drawing.Size(120, 30);
            this.avgScoreDescriptionLabel.TabIndex = 1;
            this.avgScoreDescriptionLabel.Text = "平均分數：";

            // --------------------------------------------------
            // aboveAvgDescriptionLabel
            // --------------------------------------------------
            this.aboveAvgDescriptionLabel.AutoSize = true;
            this.aboveAvgDescriptionLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aboveAvgDescriptionLabel.Location = new System.Drawing.Point(250, 78);
            this.aboveAvgDescriptionLabel.Name = "aboveAvgDescriptionLabel";
            this.aboveAvgDescriptionLabel.Size = new System.Drawing.Size(220, 30);
            this.aboveAvgDescriptionLabel.TabIndex = 2;
            this.aboveAvgDescriptionLabel.Text = "高於平均分數的人數：";

            // --------------------------------------------------
            // belowAvgDescriptionLabel
            // --------------------------------------------------
            this.belowAvgDescriptionLabel.AutoSize = true;
            this.belowAvgDescriptionLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.belowAvgDescriptionLabel.Location = new System.Drawing.Point(250, 138);
            this.belowAvgDescriptionLabel.Name = "belowAvgDescriptionLabel";
            this.belowAvgDescriptionLabel.Size = new System.Drawing.Size(220, 30);
            this.belowAvgDescriptionLabel.TabIndex = 3;
            this.belowAvgDescriptionLabel.Text = "低於平均分數的人數：";

            // --------------------------------------------------
            // averageLabel
            // --------------------------------------------------
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.averageLabel.Location = new System.Drawing.Point(480, 14);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(140, 36);
            this.averageLabel.TabIndex = 4;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // --------------------------------------------------
            // aboveAverageLabel
            // --------------------------------------------------
            this.aboveAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aboveAverageLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aboveAverageLabel.Location = new System.Drawing.Point(480, 76);
            this.aboveAverageLabel.Name = "aboveAverageLabel";
            this.aboveAverageLabel.Size = new System.Drawing.Size(140, 36);
            this.aboveAverageLabel.TabIndex = 5;
            this.aboveAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // --------------------------------------------------
            // belowAverageLabel
            // --------------------------------------------------
            this.belowAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.belowAverageLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.belowAverageLabel.Location = new System.Drawing.Point(480, 136);
            this.belowAverageLabel.Name = "belowAverageLabel";
            this.belowAverageLabel.Size = new System.Drawing.Size(140, 36);
            this.belowAverageLabel.TabIndex = 6;
            this.belowAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // --------------------------------------------------
            // getScoresButton
            // --------------------------------------------------
            this.getScoresButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getScoresButton.Location = new System.Drawing.Point(254, 210);
            this.getScoresButton.Name = "getScoresButton";
            this.getScoresButton.Size = new System.Drawing.Size(200, 48);
            this.getScoresButton.TabIndex = 7;
            this.getScoresButton.Text = "讀取分數";
            this.getScoresButton.UseVisualStyleBackColor = true;
            this.getScoresButton.Click += new System.EventHandler(this.getScoresButton_Click);

            // --------------------------------------------------
            // exitButton
            // --------------------------------------------------
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(480, 210);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 48);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);

            // --------------------------------------------------
            // 新增：searchPromptLabel (說明文字)
            // --------------------------------------------------
            // 用途：提示使用者在旁邊的輸入框輸入要搜尋的分數。
            this.searchPromptLabel.AutoSize = true;
            this.searchPromptLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchPromptLabel.Location = new System.Drawing.Point(12, 270);
            this.searchPromptLabel.Name = "searchPromptLabel";
            this.searchPromptLabel.Size = new System.Drawing.Size(140, 30);
            this.searchPromptLabel.TabIndex = 9;
            this.searchPromptLabel.Text = "搜尋分數：";

            // --------------------------------------------------
            // 新增：searchTextBox (輸入框)
            // --------------------------------------------------
            // 用途：讓使用者輸入欲搜尋的分數（僅介面，無驗證與邏輯）。
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTextBox.Location = new System.Drawing.Point(160, 267);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(200, 39);
            this.searchTextBox.TabIndex = 10;
            // 注意：此處未掛接 Click/Key 事件，僅提供 UI 元件。

            // --------------------------------------------------
            // 新增：searchButton (搜尋按鈕)
            // --------------------------------------------------
            // 用途：啟動搜尋（此檔案僅建立按鈕介面，未新增搜尋功能實作）。
            this.searchButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchButton.Location = new System.Drawing.Point(380, 263);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(120, 48);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "搜尋";
            this.searchButton.UseVisualStyleBackColor = true;
            // 故意不掛接事件處理器 — 使用者要求「不要生成程式功能」

            // --------------------------------------------------
            // 新增：searchResultLabel (結果顯示)
            // --------------------------------------------------
            // 用途：顯示搜尋結果，成功顯示所在位置或失敗顯示「分數不存在」。
            // 初始為空白，使用固定邊框並置中顯示。
            this.searchResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchResultLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchResultLabel.Location = new System.Drawing.Point(12, 320);
            this.searchResultLabel.Name = "searchResultLabel";
            this.searchResultLabel.Size = new System.Drawing.Size(608, 40);
            this.searchResultLabel.TabIndex = 12;
            this.searchResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchResultLabel.Text = ""; // 初始為空字串，由功能實作時填入結果或「分數不存在」

            // --------------------------------------------------
            // Form1 (主表單)
            // --------------------------------------------------
            // 調整表單尺寸以容納新增的搜尋介面（高度擴充）。
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 380);
            this.Controls.Add(this.searchResultLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchPromptLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getScoresButton);
            this.Controls.Add(this.belowAverageLabel);
            this.Controls.Add(this.aboveAverageLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.belowAvgDescriptionLabel);
            this.Controls.Add(this.aboveAvgDescriptionLabel);
            this.Controls.Add(this.avgScoreDescriptionLabel);
            this.Controls.Add(this.testScoresListBox);
            this.Name = "Form1";
            this.Text = "成績清單";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox testScoresListBox;
        private System.Windows.Forms.Label avgScoreDescriptionLabel;
        private System.Windows.Forms.Label aboveAvgDescriptionLabel;
        private System.Windows.Forms.Label belowAvgDescriptionLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label aboveAverageLabel;
        private System.Windows.Forms.Label belowAverageLabel;
        private System.Windows.Forms.Button getScoresButton;
        private System.Windows.Forms.Button exitButton;

        // 新增的介面欄位：搜尋相關（僅介面檔案）
        private System.Windows.Forms.Label searchPromptLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchResultLabel;
    }
}

