using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoggyRace
{
    public class Guy
    {
        public string Name;   // name of player 
        public Bet MyBet; // bets placed by player 
        public int Cash;
        public RadioButton MyRadioButton; // radio button
        public Label MyLabel;
        public Guy(string name, int Cash, Label MyLabel, RadioButton guyButton)
        {
            Name = name;
            this.Cash = Cash;
            this.MyLabel = MyLabel;
            MyRadioButton = guyButton;
            MyBet = null;

        }
        public void UpdateLabels() // update lebels 
        {
            MyRadioButton.Text = Name + " has " + Cash + " bucks!";
            if (MyBet == null)
            {
                MyLabel.Text = Name;
            }
            else
            {
                MyLabel.Text = Name + " has bet " + MyBet.Amount + " bucks on dog number " + MyBet.Dog;
            }


        }

        public void ClearBet()
        {
            MyBet = null;
        }

        public bool PlaceBet(int Amount, int Dog) // place bet on dog 
        {
            MyBet = new Bet(Amount, Dog, this);
            UpdateLabels();
            return false;
        }

        public void Collect(int Winner) // winner 
        {
            Cash += MyBet.PayOut(Winner);
        }


    }
}
