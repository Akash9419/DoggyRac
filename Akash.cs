using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyRace
{
    using System;
    using System.Windows.Forms;

    public class Akash : Racer
    {
        public Akash(Bet MyBet, Label MaximumBet, int Cash, Label MyLabel) : base(MyBet, MaximumBet, Cash, MyLabel)
        {
        }

        public override void setRacerName()
        {
            Name = "Akash";
        }
    }
}
