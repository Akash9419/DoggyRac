using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyRace
{
    using System;
    using System.Windows.Forms;

    public class Lovepreet : Racer
    {
        public Lovepreet(Bet bet, Label MaximumBet, int Cash, Label label) : base(bet, MaximumBet, Cash, label)
        {
        }

        public override void setRacerName()
        {
            Name = "Lovepreet";
        }
    }
}
