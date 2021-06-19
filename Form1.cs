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
        Dogs[] Dogss = new Dogs[4];

        RacerFactory pFactory = new RacerFactory();
        Racer[] Racers = new Racer[3];
        public Form1()
        {
            InitializeComponent();
            SetupRaceTrack();
        }

        private void SetupRaceTrack()
        {

            Dogs.StartingPosition1 = Dog1.Right - racetrack.Left;
            Dogs.RacetrackLength1 = racetrack.Size.Width - 40; //fixing length of race - till finish line

            Dogss[0] = new Dogs() { DogsPictureBox = Dog1 };
            Dogss[1] = new Dogs() { DogsPictureBox = Dog2 };
            Dogss[2] = new Dogs() { DogsPictureBox = Dog3 };
            Dogss[3] = new Dogs() { DogsPictureBox = Dog4 };

            Racers[0] = pFactory.getRacer("Akash", MinimumBetLabel, Akashbet); //getting Jhon object from factory class
            Racers[1] = pFactory.getRacer("Lovepreet", MinimumBetLabel, Lovepreetbet); //getting Mark object from factory class
            Racers[2] = pFactory.getRacer("Simran", MinimumBetLabel, Simranbet); //getting Lim object from factory class


            foreach (Racer Racer in Racers)
            {
                Racer.UpdateLabels();
            }
        }
        private void setMaximumBetTextLabel(int Cash)
        {
            MinimumBetLabel.Text = String.Format("Maximum Bet: ${0}", Cash);
        }


        private void Race_Click(object sender, EventArgs e)
        {
            bool NoWinner = true;
            int winningDogs;
            Race.Enabled = false; //disable start race button

            while (NoWinner)
            { // loop until we have a winner
                Application.DoEvents();
                for (int i = 0; i < Dogss.Length; i++)
                {
                    if (Dogs.Run(Dogss[i]))
                    {
                        winningDogs = i + 1;
                        NoWinner = false;
                        MessageBox.Show("winner of the race is - Dogs #" + winningDogs);
                        foreach (Racer Racer in Racers)
                        {
                            if (Racer.bet != null)
                            {
                                Racer.Collect(winningDogs); //give double amount to all who've won or deduce betted amount
                                Racer.bet = null;
                                Racer.UpdateLabels();
                            }
                        }
                        foreach (Dogs Dogs in Dogss)
                        {
                            Dogs.TakeStartingPosition();
                        }
                        break;
                    }
                }
            }
            if (Racers[0].busted && Racers[1].busted && Racers[2].busted)
            {  //stop Racers from betting if they run out of cash
                String message = "Do you want to Play Again?";
                String title = "GAME OVER!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    SetupRaceTrack(); //restart game
                }
                else
                {
                    this.Close();
                }

            }
            Race.Enabled = true; //enable race button 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
      

       

        
        private void betsButton_Click(object sender, EventArgs e)
        {
            int RacerNum = 0;

            if (akashradio.Checked)
            {
                RacerNum = 0;
            }
            if (lovepreetradio.Checked)
            {
                RacerNum = 1;
            }
            if (simranradio.Checked)
            {
                RacerNum = 2;
            }

            Racers[RacerNum].PlaceBet((int)betNumeric.Value, (int)dogNumberNumeric.Value);
            Racers[RacerNum].UpdateLabels();

        }

        private void akashradio_CheckedChanged(object sender, EventArgs e)
        {
            setMaximumBetTextLabel(Racers[0].Cash);
        }

      

        private void lovepreetradio_CheckedChanged(object sender, EventArgs e)
        {
            setMaximumBetTextLabel(Racers[1].Cash);
        }
        private void simranradio_CheckedChanged(object sender, EventArgs e)
        {
            setMaximumBetTextLabel(Racers[2].Cash);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
