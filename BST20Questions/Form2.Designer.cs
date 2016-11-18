namespace BST20Questions
{
    partial class updateQB
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
            this.correctAnswer = new System.Windows.Forms.Label();
            this.newQ = new System.Windows.Forms.Label();
            this.answerText = new System.Windows.Forms.TextBox();
            this.newQText = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // correctAnswer
            // 
            this.correctAnswer.AutoSize = true;
            this.correctAnswer.Location = new System.Drawing.Point(244, 22);
            this.correctAnswer.Name = "correctAnswer";
            this.correctAnswer.Size = new System.Drawing.Size(70, 25);
            this.correctAnswer.TabIndex = 0;
            this.correctAnswer.Text = "label1";
            // 
            // newQ
            // 
            this.newQ.AutoSize = true;
            this.newQ.Location = new System.Drawing.Point(244, 148);
            this.newQ.Name = "newQ";
            this.newQ.Size = new System.Drawing.Size(70, 25);
            this.newQ.TabIndex = 1;
            this.newQ.Text = "label2";
            // 
            // answerText
            // 
            this.answerText.Location = new System.Drawing.Point(248, 61);
            this.answerText.Name = "answerText";
            this.answerText.Size = new System.Drawing.Size(100, 31);
            this.answerText.TabIndex = 2;
            // 
            // newQText
            // 
            this.newQText.Location = new System.Drawing.Point(249, 193);
            this.newQText.Name = "newQText";
            this.newQText.Size = new System.Drawing.Size(100, 31);
            this.newQText.TabIndex = 3;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(249, 288);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(115, 47);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // updateQB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 629);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.newQText);
            this.Controls.Add(this.answerText);
            this.Controls.Add(this.newQ);
            this.Controls.Add(this.correctAnswer);
            this.Name = "updateQB";
            this.Text = "Update Question Bank";
            this.Load += new System.EventHandler(this.updateQB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label correctAnswer;
        private System.Windows.Forms.Label newQ;
        private System.Windows.Forms.TextBox answerText;
        private System.Windows.Forms.TextBox newQText;
        private System.Windows.Forms.Button submitButton;
    }
}