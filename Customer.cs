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
        public List<string> customers;
        //constructor (spawner)
        public Customer()
        {
            howMuchMoney = 20;
            random = new Random();
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
        public void RandomCustomerGenerator(Random random)
        {
            CustomerList(customers);
            //random = new Random();
            int index = random.Next(customers.Count);
            name = customers[index];
            Console.WriteLine(name);
        }
        public void HowMuchLemonadeToBuy(Player player, Weather weather, Recipe recipe, Pitcher pitcher)
        {
            //random = new Random();
             if (weather.weatherCondition == weather.ListOfWeatherConditions[1])
            {
                if (weather.temperature >= 70)
                {
                    if (recipe.pricePerCup <= 0.10)
                    {
                        if (recipe.amountOfLemons >= 3)
                        {
                            amountOfLemonadeBuying = random.Next(3);
                            BuyLemonade(player, recipe, pitcher);
                        }
                    }
                }
            }
            else if (weather.weatherCondition == weather.ListOfWeatherConditions[2])
            {
                if (weather.temperature >= 60)
                {
                    if (recipe.pricePerCup <= 0.20)
                    {
                        if (recipe.amountOfLemons >= 3)
                        {
                            amountOfLemonadeBuying = random.Next(5);
                            BuyLemonade(player, recipe, pitcher);
                        }
                    }
                }
            }
            else if (weather.weatherCondition == weather.ListOfWeatherConditions[3])
            {
                if (weather.temperature >= 65)
                {
                    if (recipe.pricePerCup <= 0.15)
                    {
                        if (recipe.amountOfLemons >= 3)
                        {
                            amountOfLemonadeBuying = random.Next(4);
                            BuyLemonade(player, recipe, pitcher);
                        }
                    }
                }
            }
            else if (weather.weatherCondition == weather.ListOfWeatherConditions[4] && weather.temperature >= 70 && recipe.pricePerCup <= 0.15 && recipe.amountOfLemons >= 5 && recipe.amountOfSugarCubes >= 5)
            {
                if (weather.temperature >= 80)
                {
                    if (recipe.pricePerCup <= 0.25)
                    {
                        if (recipe.amountOfLemons >= 5)
                        {
                            amountOfLemonadeBuying = random.Next(5);
                            BuyLemonade(player, recipe, pitcher);
                        }
                    }
                }
            }
            else if (recipe.pricePerCup <= 0.10)
            {
                amountOfLemonadeBuying = random.Next(3);
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
