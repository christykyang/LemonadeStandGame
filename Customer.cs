using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Customer
    {
        //member variable (What does this have?)
        Random random;
        public bool buyLemonade;
        public int amountOfLemonadeBuying;
        public double pricePerCup;
        public double howMuchMoney;
        public string name;
        public List<string> ListOfCustomers;
        //constructor (spawner)
        public Customer()
        {
            howMuchMoney = 20;
            RandomCustomerGenerator();
        }

        //member methods (what can this do?)
        public void CustomerList(List<string> customers)
        {
            customers = new List<string>();
            customers.Add("Aladdin");
            customers.Add("Jasmine");
            customers.Add("Abu");
            customers.Add("Genie");
            customers.Add("Rajah");
            customers.Add("Jafar");
        }
        public void RandomCustomerGenerator()
        {
            int index = random.Next(ListOfCustomers.Count);
            name = ListOfCustomers[index];
            Console.WriteLine(name);
        }
        public void HowMuchLemonadeToBuy(Player player, Weather weather, Recipe recipe)
        {
             if (weather.weatherCondition == weather.ListOfWeatherConditions[1] && weather.temperature >= 70)
            {
                amountOfLemonadeBuying = random.Next(4);
                BuyLemonade(player, recipe);
            }
            else if (weather.weatherCondition == weather.ListOfWeatherConditions[2] && weather.temperature >= 70)
            {
                amountOfLemonadeBuying = random.Next(10);
                BuyLemonade(player, recipe);
            }
            else if (weather.weatherCondition == weather.ListOfWeatherConditions[3] && weather.temperature >= 70)
            {
                amountOfLemonadeBuying = random.Next(7);
                BuyLemonade(player, recipe);
            }
            else if (weather.weatherCondition == weather.ListOfWeatherConditions[4] && weather.temperature >= 70)
            {
                amountOfLemonadeBuying = random.Next(4);
                BuyLemonade(player, recipe);
            }
            else 
            {
                amountOfLemonadeBuying = random.Next(2);
                BuyLemonade(player, recipe);
            }
        }
        public void BuyLemonade(Player player, Recipe recipe)
        {
            bool index = random.Next(2) == 0;
            buyLemonade = index;
            pricePerCup = recipe.pricePerCup;
            if (buyLemonade == true)
            {
                PayForLemonade(recipe);
                player.wallet.GetMoneyFromCustomer(pricePerCup);
            }
        }
        public void PayForLemonade (Recipe recipe)
        {
            howMuchMoney -= recipe.pricePerCup;
        }
    }
}
