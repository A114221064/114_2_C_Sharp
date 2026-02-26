using System;
using System.Windows.Forms;

namespace Review_Q1
{
    public partial class Form1 : Form
    {
        private enum Choice { None = 0, Stone = 1, Paper = 2, Scissor = 3 }

        private Choice playerChoice = Choice.None;
        private Choice compChoice = Choice.None;
        private int playerWins = 0;
        private int compWins = 0;
        private int draws = 0;
        private readonly Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize UI: clear images and reset result text
            playerPictureBox.Image = null;
            computerPictureBox.Image = null;
            resultLabel.Text = string.Empty;

            playerChoice = Choice.None;
            compChoice = Choice.None;
        }

        private void getCompChoice()
        {
            int v = rnd.Next(1, 4); // 1..3
            compChoice = (Choice)v;
        }

        private void showComputerImage()
        {
            if (computerPictureBox == null) return;

            switch (compChoice)
            {
                case Choice.Stone:
                    computerPictureBox.Image = Properties.Resources.stone_computer;
                    break;
                case Choice.Paper:
                    computerPictureBox.Image = Properties.Resources.paper_computer;
                    break;
                case Choice.Scissor:
                    computerPictureBox.Image = Properties.Resources.scissor_computer;
                    break;
                default:
                    computerPictureBox.Image = null;
                    break;
            }
        }

        private void showPlayerImage()
        {
            if (playerPictureBox == null) return;

            switch (playerChoice)
            {
                case Choice.Stone:
                    playerPictureBox.Image = Properties.Resources.stone_player;
                    break;
                case Choice.Paper:
                    playerPictureBox.Image = Properties.Resources.paper_player;
                    break;
                case Choice.Scissor:
                    playerPictureBox.Image = Properties.Resources.scissor_player;
                    break;
                default:
                    playerPictureBox.Image = null;
                    break;
            }
        }

        private void showWinner()
        {
            if (playerChoice == Choice.None || compChoice == Choice.None)
            {
                resultLabel.Text = string.Empty;
                return;
            }

            if (playerChoice == compChoice)
            {
                draws++;
                resultLabel.Text = "平手";
                return;
            }

            bool playerWinsRound = false;

            // Stone beats Scissor, Scissor beats Paper, Paper beats Stone
            if (playerChoice == Choice.Stone && compChoice == Choice.Scissor) playerWinsRound = true;
            else if (playerChoice == Choice.Scissor && compChoice == Choice.Paper) playerWinsRound = true;
            else if (playerChoice == Choice.Paper && compChoice == Choice.Stone) playerWinsRound = true;

            if (playerWinsRound)
            {
                playerWins++;
                resultLabel.Text = "玩家贏";
            }
            else
            {
                compWins++;
                resultLabel.Text = "電腦贏";
            }
        }

        private void stoneButton_Click(object sender, EventArgs e)
        {
            playerChoice = Choice.Stone;
            showPlayerImage();
            getCompChoice();
            showComputerImage();
            showWinner();
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            playerChoice = Choice.Paper;
            showPlayerImage();
            getCompChoice();
            showComputerImage();
            showWinner();
        }

        private void scissorButton_Click(object sender, EventArgs e)
        {
            playerChoice = Choice.Scissor;
            showPlayerImage();
            getCompChoice();
            showComputerImage();
            showWinner();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            string msg = $"遊戲結束\n玩家勝: {playerWins}\n電腦勝: {compWins}\n平手: {draws}";
            MessageBox.Show(msg, "統計", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
