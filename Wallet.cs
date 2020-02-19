using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Wallet
    {
        private double money;

        // property - TBD
        public double Money
        {
            get
            {
                return money;
            }
        }

        public Wallet()
        {
            money = 20.00;
        }

        public void PayMoneyForItems(double transactionAmount)
        {
            money -= transactionAmount;
            string value = money.ToString();
            Console.WriteLine("You currently have " + value + " in your wallet.");
        }
        public void GetMoneyFromCustomer(double lemonadePrice)
        {
            money += lemonadePrice;

        }
        public void DisplayHowMuchInWallet()
        {
            Console.WriteLine("You have " + money + " in you wallet.");
        }
    }
}
