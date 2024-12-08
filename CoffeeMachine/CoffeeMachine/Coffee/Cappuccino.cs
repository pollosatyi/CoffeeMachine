using CoffeeMachine.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Coffee
{
    public class Cappuccino : Coffee
    {
        private string _name="Cappuccino";
        private CoffeeBeans _coffeeBeans;
        private Milk _milk;
        private Water _water;
        private double _amountOfCoffee;


        public Cappuccino(CoffeeBeans coffeeBeans,Milk milk, Water water)
        {
            _coffeeBeans = coffeeBeans;
            _milk = milk;
            _water = water;
        }

        public override void CreateCoffee()
        {
            _amountOfCoffee = _coffeeBeans.AmountOfBeans * 10 + _milk.AmountOfMilk * 30 + _water.AmountOfWater * 60;
        }

        public override void PrintCoffee()
        {
            Console.WriteLine($"Кофе {_name} {_amountOfCoffee} мл готов");
        }
    }
}
