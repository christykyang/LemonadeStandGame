﻿using System;
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
        public int numberOfItems;
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
            if (pitcher.numberOfCupsinPitcher == 0)
            {
                pitcher = new Pitcher();
            }
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
            ChooseChargingPrice(int.Parse(Console.ReadLine()));
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
