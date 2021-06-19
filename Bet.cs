using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyRace
{
    // this coding is for bet class
    public class Bet
    {
        public int Amount;
        public int DogNum;
        public Racer Bettor;

        public Bet(int Amount, int DogNum, Racer Bettor)
        {
            this.Amount = Amount;
            this.DogNum = DogNum;
            this.Bettor = Bettor;
        }
        // this coding is for description
        public string GetDescription()
        {
            string description = "";

            if (Amount > 0)
            {
                description = String.Format("{0} bets {1} on Dog #{2}",
                    Bettor.Name, Amount, DogNum);
            }
            else
            {
                description = String.Format("{0} hasn't placed any bets",
                    Bettor.Name);
            }
            return description;
        }
        //this coding is for winner class

        public int Pay(int Winner)
        {
            if (DogNum == Winner)
            {
                return Amount;
            }
            return -Amount;
        }
    }
}
