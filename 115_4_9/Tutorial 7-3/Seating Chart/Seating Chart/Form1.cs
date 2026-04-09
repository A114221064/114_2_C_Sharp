using System;
using System.Windows.Forms;

namespace Seating_Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 按下「顯示價格」按鈕時的處理
        // 從 rowTextBox 與 colTextBox 讀取列與欄，驗證範圍後顯示對應座位的價格於 priceLabel
        private void displayPriceButton_Click(object sender, EventArgs e)
        {
            int row, col;

            // 用二維陣列表示各座位價格（6 x 4）
            decimal[,] seatPrices = {
                {450m, 450m, 450m, 450m},
                {425m, 425m, 425m, 425m},
                {400m, 400m, 400m, 400m},
                {375m, 375m, 375m, 375m},
                {375m, 375m, 375m, 375m},
                {350m, 350m, 350m, 350m}
            };

            // 驗證列輸入為整數且在陣列範圍內（使用者以 1-based 輸入）
            if (int.TryParse(rowTextBox.Text, out row) && (row > 0) && ((row - 1) < seatPrices.GetLength(0)))
            {
                // 驗證欄輸入為整數且在陣列範圍內（使用者以 1-based 輸入）
                if (int.TryParse(colTextBox.Text, out col) && (col > 0) && ((col - 1) < seatPrices.GetLength(1)))
                {
                    // 顯示價格（格式化為貨幣）
                    priceLabel.Text = seatPrices[row - 1, col - 1].ToString("c");
                }
                else
                {
                    MessageBox.Show("請輸入有效的行數", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的列數", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 按下「結束」按鈕時關閉表單
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
