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
    public partial class TwentyQs : Form
    {
        Node root;
        public static Node current;
        public static Node savedCurrent;

        public object Form2 { get; private set; }

        public TwentyQs()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            root = new Node("Is it hot?");
            root.yes = new Node("Is it black coffee?");
            root.no = new Node("Is it 2% milk?");

            startGame();

        }

       /* private void content_Click(object sender, EventArgs e)
        {

        }*/

        private void yesButton_Click(object sender, EventArgs e)
        {
            //am i a leaf?
            if(current.isLeaf() == true)
            {
                if(MessageBox.Show("Sweet, I won...hahahaha!! Do you want to play again?", "Twenty Questions", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();

                }
                else
                {
                    startGame();
                }
            }
            else
            {
                current = current.yes;
                content.Text = current.dialogue;
            }
      
        }

    /*    public void updateTree()
        {
            Console.WriteLine("You win, what were you thinking?");
            string userThought = Console.ReadLine();
            //Console.WriteLine("Please enter a question that differentiates a " + this.dialogue + " from " + userThought + ": ");
            string newQuestion = Console.ReadLine();
            Console.WriteLine("If you were thinking of " + userThought + ", then what would the answer to the question you just entered be: (please enter 'yes or 'no')");
            string userInput = Console.ReadLine();
            

        }*/


        private void noButton_Click(object sender, EventArgs e)
        {
            //am I a leaf
            if(current.isLeaf() == false)
            {
                current = current.no;
                content.Text = current.dialogue;

            }
            else
            {
                savedCurrent = current;
                startGame();
                updateQB update = new updateQB();
                update.ShowDialog();
            }
           
          
        }

       /* private bool isLeaf(Node node, Node current)
        {
            throw new NotImplementedException();
        }*/

        public void startGame()
        {
            current = root;
            content.Text = current.dialogue;

        }

    
        


    }
}
