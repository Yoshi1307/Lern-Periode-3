using System.Diagnostics.Tracing;

namespace Hangman1
{
    public partial class Form1 : Form
    {

        private string wordToGuess;
        private string wordToGuessDisplay;
        private List<char> guessedLetters;
        private int wrongGuesses;

        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblWrongGuesses_Click(object sender, EventArgs e)
        {

        }

        private void StartNewGame()
        {
            wordToGuess = GetRandomWord();
            wordToGuessDisplay = new string('_', wordToGuess.Length);
            guessedLetters = new List<char>();
            wrongGuesses = 0;
            lblWorldDisplay.Text = wordToGuessDisplay;
            lblWrongGuesses.Text = "Wrong Guesses: " + wrongGuesses;
            txtGuess.Text = "";
            txtGuess.Focus();
        }
        private string GetRandomWord()
        {
            string[] words = { "Apfel", "Glanz", "Blume", "Sonne", "Eimer", "Zebra", "Welle", "Knopf", "Vogel", "Zange", "Blass", "Kamel" };
            Random Random = new Random();
            return words[Random.Next(words.Length)];
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string guess = txtGuess.Text.ToLower();
            if (guess.Length == 1 && char.IsLetter(guess[0]))
            {
                char guessedLetter = guess[0];
                if (!guessedLetters.Contains(guessedLetter))
                {
                    guessedLetters.Add(guessedLetter);
                    if (wordToGuess.Contains(guessedLetter))
                    {
                        UpdateWordToGuessDisplay(guessedLetter);
                    }
                    else
                    {
                        wrongGuesses++;
                        lblWrongGuesses.Text = "Wrong Guesses: " + wrongGuesses;
                    }

                    if (wrongGuesses >= 6)
                    {
                        MessageBox.Show("Game Over! The word was: " + wordToGuess);
                        StartNewGame();
                    }
                    else if (wordToGuessDisplay == wordToGuess)
                    {
                        MessageBox.Show("Congratulations! You guessed the word: " + wordToGuess);
                        StartNewGame();
                    }
                }
            }
            txtGuess.Text = "";
            txtGuess.Focus();

        }
        private void UpdateWordToGuessDisplay(char guessedLetter)
        {
            char[] wordToGuessDisplayArray = wordToGuessDisplay.ToCharArray();
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (wordToGuess[i] == guessedLetter)
                {
                    wordToGuessDisplayArray[i] = guessedLetter;
                }
            }
            wordToGuessDisplay = new string(wordToGuessDisplayArray);
            lblWorldDisplay.Text = wordToGuessDisplay;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }
    }
}
