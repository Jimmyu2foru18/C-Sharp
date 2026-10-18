using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch_3_Number_Guessing_Game_
{
    public partial class Ch_4_Guessing_Game : Form
    {    
        private int randomNumber;
        private int attemptsLeft = 6;
        public Ch_4_Guessing_Game()
        {
            InitializeComponent();
        }
    
        private void InitializeGame()
        {
            Random random = new Random();
            randomNumber = random.Next(0, 101);
            attemptsLeft = 6;
            lstResults.Items.Clear();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int guess;
            if (int.TryParse(txtEnterNum.Text, out guess))
            {
                if (guess == randomNumber)
                {
                    lstResults.Items.Add($" You've guessed the correct number: {randomNumber}");
                    MessageBox.Show("Congratulations! You've guessed the correct number!", "Victory");
                    InitializeGame();
                }
                else
                {
                    string result = guess < randomNumber ? "Higher" : "Lower";
                    lstResults.Items.Add($"Attempt {7 - attemptsLeft}: {guess} - {result}");
                    attemptsLeft--;

                    if (attemptsLeft == 0)
                    {
                        MessageBox.Show($"Sorry, you've used all your attempts. The correct number was: {randomNumber}", "Defeat");
                        InitializeGame();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.", "Invalid Input");
            }

            txtEnterNum.Clear();
            txtEnterNum.Focus();
        }
        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Number Guessing Game!\n\nTry to guess the correct number between 0 - 100 \n\nYou have 6 chances to guess it correctly. Good luck!", "About");
        }
    }
}

