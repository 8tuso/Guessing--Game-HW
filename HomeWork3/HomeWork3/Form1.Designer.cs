namespace HomeWork3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPrompt = new Label();
            txtGuess = new TextBox();
            btnGuess = new Button();
            lblFeedback = new Label();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new Point(213, 48);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(309, 40);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "I have a number between 1 and 1000.\r\nCan you guess my number? Enter your Guess: ";
            lblPrompt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(202, 118);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(125, 27);
            txtGuess.TabIndex = 1;
            // 
            // btnGuess
            // 
            btnGuess.Location = new Point(519, 118);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(94, 29);
            btnGuess.TabIndex = 2;
            btnGuess.Text = "New Game";
            btnGuess.UseVisualStyleBackColor = true;
            btnGuess.Click += btnGuess_Click;
            // 
            // lblFeedback
            // 
            lblFeedback.AutoSize = true;
            lblFeedback.Location = new Point(333, 122);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(0, 20);
            lblFeedback.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 310);
            Controls.Add(lblFeedback);
            Controls.Add(btnGuess);
            Controls.Add(txtGuess);
            Controls.Add(lblPrompt);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrompt;
        private TextBox txtGuess;
        private Button btnGuess;
        private Label lblFeedback;
    }
}
