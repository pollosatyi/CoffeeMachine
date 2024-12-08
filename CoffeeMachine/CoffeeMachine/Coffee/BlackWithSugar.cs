using CoffeeMachine.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoffeeMachine.Coffee
{
    public class BlackWithSugar : Coffee
    {
        private string _name = "BlackWithSugar";
        private CoffeeBeans _beans;
        private Water _water;
        private Sugar _sugar;
        private double _amountOfCoffee;


        public BlackWithSugar(CoffeeBeans coffeeBeans, Water water, Sugar sugar)
        {
            _beans = coffeeBeans;
            _water = water;
            _sugar = sugar;
        }

        public override void CreateCoffee()
        {
            _amountOfCoffee = _beans.AmountOfBeans * 10 + _water.AmountOfWater * 88 + _sugar.AmountOfSugar * 2;
        }

        public override void PrintCoffee()
        {
            Console.WriteLine($"Кофе {_name} {_amountOfCoffee} мл готов");
        }
    }
}
