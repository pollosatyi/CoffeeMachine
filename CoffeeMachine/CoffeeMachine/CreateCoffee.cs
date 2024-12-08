using CoffeeMachine.Coffee;
using CoffeeMachine.Products;

namespace CoffeeMachine;

public class CreateCoffee
{
    private int _numberOfCoffee;
    private Coffee.Coffee _coffee;

    public CreateCoffee(int numberOfCoffee)
    {
        _numberOfCoffee = numberOfCoffee;
    }

    public void ChooseCreateCoffee()
    {
        CoffeeBeans coffeeBeans = new CoffeeBeans();
        Water water = new Water();

        switch (_numberOfCoffee)
        {

            case 1:
                {
                    _coffee = new Coffee.BlackCoffee(coffeeBeans, water);
                    break;
                }
            case 2:
                {
                    Sugar sugar = new Sugar();
                    _coffee = new Coffee.BlackWithSugar(coffeeBeans, water, sugar);
                    break;
                }
            case 3:
                {
                    Milk milk = new Milk();
                    _coffee = new Coffee.Cappuccino(coffeeBeans, milk, water);
                    break;
                }
            case 4:
                {
                    Milk milk = new Milk();
                    Sugar sugar = new Sugar();
                    _coffee = new Coffee.CappuccinoWithSugar(coffeeBeans, milk, sugar, water);
                    break;
                }
            case 5:
                {
                    Milk milk = new Milk();
                    Sugar sugar = new Sugar();
                    _coffee = new Coffee.Latte(coffeeBeans,milk,water, sugar);
                    break;
                }
        }
        MakingCoffee();
    }

    private void MakingCoffee()
    {
        _coffee.CreateCoffee();
        _coffee.PrintCoffee();

    }
}