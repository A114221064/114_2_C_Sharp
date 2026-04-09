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
        // 類別層級的分數清單（改為儲存學號 + 分數）
        private List<ScoreEntry> scoresList;

        public Form1()
        {
            InitializeComponent();

            // 初始化類別層級的清單
            this.scoresList = new List<ScoreEntry>();

            // 將搜尋按鈕事件與處理方法綁定（Designer 未綁定事件）
            // 這只處理 UI 行為的綁定，不會改變現有功能邏輯
            this.searchButton.Click += new EventHandler(this.searchButton_Click);
        }

        // 內部型別：學號與分數的對應
        private class ScoreEntry
        {
            public string StudentId { get; set; }
            public int Score { get; set; }

            public ScoreEntry(string studentId, int score)
            {
                StudentId = studentId;
                Score = score;
            }
        }

        private void ReadScores(List<ScoreEntry> scoresList)
        {
            string filePath = "TestScores.txt"; // The file path
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("找不到成績檔案：" + filePath);
                    return;
                }

                // 讀取所有非空行
                string[] lines = File.ReadAllLines(filePath)
                                     .Where(l => !string.IsNullOrWhiteSpace(l))
                                     .ToArray();

                if (lines.Length == 0)
                {
                    return;
                }

                // 若任一行符合「第一個 token 非數字 且 第二個 token 為數字」 ，
                // 則以每行的第一個 token 當學號，第二個（或第一個數字）當分數。
                bool perLineIdDetected = lines.Any(line =>
                {
                    var parts = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                    return parts.Length >= 2 && !int.TryParse(parts[0], out _) && int.TryParse(parts[1], out _);
                });

                if (perLineIdDetected)
                {
                    foreach (var line in lines)
                    {
                        var parts = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                        if (parts.Length < 2)
                        {
                            // 無法解析，跳過
                            continue;
                        }

                        string studentId = parts[0];
                        // 尋找該行內第一個可以解析成整數的 token 作為分數（通常為 parts[1]）
                        int score = int.MinValue;
                        bool found = false;
                        for (int i = 1; i < parts.Length; i++)
                        {
                            if (int.TryParse(parts[i], out score))
                            {
                                found = true;
                                break;
                            }
                        }

                        if (found)
                        {
                            scoresList.Add(new ScoreEntry(studentId, score));
                        }
                        // 若該行沒有數字則略過
                    }

                    return;
                }

                // 否則合併所有內容為 token，支援單行或多行交錯的 [學號, 分數, 學號, 分數, ...]
                string content = string.Join(" ", lines);
                string[] tokens = content.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 0)
                {
                    return;
                }

                // 若 token 中有非數字，視為交錯的學號/分數對
                bool hasNonNumeric = tokens.Any(t => !int.TryParse(t, out _));

                if (hasNonNumeric && tokens.Length >= 2)
                {
                    for (int i = 0; i + 1 < tokens.Length; i += 2)
                    {
                        string studentId = tokens[i];
                        string scoreToken = tokens[i + 1];

                        if (int.TryParse(scoreToken, out int score))
                        {
                            scoresList.Add(new ScoreEntry(studentId, score));
                        }
                        else
                        {
                            // 分數解析失敗則跳過此 pair
                            continue;
                        }
                    }
                }
                else
                {
                    // 全為數字（舊格式：每個 token 或每行為分數）
                    for (int i = 0; i < tokens.Length; i++)
                    {
                        if (int.TryParse(tokens[i], out int score))
                        {
                            // 使用自動產生的學號標示，保留順序
                            scoresList.Add(new ScoreEntry($"NoID_{i + 1}", score));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀取成績時發生錯誤：" + ex.Message);
            }
        }

        // 顯示分數於 ListBox（介面更新）
        // 以「學號 分數」格式顯示，符合使用者需求
        private void DisplayScores(List<ScoreEntry> scoresList)
        {
            this.testScoresListBox.Items.Clear();
            for (int i = 0; i < scoresList.Count; i++)
            {
                var entry = scoresList[i];
                this.testScoresListBox.Items.Add(string.Format("{0} {1}", entry.StudentId, entry.Score));
            }
        }

        // 計算平均（回傳 double）
        private double Average(List<ScoreEntry> scoresList)
        {
            if (scoresList == null || scoresList.Count == 0)
            {
                return 0.0;
            }

            // 使用 LINQ 的 Average()，以 Score 為來源
            return scoresList.Average(e => e.Score);
        }

        // 計算高於平均的個數（外部已算出平均，傳入以避免重複計算）
        private int AboveAverage(List<ScoreEntry> scoresList, double averageScore)
        {
            if (scoresList == null || scoresList.Count == 0)
            {
                return 0;
            }

            return scoresList.Count(s => s.Score > averageScore);
        }

        // 計算低於平均的個數（內部自行計算平均以符合原先呼叫方式）
        private int BelowAverage(List<ScoreEntry> scoresList)
        {
            if (scoresList == null || scoresList.Count == 0)
            {
                return 0;
            }

            double avg = Average(scoresList);
            return scoresList.Count(s => s.Score < avg);
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

            // 找到第一個符合值的索引（0-based） — 現在依 Score 屬性搜尋
            int index = this.scoresList.FindIndex(entry => entry.Score == target);
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
