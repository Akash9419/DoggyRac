using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoggyRace
{
    //coding is for racer factory
    public class RacerFactory
    {
        public Racer getRacer(String Name, Label MaximumBet, Label bet)
        {
            Racer p;
            switch (Name.ToLower())
            {
                case "akash":
                    p = new Akash(null, MaximumBet, 50, bet);
                    break;

                case "lovepreet":
                    p = new Lovepreet(null, MaximumBet, 50, bet);
                    break;

                case "simran":
                    p = new Simran(null, MaximumBet, 50, bet);
                    break;

                default:
                    p = null;
                    break;
            }
            p.setRacerName();
            return p;
        }
    }
}
