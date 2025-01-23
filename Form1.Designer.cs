namespace Hangman1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWorldDisplay = new Label();
            txtGuess = new TextBox();
            textBox1 = new TextBox();
            btnGuess = new Button();
            label1 = new Label();
            lblWrongGuesses = new Label();
            btnNewGame = new Button();
            SuspendLayout();
            // 
            // lblWorldDisplay
            // 
            lblWorldDisplay.AutoSize = true;
            lblWorldDisplay.Font = new Font("Microsoft YaHei", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWorldDisplay.Location = new Point(450, 67);
            lblWorldDisplay.Name = "lblWorldDisplay";
            lblWorldDisplay.Size = new Size(82, 37);
            lblWorldDisplay.TabIndex = 0;
            lblWorldDisplay.Text = "_____";
            // 
            // txtGuess
            // 
            txtGuess.Font = new Font("Microsoft YaHei", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGuess.Location = new Point(290, 168);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(437, 44);
            txtGuess.TabIndex = 1;
            txtGuess.TextChanged += txtGuess_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft YaHei", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(146, 168);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 44);
            textBox1.TabIndex = 2;
            textBox1.Text = "Eingabe ";
            // 
            // btnGuess
            // 
            btnGuess.Font = new Font("Microsoft YaHei", 14F, FontStyle.Bold);
            btnGuess.Location = new Point(404, 241);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(191, 52);
            btnGuess.TabIndex = 3;
            btnGuess.Text = "Probieren";
            btnGuess.UseVisualStyleBackColor = true;
            btnGuess.Click += btnGuess_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(426, 448);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 4;
            // 
            // lblWrongGuesses
            // 
            lblWrongGuesses.AutoSize = true;
            lblWrongGuesses.Font = new Font("Microsoft YaHei", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWrongGuesses.Location = new Point(32, 334);
            lblWrongGuesses.Name = "lblWrongGuesses";
            lblWrongGuesses.Size = new Size(288, 37);
            lblWrongGuesses.TabIndex = 5;
            lblWrongGuesses.Text = "Falsche Versuche: 0";
            lblWrongGuesses.Click += lblWrongGuesses_Click;
            // 
            // btnNewGame
            // 
            btnNewGame.Font = new Font("Microsoft YaHei", 14F, FontStyle.Bold);
            btnNewGame.Location = new Point(290, 476);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(215, 63);
            btnNewGame.TabIndex = 6;
            btnNewGame.Text = "Neues Spiel";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 656);
            Controls.Add(btnNewGame);
            Controls.Add(lblWrongGuesses);
            Controls.Add(label1);
            Controls.Add(btnGuess);
            Controls.Add(textBox1);
            Controls.Add(txtGuess);
            Controls.Add(lblWorldDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWorldDisplay;
        private TextBox txtGuess;
        private TextBox textBox1;
        private Button btnGuess;
        private Label label1;
        private Label lblWrongGuesses;
        private Button btnNewGame;
    }
}
