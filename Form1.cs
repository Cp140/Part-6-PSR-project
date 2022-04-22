using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_6__PSR_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }
        int userPlay = 0;

       pictureBox1.Image = Properties.Resources.Rock;
       pictureBox2.Image = Properties.Resources.Scissors;

        //Use case statments with if statments inside to determine outcomes

        private void RBPaper_CheckedChanged(object sender, EventArgs e)
        {
            userPlay
        }

        private void BRScissors_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBRock_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
