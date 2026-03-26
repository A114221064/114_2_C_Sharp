using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test_Score_List
{
    public partial class Form1 : Form
    {
        // 類別層級的分數清單，讓介面上的搜尋按鈕能夠存取已讀取的分數資料
        private List<int> scoresList;

        public Form1()
        {
            InitializeComponent();

            // 初始化類別層級的清單
            this.scoresList = new List<int>();

            // 將搜尋按鈕事件與處理方法綁定（Designer 未綁定事件）
            // 這只處理 UI 行為的綁定，不會改變現有功能邏輯
            this.searchButton.Click += new EventHandler(this.searchButton_Click);
        }

        private void ReadScores(List<int> scoresList)
        {
            string filePath = "TestScores.txt"; // The file path
            // Check if the file exists.
            try
            {
                // Read the scores from the file and add them to the List.
                using (StreamReader reader = File.OpenText(filePath))
                {
                    string line;
                    while (!reader.EndOfStream)
                    {
                        scoresList.Add(int.Parse(reader.ReadLine()));
                    }
                }
            }   
            catch(Exception ex)
            {
                MessageBox.Show("讀取成績時發生錯誤" + ex.Message);
            }
        }

        // 顯示分數於 ListBox（介面更新）
        // 以「第 n 筆：score」格式顯示，讓使用者容易看見位置
        private void DisplayScores(List<int> scoresList)
        {
            this.testScoresListBox.Items.Clear();
            for (int i = 0; i < scoresList.Count; i++)
            {
                // 第 i+1 筆分數
                this.testScoresListBox.Items.Add(string.Format("第 {0} 筆：{1}", i + 1, scoresList[i]));
            }
        }

        // 計算平均（回傳 double）
        private double Average(List<int> scoresList)
        {
            if (scoresList == null || scoresList.Count == 0)
            {
                return 0.0;
            }

            // 使用 LINQ 的 Average()，回傳 double
            return scoresList.Average();
        }

        // 計算高於平均的個數（外部已算出平均，傳入以避免重複計算）
        private int AboveAverage(List<int> scoresList, double averageScore)
        {
            if (scoresList == null || scoresList.Count == 0)
            {
                return 0;
            }

            return scoresList.Count(s => s > averageScore);
        }

        // 計算低於平均的個數（內部自行計算平均以符合原先呼叫方式）
        private int BelowAverage(List<int> scoresList)
        {
            if (scoresList == null || scoresList.Count == 0)
            {
                return 0;
            }

            double avg = Average(scoresList);
            return scoresList.Count(s => s < avg);
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            double averageScore;    // To hold the average score
            int numAboveAverage;    // Number of above average scores
            int numBelowAverage;    // Number of below average scores

            // 使用類別層級的 scoresList，先清除舊資料再讀取新資料
            this.scoresList.Clear();

            // Read the scores from the file into the List.
            ReadScores(this.scoresList);

            // Display the scores.
            DisplayScores(this.scoresList);

            // Display the average score.
            averageScore = Average(this.scoresList);
            averageLabel.Text = averageScore.ToString("n1");

            // Display the number of above average scores.
            numAboveAverage = AboveAverage(this.scoresList, averageScore);
            aboveAverageLabel.Text = numAboveAverage.ToString();

            // Display the number of below average scores.
            numBelowAverage = BelowAverage(this.scoresList);
            belowAverageLabel.Text = numBelowAverage.ToString();
        }

        // 搜尋按鈕的事件處理（介面功能）
        // 解析使用者輸入，若找到則顯示「所在位置：第 N 筆」，找不到則顯示「分數不存在」
        private void searchButton_Click(object sender, EventArgs e)
        {
            // 若尚未讀取任何分數，提示使用者先讀取
            if (this.scoresList == null || this.scoresList.Count == 0)
            {
                this.searchResultLabel.Text = "請先讀取分數";
                return;
            }

            string input = this.searchTextBox.Text.Trim();
            if (!int.TryParse(input, out int target))
            {
                // 輸入不是整數
                this.searchResultLabel.Text = "輸入格式不正確";
                return;
            }

            // 找到第一個符合值的索引（0-based）
            int index = this.scoresList.IndexOf(target);
            if (index >= 0)
            {
                // 回報使用者以 1-based 的位置，較符合一般使用者直覺
                this.searchResultLabel.Text = $"所在位置：第 {index + 1} 筆";
            }
            else
            {
                this.searchResultLabel.Text = "分數不存在";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
