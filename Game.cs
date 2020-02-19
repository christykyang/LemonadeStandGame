using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game
    {
        //member variables (HAS A)
        Player player;
        Recipe recipe;
        Store store;
        Inventory inventory;
        Weather weather;
        Pitcher pitcher;
        public List<Day> days;
        public int currentDay;
        public string lengthOfGame;
        //constructors

        //member methods (CAN DO)
        public Game()
        {
            player = new Player();
            recipe = new Recipe();
            store = new Store();
            inventory = new Inventory();
            weather = new Weather();
            pitcher = new Pitcher();
            days = new List<Day>() { new Day("Sunday"), new Day("Monday"), new Day("Tuesday"), new Day("Wednesday"), new Day("Thursday"), new Day("Friday"), new Day("Saturday") };
            currentDay = 0;
            Console.WriteLine("The goal of the game is to make as much money as possible at the end of the work period. You will have complete control over how your business is ran. You will have to create a recipe at the beginning of the day. Keep in mind that your recipe should support your inventory to make it through the day. The next thing you will have to worry about s the weather which will play a part in if your customers will decide to buy from you.");
            Console.WriteLine("How long would you like to play?");
            ChooseLengthOfGame();
        }
        public void ChooseLengthOfGame()
        {
            lengthOfGame = (Console.ReadLine());
            if (lengthOfGame == "7 days")
            {
                OneWeek();
            }
        }
        public void OneWeek()
        {
            for (int i = 0; i < days.Count; i++)
            {
                currentDay = i;
                Console.WriteLine("Today is " + currentDay);
                weather.RandomWeatherGenerator();
                weather.RandomTemperatureGenerator();
                RunGame(currentDay);
            }
            
        }
        public void RunGame(int day)
        {
           //inventory.PopulateInventory();
            BuyFromStore();
            player.PopulateInventory();
            player.QualityControl();
            player.PopulateInventory();
            days[day].GenerateRandomNumberOfCustomers();
            days[day].GenerateEachCustomer(player, recipe, pitcher);
            days[day].EndOfDayReport(player); 
        }
        public void GoToStore()
        {
            //figure out how the store works... 
            Console.WriteLine("Would you like to visit the store?");
        }
        public void BuyFromStore()
        {
            Console.WriteLine("Lemons are 50 cents each.");
            store.SellLemons(player);
            Console.WriteLine("Sugar are 10 cents each.");
            store.SellSugarCubes(player);
            Console.WriteLine("Cups are 25 cents each.");
            store.SellCups(player);
            Console.WriteLine("Ice cubes are 1 cent each.");
            store.SellIceCubes(player);
        }
    }
}
