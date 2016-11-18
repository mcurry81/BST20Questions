using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BST20Questions
{
    public partial class updateQB : Form
    {
        public updateQB()
        {
            InitializeComponent();
        }

        private void updateQB_Load(object sender, EventArgs e)
        {
            correctAnswer.Text = "Awh man...what is the correct answer?";
            newQ.Text = "What is a question that would be true for your answer but false for my guess?";
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string answer = this.answerText.Text;
            string newQuestion = this.newQText.Text;

            if(answer.Length > 0 && newQuestion.Length > 0)
            {
                TwentyQs.savedCurrent.no = new Node(TwentyQs.savedCurrent.dialogue);
                TwentyQs.savedCurrent.yes = new Node("Are you thinking of a " + answer + "?");
                TwentyQs.savedCurrent.dialogue = newQuestion;

            }

            this.Close();


        }


    }
}
