using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The NumberUpperCase method accepts a string argument
        // and returns the number of uppercase letters it contains.
        private int NumberUpperCase(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (char.IsUpper(c))
                {
                    count++;
                }
            }
            return count;
        }

        // The NumberLowerCase method accepts a string argument
        // and returns the number of lowercase letters it contains.
        private int NumberLowerCase(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (char.IsLower(c))
                {
                    count++;
                }
            }
            return count;
        }

           

        // The NumberLowerCase method accepts a string argument
        // and returns the number of lowercase letters it contains.
        private int NumberDighits(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }
            return count;
        }

        // The NumberDigits method accepts a string argument
        // and returns the number of numeric digits it contains.
        private int NumberDigits(string input)
        {
            if (input == null)
            {
                return 0;
            }

            int count = 0;
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }

            return count;
        }

        private void checkPasswordButton_Click(object sender, EventArgs e)
        {
            string password = passwordTextBox.Text;
            if (password.Length < 8)
            {
                MessageBox.Show("密碼必須至少包含 8 個字元。","密碼驗證",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (NumberUpperCase(password) == 0)
            {
                MessageBox.Show("密碼必須包含至少一個大寫字母。","密碼驗證",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (NumberLowerCase(password) == 0)
            {
                MessageBox.Show("密碼必須包含至少一個小寫字母。","密碼驗證",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (NumberDigits(password) == 0)
            {
                MessageBox.Show("密碼必須包含至少一個數字。","密碼驗證",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("密碼驗證成功！","密碼驗證",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
