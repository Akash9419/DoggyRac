using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoggyRace
{
    public class Greyhound
    {
        public int StartingPosition = 20;   // starting postion
        public int RacetrackLength = 650; // race track length
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random ran;

        public Greyhound(PictureBox picture, Random r)
        {
            MyPictureBox = picture;
            this.ran = r;
        }

        public bool Run() // run dogs randomly 
        {
            int step = ran.Next(5) + 2;
            Point p = MyPictureBox.Location;
            p.X += step;
            MyPictureBox.Location = p;
            if (p.X >= RacetrackLength)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void TakeStartingPosition() // starting position of dogs 
        {
            Point p = MyPictureBox.Location;
            p.X = StartingPosition;
            MyPictureBox.Location = p;
        }
    }
}
