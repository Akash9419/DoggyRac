using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoggyRace
{
    public class Dogs
    {
        private static int StartingPosition;
        private static int RacetrackLength;
        public PictureBox DogsPictureBox = null;
        public int Location = 0;
        public static Random MyRandom = new Random(); //declared random object as static to avoid same random number

        public static int StartingPosition1 { get => StartingPosition; set => StartingPosition = value; }
        public static int RacetrackLength1 { get => RacetrackLength; set => RacetrackLength = value; }

        // generation across all Cars objects

        public static bool Run(Dogs obj)
        {
            int distance = MyRandom.Next(1, 3);
            if (obj.DogsPictureBox != null)
                obj.MoveDogsPictureBox(distance);

            obj.Location += distance;
            if (obj.Location >= (RacetrackLength1 - StartingPosition1))
            {
                return true;
            }
            return false;
        }

        public void TakeStartingPosition()
        {
            MoveDogsPictureBox(-Location); //reset location to -ve distance ie. to starting point
            Location = 0;

        }

        public void MoveDogsPictureBox(int distance)
        {
            Point p = DogsPictureBox.Location;
            p.X += distance;
            DogsPictureBox.Location = p; //move Cars in x-axis
        }
    }
}
