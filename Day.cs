using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {
        //member variables (HAS A)
        public Weather weather;
        public int numberOfCustomers;
        Customer customer;
        public List<Customer> customers;
        Random random;
        public int numberOfCupsSold;
        //constructor (spawner)
        public Day(string day)
        {
            customers = new List<Customer>();
            weather = new Weather();
            numberOfCustomers = 0;
            numberOfCupsSold = 0;
            //GenerateRandomNumberOfCustomers();
            //GenerateEachCustomer(player, recipe, pitcher);
            //EndOfDayReport(player);
        }
        //member methods (CAN DO)
        public void GenerateEachCustomer(Player player, Recipe recipe, Pitcher pitcher)
        {
            numberOfCustomers = GenerateRandomNumberOfCustomers();
            for (int i = 0; i < numberOfCustomers; i++)
            {
                customer = new Customer();
                //customer.RandomCustomerGenerator(random);
                customer.HowMuchLemonadeToBuy(player, weather, recipe, pitcher);
                pitcher.SoldCupOfLemonade(customer);
            }
        }
        public int GenerateRandomNumberOfCustomers()
        {
            random = new Random();
            int randomNumber = random.Next(80, 120);
            return randomNumber;
        }
        public void EndOfDayReport(Player player)
        {
            player.PopulateInventory();
            player.wallet.DisplayHowMuchInWallet();
            DisplayHowManyCupsSold(player);
        }
        public void DisplayHowManyCupsSold(Player player)
        {
            Console.WriteLine("You sold " + player.pitcher.numberOfCupsSold + " cups of lemonade");
            Console.WriteLine("to " + numberOfCustomers + " potential customers.");
            Console.ReadLine();
        }
    }
}
