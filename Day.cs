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
        //constructor (spawner)
        public Day(string day)
        {
            customers = new List<Customer>();
            weather = new Weather();
            numberOfCustomers = 0;
        }
        //member methods (CAN DO)
        public void GenerateEachCustomer(Player player, Recipe recipe, Pitcher pitcher)
        {
            numberOfCustomers = GenerateRandomNumberOfCustomers();
            for (int i = 0; i < numberOfCustomers; i++)
            {
                customer = new Customer();
                customer.HowMuchLemonadeToBuy(player, weather, recipe, pitcher);
            }
        }
        public int GenerateRandomNumberOfCustomers()
        {
            int randomNumber = random.Next(80, 120);
            return randomNumber;
        }
        public void EndOfDayReport()
        {

        }
    }
}
