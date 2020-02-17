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
        public List<Customer> customers;
        //constructor (spawner)
        public Day()
        {
            
        }
        //member methods (CAN DO)
        public void NumberOfCustomersForWeather()
        {
            if (weather.temperature <= 60 && (weather.weatherCondition == weather.ListOfWeatherConditions[0])
            {
                
            }
        }
    }
}
