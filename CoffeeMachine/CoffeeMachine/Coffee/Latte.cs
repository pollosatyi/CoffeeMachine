using CoffeeMachine.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Coffee
{
    public class Latte : Coffee
    {
        private string _name="Latte";
        private double _amountOfCoffee;
        private CoffeeBeans _coffeeBeans;
        private Milk _milk;
        private Water _water;
        private Sugar _sugar;


        public Latte(CoffeeBeans coffeeBeans ,Milk milk, Water water, Sugar sugar)
        {
            _milk = milk;
            _water = water;
            _sugar = sugar;
            _coffeeBeans = coffeeBeans;
        }
        public override void CreateCoffee()
        {
            _amountOfCoffee = _coffeeBeans.AmountOfBeans * 10 + _milk.AmountOfMilk * 60 + _water.AmountOfWater * 28 + _sugar.AmountOfSugar * 2;
        }

        public override void PrintCoffee()
        {
            Console.WriteLine($"Кофе {_name} {_amountOfCoffee} мл готов");
        }
    }
}
