using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Player
    {
        // member variables (HAS A)
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Pitcher pitcher;
        public Recipe recipe;
        public string chargingPrice;

        // constructor (SPAWNER)
        public Player()
        {
            name = "Bumble Bee";
            inventory = new Inventory();
            wallet = new Wallet();
            pitcher = new Pitcher();
            recipe = new Recipe();
        }

        // member methods (CAN DO)
        public void MakeNewPitcher()
        {
            if (pitcher.numberOfCupsinPitcher == 0)
            {
                pitcher.MakePitcher();
            }
        }
        public void PopulateInventory()
        {
            inventory.numberOfCups = inventory.cups.Count();
            Console.WriteLine("Cups = " + inventory.numberOfCups);
            inventory.numberOfLemons = inventory.lemons.Count();
            Console.WriteLine("Lemons = " + inventory.numberOfLemons);
            inventory.numberOfSugarCubes = inventory.sugarCubes.Count();
            Console.WriteLine("Sugar cubes = " + inventory.numberOfSugarCubes);
            inventory.numberOfIceCubes = inventory.iceCubes.Count();
        }
        public void QualityControl()
        {
            Console.WriteLine("How much ice would you like to add per pitcher?");
            ChooseAmountOfIce(int.Parse(Console.ReadLine()));
            Console.WriteLine("How much lemon would you like to add per pitcher?");
            ChooseAmountOfLemon(int.Parse(Console.ReadLine()));
            Console.WriteLine("How much sugar would you like to add per pitcher?");
            ChooseAmountOfSugar(int.Parse(Console.ReadLine()));
            Console.WriteLine("How much are you charging per cup?");
            chargingPrice = Console.ReadLine();
            ChooseChargingPrice(Convert.ToDouble((chargingPrice)));
        }
        public void ChooseAmountOfLemon(int lemons)
        {
            recipe.amountOfLemons = lemons;
        }
        public void ChooseAmountOfIce(int iceCube)
        {
            recipe.amountOfIceCubes = iceCube;
        }
        public void ChooseAmountOfSugar(int sugar)
        {
            recipe.amountOfSugarCubes = sugar;
        }
        public void ChooseChargingPrice(double price)
        {
            recipe.pricePerCup = price;
        }
        
    }
}
