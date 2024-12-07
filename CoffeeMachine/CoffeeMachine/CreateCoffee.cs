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
        
        switch (_numberOfCoffee)
        {
            case 1:
                CoffeeBeans coffeeBeans = new CoffeeBeans();
                Water water = new Water();
                _coffee = new Coffee.BlackCoffee(coffeeBeans,water); 
                MakingCoffee();
                break;
        }
    }

    private void MakingCoffee()
    {
        _coffee.CreateCoffee();
        _coffee.PrintCoffee();
        
    }
}