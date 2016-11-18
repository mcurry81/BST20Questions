using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST20Questions
{
    public class Node
    {
        public string dialogue;
        public Node yes; //left
        public Node no;  //right

        
        public Node(string nodeDialogue)
        {
            this.dialogue = nodeDialogue;
            this.yes = null;
            this.no = null;
        }

        public bool isLeaf()
        {
            return (yes == null && no == null);
        }
      

     /*  public string getMessage(message(Node q)
        {
            return this.dialogue;
        }*/
       
  
    }
}
