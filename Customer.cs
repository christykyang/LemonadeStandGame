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
            CustomerList(ListOfCustomers);
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
        public void HowMuchLemonadeToBuy(Player player, Weather weather, Recipe recipe, Pitcher pitcher)
        {
             if (weather.weatherCondition == weather.ListOfWeatherConditions[1] && weather.temperature >= 70 && recipe.pricePerCup <= 0.25)
            {
                amountOfLemonadeBuying = random.Next(4);
                BuyLemonade(player, recipe, pitcher);
            }
            else if (weather.weatherCondition == weather.ListOfWeatherConditions[2] && weather.temperature >= 70 && recipe.pricePerCup <= 0.25)
            {
                amountOfLemonadeBuying = random.Next(10);
                BuyLemonade(player, recipe, pitcher);
            }
            else if (weather.weatherCondition == weather.ListOfWeatherConditions[3] && weather.temperature >= 70 && recipe.pricePerCup <= 0.25)
            {
                amountOfLemonadeBuying = random.Next(7);
                BuyLemonade(player, recipe, pitcher);
            }
            else if (weather.weatherCondition == weather.ListOfWeatherConditions[4] && weather.temperature >= 70 && recipe.pricePerCup <= 0.25)
            {
                amountOfLemonadeBuying = random.Next(4);
                BuyLemonade(player, recipe, pitcher);
            }
            else if (recipe.pricePerCup <= 0.10)
            {
                amountOfLemonadeBuying = random.Next(10);
                BuyLemonade(player, recipe, pitcher);
            } 
            else 
            {
                amountOfLemonadeBuying = random.Next(2);
                BuyLemonade(player, recipe, pitcher);
            }
        }
        public void BuyLemonade(Player player, Recipe recipe, Pitcher pitcher)
        {
            bool index = random.Next(2) == 0;
            buyLemonade = index;
            pricePerCup = recipe.pricePerCup;
            if (buyLemonade == true && pitcher.numberOfCupsinPitcher <= 0)
            {
                player.MakeNewPitcher();
                player.pitcher.SoldCupOfLemonade();
                PayForLemonade(recipe);
                player.wallet.GetMoneyFromCustomer(pricePerCup);
            }
            else
            {
                player.pitcher.SoldCupOfLemonade();
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
