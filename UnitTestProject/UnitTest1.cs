using DoggyRace;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        RacerFactory pFactory = new RacerFactory();
        Racer Simran;
        Dogs[] Dogss = new Dogs[2];
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void TestWinnerOutcome()
        {
            Dogs.StartingPosition1 = 0;
            Dogs.RacetrackLength1 = 50;
            int DogRaceAmount = 45;
            int DogsNumber = 2;
            int expectedWin = 90;
            int expectedLose = 0;
            Dogss[0] = new Dogs() { DogsPictureBox = null };
            Dogss[1] = new Dogs() { DogsPictureBox = null };
            Simran = pFactory.getRacer("Simran", null, null);
            Simran.Cash = DogRaceAmount;
            Simran.PlaceBet((int)DogRaceAmount, DogsNumber);

            bool nowin = true;
            int win = -1;
            while (nowin)
            {
                for (int i = 0; i < Dogss.Length; i++)
                {
                    if (Dogs.Run(Dogss[i]))
                    {
                        win = i + 1;
                        Simran.Collect(win);
                        nowin = false;

                    }
                }
            }
            if (Simran.bet.DogNum == win)
            {
                Assert.AreEqual(expectedWin, Simran.Cash, "Account not credited correctly");
            }
            if (Simran.bet.DogNum != win)
            {
                Assert.AreEqual(expectedLose, Simran.Cash, "Account not debited correctly");

            }
        }
    }

}
