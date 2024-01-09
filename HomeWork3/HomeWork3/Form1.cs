namespace HomeWork3
{
    public partial class MainForm : Form
    {
        private int targetNumber;
        private const int lowerBound = 1;
        private const int upperBound = 1000;
        private bool gameWon;

        public MainForm()
        {
            InitializeComponent();
            InitializeGame();

        }


        private void InitializeGame()
        {
            Random random = new Random();
            targetNumber = random.Next(lowerBound, upperBound);
            MessageBox.Show($"The target number is {targetNumber}. Try to guess it!", "Game Start", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gameWon = false;

            btnGuess.Enabled = true;
            txtGuess.Enabled = true;
            txtGuess.Clear();
            txtGuess.Focus();
            ChangeBackgroundColorToDefault();

            lblFeedback.Text = "Guess result appears here.";

        }



        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (gameWon)
            {
                // User has won, play again
                InitializeGame();
            }
            else
            {
                // User is still guessing
                int userGuess;
                if (int.TryParse(txtGuess.Text, out userGuess))
                {
                    CheckGuess(userGuess);
                }
                else
                {
                    MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }


        private void UpdateUI(int difference, int userGuess)
        {
            if (difference < 10)
            {
                lblFeedback.Text = "Warmer!";
                ChangeBackgroundColorToRed();

                // Add the following lines for "Too High" or "Too Low" feedback:
                if (targetNumber > userGuess)
                {
                    lblFeedback.Text += " Too Low!";
                }
                else if (targetNumber < userGuess) 
                {
                    lblFeedback.Text += " Too High!";
                }
            }
            else
            {
                lblFeedback.Text = "Colder!";
                ChangeBackgroundColorToBlue();
                if (targetNumber > userGuess)
                {
                    lblFeedback.Text += " Too Low!";
                }
                else if (targetNumber < userGuess)
                {
                    lblFeedback.Text += " Too High!";
                }
            }
        }

        // Modify the CheckGuess method to pass userGuess to UpdateUI:
        private void CheckGuess(int userGuess)
        {
            int difference = Math.Abs(targetNumber - userGuess);

            if (userGuess == targetNumber)
            {
                GameWon();
            }
            else
            {
                UpdateUI(difference, userGuess);
            }
        }


        private void ChangeBackgroundColorToRed()
        {
            this.BackColor = System.Drawing.Color.Red;
        }

        private void ChangeBackgroundColorToBlue()
        {
            this.BackColor = System.Drawing.Color.Blue;
        }

        private void ChangeBackgroundColorToDefault()
        {
            this.BackColor = System.Drawing.SystemColors.Control;
        }



        private void GameWon()
        {
            gameWon = true;
            MessageBox.Show("Correct!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.BackColor = System.Drawing.Color.Green;

            // Reset the game for a new round
            InitializeGame();
        }

    }


}