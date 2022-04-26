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

        int userPlay = 0;
        int computerPlay = 0;
        int playerWin = 0;
        int computerWin = 0;
        int catsGame = 0;


        public Form1()
        {
            InitializeComponent();

            img1.Image = Properties.Resources.Openscene;
            img2.Image = Properties.Resources.Openscene;

            








        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (userPlay == 1)
            {
                switch (computerPlay)
                {
                    case 1:
                        catsGame++;
                        break;

                    case 2:
                        computerWin++;
                        break;

                    case 3:
                        playerWin++;
                        break;
                }

            }

            if (userPlay == 2)
            {
                switch (computerPlay)
                {
                    case 1:
                        playerWin++;
                        break;

                    case 2:
                        catsGame++;
                        break;

                    case 3:
                        computerWin++;
                        break;

                }

            }

            if (userPlay == 3)
            {
                switch (computerPlay)
                {
                    case 1:
                        computerWin++;
                        break;

                    case 2:
                        playerWin++;
                        break;

                    case 3:
                        catsGame++;
                        break;

                }

            }
        }

        //Use case statments with if statments inside to determine outcomes
        private void RBPaper_CheckedChanged(object sender, EventArgs e)
        {
            userPlay = 1;
        }

        private void BRScissors_CheckedChanged(object sender, EventArgs e)
        {
            userPlay = 2;
        }

        private void RBRock_CheckedChanged(object sender, EventArgs e)
        {
            userPlay = 3;
        }

 
    }
}
