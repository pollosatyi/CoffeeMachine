using CoffeeMachine.Products;

namespace CoffeeMachine.Coffee;

public class BlackCoffee : Coffee
{
    private string _name = "Black Coffee";
    private CoffeeBeans _beans;
    private Water _water;
    private double _amountOfCoffee;

    public BlackCoffee(CoffeeBeans beans, Water water)
    {
        _beans = beans;
        _water = water;
    }

    public override void CreateCoffee()
    {
        _amountOfCoffee = _beans.AmountOfBeans*10.0+_water.AmountOfWater*90.0;
    }

    public override void PrintCoffee()
    {
        Console.WriteLine($"Кофе {_name} {_amountOfCoffee} мл готов");
    }
}
