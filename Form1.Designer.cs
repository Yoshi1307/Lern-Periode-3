namespace WinForms_Lp3
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Spieler = new PictureBox();
            Computer = new PictureBox();
            ball = new PictureBox();
            SpielTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Spieler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Computer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            SuspendLayout();
            // 
            // Spieler
            // 
            Spieler.Image = Properties.Resources.player;
            Spieler.Location = new Point(12, 163);
            Spieler.Name = "Spieler";
            Spieler.Size = new Size(30, 120);
            Spieler.SizeMode = PictureBoxSizeMode.StretchImage;
            Spieler.TabIndex = 0;
            Spieler.TabStop = false;
            // 
            // Computer
            // 
            Computer.Image = (Image)resources.GetObject("Computer.Image");
            Computer.Location = new Point(745, 163);
            Computer.Name = "Computer";
            Computer.Size = new Size(30, 120);
            Computer.SizeMode = PictureBoxSizeMode.StretchImage;
            Computer.TabIndex = 1;
            Computer.TabStop = false;
            // 
            // Ball
            // 
            ball.Image = (Image)resources.GetObject("Ball.Image");
            ball.Location = new Point(385, 165);
            ball.Name = "Ball";
            ball.Size = new Size(40, 40);
            ball.SizeMode = PictureBoxSizeMode.StretchImage;
            ball.TabIndex = 2;
            ball.TabStop = false;
            // 
            // SpielTimer
            // 
            SpielTimer.Enabled = true;
            SpielTimer.Interval = 20;
            SpielTimer.Tick += SpielTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(ball);
            Controls.Add(Computer);
            Controls.Add(Spieler);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Player: 0 -- Computer: 0";
            KeyDown += KeyUp;
            KeyPress += KeyUp;
            ((System.ComponentModel.ISupportInitialize)Spieler).EndInit();
            ((System.ComponentModel.ISupportInitialize)Computer).EndInit();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Spieler;
        private PictureBox Computer;
        private PictureBox ball;
        private System.Windows.Forms.Timer SpielTimer;
    }
}
