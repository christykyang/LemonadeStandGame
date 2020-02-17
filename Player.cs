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
            if (pitcher.numberOfCupsinPitcher == 1)
            {
                pitcher = new Pitcher();
            }
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
        public void BuyFromStore()
        {

        }
    }
}
