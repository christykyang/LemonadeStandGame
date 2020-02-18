using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Weather
    {
        //member variables (HAS A)
        public string weatherCondition;
        public int temperature;
        public List<string> ListOfWeatherConditions;
        Random random;
        //constructor (spawner)
        public Weather()
        {
            random = new Random();
            ListOfWeatherConditions = new List<string>();
            PopulateOfWeatherConditions(ListOfWeatherConditions);
        }

        //member methods (CAN DO)
        public void RandomWeatherGenerator()
        {
            int index = random.Next(ListOfWeatherConditions.Count);
            weatherCondition = ListOfWeatherConditions[index];
            Console.WriteLine("Today is " + weatherCondition);
        }
        public void RandomTemperatureGenerator()
        {   
            int index = random.Next(50, 95);
            temperature = index;
            Console.WriteLine("with a temperature of " + temperature);
        }
        public void PopulateOfWeatherConditions(List<string> condition)
        {
            condition.Add("rainy");
            condition.Add("windy");
            condition.Add("sunny");
            condition.Add("humid");
            condition.Add("cloudy");
        }
    }
}
