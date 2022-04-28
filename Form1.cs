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

        //Random number generator
        Random rnd = new Random();

        //variables
        int userPlay = 0;         //User Choice
        int computerPlay = 0;     //Computer Choice
        int playerWin = 0;        //Player Wins
        int computerWin = 0;      //Computer Wins
        int catsGame = 0;         //Tie Games
        int gameCount = 0;        //Total Games
        public Form1()
        {
            InitializeComponent();

            img1.Image = Properties.Resources.Openscene;
            img2.Image = Properties.Resources.Openscene;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //Generates computer play
            computerPlay = rnd.Next(1, 4);

            //Counts games
            gameCount++;

            //Checks user 1 against computer
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

            //Checks user 2 againts computer
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

            //Checks user 3 againts computer
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
            
            //Prints images user
            switch (userPlay)
            {
                case 1:
                    img2.Image = Properties.Resources.Paper;
                    break;
                case 2:
                    img2.Image = Properties.Resources.Scissors;
                    break;
                case 3:
                    img2.Image = Properties.Resources.Rock;
                    break;
            }

            //Prints images Computer
            switch (computerPlay)
            {
                case 1:
                    img1.Image = Properties.Resources.Paper;
                    break;
                case 2:
                    img1.Image = Properties.Resources.Scissors;
                    break;
                case 3:
                    img1.Image = Properties.Resources.Rock;
                    break;
            }

            //Displays score
            lblComputerCounter.Text = ($"{computerWin}");
            lblPlayerCounter.Text = ($"{playerWin}");
            lblGameCounter.Text = ($"{gameCount}");
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            img1.Image = Properties.Resources.Openscene; //reset first picture
            img2.Image = Properties.Resources.Openscene; //reset second picture
            //reset varibles
            playerWin = 0;        //Player Wins
            computerWin = 0;      //Computer Wins
            catsGame = 0;         //Tie Games
            gameCount = 0;        //Total Games
            //Update screen
            lblComputerCounter.Text = ($"{computerWin}");
            lblPlayerCounter.Text = ($"{playerWin}");
            lblGameCounter.Text = ($"{gameCount}");
        }
    }
}
