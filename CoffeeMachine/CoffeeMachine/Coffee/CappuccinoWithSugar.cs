using CoffeeMachine.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Coffee
{
    public class CappuccinoWithSugar : Coffee
    {
        private string _name = "CappuccinoWithSugar";
        private double _amountOfCoffee;
        private CoffeeBeans _coffeeBeans;
        private Milk _milk;
        private Sugar _sugar;
        private Water _water;

        public CappuccinoWithSugar(CoffeeBeans coffeeBeans, Milk milk, Sugar sugar, Water water)
        {
            _coffeeBeans = coffeeBeans;
            _milk = milk;
            _sugar = sugar;
            _water = water;
        }

        public override void CreateCoffee()
        {
            _amountOfCoffee = _coffeeBeans.AmountOfBeans * 10 + _milk.AmountOfMilk * 30 + _water.AmountOfWater * 58 + _sugar.AmountOfSugar*2;
        }

        public override void PrintCoffee()
        {
            Console.WriteLine($"Кофе {_name} {_amountOfCoffee} мл готов");
        }
    }
}
