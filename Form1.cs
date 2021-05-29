using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoggyRace
{
    public partial class Form1 : Form
    {
        Guy[] guys = new Guy[3];  //player names 
        Greyhound[] dogs = new Greyhound[4]; // dogs aerry 
        Boolean win = false;
        int winner = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Race_Click(object sender, EventArgs e)
        {

            if (haveTheyBet())
            {
                timer1.Enabled = true;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Please Place Bet ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            guys[0] = new Guy("Akash", 50, thorlbl, akashradio);
            guys[1] = new Guy("Simran", 50, rocklbl, simranradio); // load form and give each player to 50 $ for start the game
            guys[2] = new Guy("Lovepreet", 50, linalbl, lovepreetradio);

            guys[0].UpdateLabels();
            guys[1].UpdateLabels();  // update the labels   
            guys[2].UpdateLabels();
            Random ran = new Random();  // random numbers
            dogs[0] = new Greyhound(Dog1, ran);
            dogs[1] = new Greyhound(Dog2, ran);
            dogs[2] = new Greyhound(Dog3, ran);
            dogs[3] = new Greyhound(Dog4, ran);
        }
        private bool haveTheyBet()
        {
            for (int i = 0; i < 3; i++)
            {
                if (guys[i].MyBet == null)
                {
                    return false;
                }
            }
            return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < 4 && win == false; i++)
            {
                win = dogs[i].Run();
                if (win)
                {
                    timer1.Stop();
                    timer1.Enabled = false;
                    winner = i;
                    int dnumber = winner + 1;
                    for (int j = 0; j < 3; j++)
                    {
                        guys[j].Collect(winner);
                        guys[j].ClearBet();
                        guys[j].UpdateLabels();

                    }
                    
                    MessageBox.Show("Dog " + dnumber + " has won the race!!");
                    break;
                }
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                dogs[i].TakeStartingPosition();
            }
            win = false;
        }

        private void betsButton_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 3; i++)
            {
                if (guys[i].MyRadioButton.Checked)
                {
                    guys[i].MyLabel.Text = guys[i].Name + " has bet " + betNumeric.Value;
                    int val1, val2;
                    val1 = Convert.ToInt16(betNumeric.Value);
                    val2 = Convert.ToInt16(dogNumberNumeric.Value);
                    guys[i].PlaceBet(val1, val2);
                }
            }

        }
    }
}
