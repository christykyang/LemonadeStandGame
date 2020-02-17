using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Pitcher
    {
        //member variables (What does a pitcher have?)
        public int numberOfCupsinPitcher;

        //constructor (how the pitcher is made)
        public Pitcher()
        {
            numberOfCupsinPitcher = 4;
        }
        //member methods (what can the pitcher do?)
        public void SoldCupOfLemonade()
        {
            numberOfCupsinPitcher -= 1;
        }
    }
}
