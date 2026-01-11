using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {
        public int rounds = 3; // 3 rounds per game
        public int TimePerRound = 6;
        string[] AIchoice = { "rock", "paper", "scissor", "rock", "scissor", "paper" };
        public int randomumber;
        string command;
        Random rnd = new Random();
        string playerChoice;
        int PlayerWins = 0;
        int AIwins = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            playerChoice = "none";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = Convert.ToString(rounds);
            TimePerRound--;
            label4.Text = Convert.ToString(TimePerRound);
            if (TimePerRound < 1)
            {

                timer1.Enabled = false;

                TimePerRound = 6;
                randomumber = rnd.Next(0, 5);
                command = AIchoice[randomumber];

                switch (command)
                {



                    case "rock":
                        pictureBox2.Image = Properties.Resources.rock;
                        break;

                    case "paper":
                        pictureBox2.Image = Properties.Resources.paper;
                        break;

                    case "scissors":
                        pictureBox2.Image = Properties.Resources.scissors;
                        break;

                    default:
                        break;
                }

                if (rounds > 1)
                {
                    checkGame();
                }

            }




            decisionEngine();
        }







        private void checkGame()
        {
            if (playerChoice == "rock" && command == "paper")
            {
                MessageBox.Show("AI Wins");
                AIwins++;
                rounds--;
                nextRound();
            }

            else if (playerChoice == "paper" && command == "rock")
            {
                MessageBox.Show("Player Wins");
                PlayerWins++;
                rounds--;
                nextRound();
            }

            else if (playerChoice == "paper" && command == "scissor")
            {
                MessageBox.Show("AI Wins");
                AIwins++;
                rounds--;
                nextRound();
            }

            else if (playerChoice == "scissor" && command == "paper")
            {
                MessageBox.Show("Player Wins");
                PlayerWins++;
                rounds--;
                nextRound();
            }

            else if (playerChoice == "scissor" && command == "rock")
            {
                MessageBox.Show("AI Wins");
                AIwins++;
                rounds--;
                nextRound();
            }

            else if (playerChoice == "rock" && command == "scissor")
            {
                MessageBox.Show("Player Wins");
                PlayerWins++;
                rounds--;
                nextRound();
            }

            else if (playerChoice == "none")
            {
                MessageBox.Show(label1.Text + "Make a Choice");
                nextRound();
            }
            else
            {
                MessageBox.Show("draw");
                nextRound();
            }
        }

            void decisionEngine()
            {
                if (PlayerWins > AIwins)
                {
                    label3.Text = label1.Text + "Wins the Game";
                }
                else
                {
                    label3.Text = "AI Wins the game";
                }
            }

            void nextRound()
            {
                playerChoice = "none";
                pictureBox1.Image = Properties.Resources.qq;
                timer1.Enabled = true;
                pictureBox2.Image = Properties.Resources.qq;
            }

            void button1_Click(object sender, EventArgs e)
            {
                playerChoice = "rock";
                pictureBox1.Image = Properties.Resources.rock;
            }

        private void button2_Click(object sender, EventArgs e)
        {

            playerChoice = "paper";
            pictureBox1.Image = Properties.Resources.paper;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            playerChoice = "scissor";
            pictureBox1.Image = Properties.Resources.scissors;
        }
    }
    }
    



            


        