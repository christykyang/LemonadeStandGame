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
        Weather weather;
        public int numberOfCustomers;
        Customer customer;
        public List<Customer> customers;
        Random random;
        //constructor (spawner)
        public Day()
        {
            customers = new List<Customer>();
            numberOfCustomers = GenerateRandomNumberOfCustomers();
        }
        //member methods (CAN DO)
        //public void GenerateCustomers()
        //{

        //}
        public int GenerateRandomNumberOfCustomers()
        {
            int index = random.Next(4, 120);
            numberOfCustomers = index;
            return numberOfCustomers;
        }
    }
}
