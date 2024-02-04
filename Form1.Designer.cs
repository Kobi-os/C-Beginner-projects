namespace Magic8Ball
{
    partial class MagicEightBall
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
            submitButton = new Button();
            questionBox = new TextBox();
            answerLabel = new Label();
            SuspendLayout();
            // 
            // submitButton
            // 
            submitButton.BackColor = SystemColors.ActiveCaptionText;
            submitButton.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            submitButton.ForeColor = SystemColors.ButtonHighlight;
            submitButton.Location = new Point(10, 415);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(167, 67);
            submitButton.TabIndex = 0;
            submitButton.Text = "Tell me!";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // questionBox
            // 
            questionBox.Location = new Point(10, 386);
            questionBox.Name = "questionBox";
            questionBox.Size = new Size(167, 23);
            questionBox.TabIndex = 1;
            questionBox.Text = "Ask your question!";
            // 
            // answerLabel
            // 
            answerLabel.Location = new Point(341, 169);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new Size(111, 101);
            answerLabel.TabIndex = 2;
            answerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MagicEightBall
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 494);
            Controls.Add(answerLabel);
            Controls.Add(questionBox);
            Controls.Add(submitButton);
            Name = "MagicEightBall";
            Text = "Magic 8 Ball";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submitButton;
        private TextBox questionBox;
        private Label answerLabel;
    }
}