using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_6
{
    public partial class rockPaperScissor : Form
    {
        public rockPaperScissor()
        {
            InitializeComponent();
        }
        //global variables for radom number method and player choice methods to be used by game method
        private int cNumber;
        private int? pNumber; // private int? allows for null value to test for no input

        private void cRandomNumber()  //module for random number method
        {
            Random rand = new Random();
            cNumber = rand.Next(3) + 1;
        }
        private void setPChoice (int value)  //module for setting the players choice method to variable pNumber 
        {
            pNumber = value;
        }
        private void gameLogic () //module for the game play logic using switch nested in switch
        {
            if (pNumber != null) //if statment to test is any button was pressed
            switch (pNumber)
            {
                case 1:  // user picked rock
                    switch (cNumber) //this is the number chosen by the random generator
                    {
                        case 1: //computer chose rock
                            playerPictureBox.Image = Properties.Resources.rock2;
                            computerPictureBox.Image = Properties.Resources.rock2;
                            resultLabel.Text = "It's a tie. Computer chose rock.";
                            break;
                        case 2: //computer chose paper
                            playerPictureBox.Image = Properties.Resources.rock2;
                            computerPictureBox.Image = Properties.Resources.paper2;
                            resultLabel.Text = "You lost. Computer chose paper. Paper wraps rock!";
                            break;
                        case 3: //computer chose scissors
                            playerPictureBox.Image = Properties.Resources.rock2;
                            computerPictureBox.Image = Properties.Resources.scissor2;
                            resultLabel.Text = "You win! Computer chose scissors. Rock breaks scissors!";
                            break;
                    }
                            break;

                case 2: //user picked paper
                     switch (cNumber)
                        { 
                            case 1: //computer chose rock
                            playerPictureBox.Image = Properties.Resources.paper2;
                            computerPictureBox.Image = Properties.Resources.rock2;
                            resultLabel.Text = "You win. Computer chose Rock. Paper wraps rock!";
                            break;
                        case 2: //computer chose paper
                            playerPictureBox.Image = Properties.Resources.paper2;
                            computerPictureBox.Image = Properties.Resources.paper2;
                            resultLabel.Text = "It's a tie. Computer chose paper.";
                            break;
                        case 3: //computer chose scissors
                            playerPictureBox.Image = Properties.Resources.paper2;
                            computerPictureBox.Image = Properties.Resources.scissor2;
                            resultLabel.Text = "You lose! Computer chose scissors. Scissors cut paper!";
                            break;
                        }
                        break;
                case 3: //user picked scissors
                    switch (cNumber)
                    {
                        case 1: //computer chose rock
                            playerPictureBox.Image = Properties.Resources.scissor2;
                            computerPictureBox.Image = Properties.Resources.rock2;
                            resultLabel.Text = "You lose. Computer chose Rock. Rock breaks scissors!";
                            break;
                        case 2: //computer chose paper
                            playerPictureBox.Image = Properties.Resources.scissor2;
                            computerPictureBox.Image = Properties.Resources.paper2;
                            resultLabel.Text = "You win. Computer chose paper. Scissors cut paper!";
                            break;
                        case 3: //computer chose scissors
                            playerPictureBox.Image = Properties.Resources.scissor2;
                            computerPictureBox.Image = Properties.Resources.scissor2;
                            resultLabel.Text = "It's a tie. Computer chose scissors.";
                            break;
                    }
                    break;
               }
            else
            {
                resultLabel.Text = "You must choose a weapon before submitting.";
            }
            }
        
       private void rockButton_Click(object sender, EventArgs e)
        {
            setPChoice (1); // passes 1 "rock" to PChoice method that sets it to global variable pNumber
        }       
        private void paperButton_Click(object sender, EventArgs e)
        {
            setPChoice (2); // passes 2 "paper" to PChoice method that sets it to global variable pNumber
        }      
        private void scissorButton_Click(object sender, EventArgs e)
        {
            setPChoice(3); // passes 3 "scissors" to PChoice method that sets it to global variable pNumber
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();  //exit button
        }

        private void submitChoiceButton_Click(object sender, EventArgs e) //Choice button methods
        {
            cRandomNumber(); // call generate random number method
            gameLogic(); // call game logic method
        }
    }
}
