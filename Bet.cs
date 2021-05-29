using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyRace
{
    public class Bet
    {
        public int Amount; // betting amount
        public int Dog;
        public Guy Bettor;

        public Bet(int Amount, int Dog, Guy which)
        {
            this.Amount = Amount;
            this.Dog = Dog;
            Bettor = which;
        }

        public string GetDescription() // messgae box 
        {
            return "";
        }

        public int PayOut(int Winner)
        {
            if (Dog == Winner)
            {
                return 2 * Amount;
            }
            else
            {
                return -Amount;
            }
        }



    }
}
