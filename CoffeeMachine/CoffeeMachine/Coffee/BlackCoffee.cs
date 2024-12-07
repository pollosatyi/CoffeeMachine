using CoffeeMachine.Products;

namespace CoffeeMachine.Coffee;

public class BlackCoffee : Coffee
{
    private string name = "Black Coffee";
    private CoffeeBeans _beans;

    public BlackCoffee(CoffeeBeans beans)
    {
        _beans = beans;
    }

    public override Coffee CreateCoffee()
    {
        throw new NotImplementedException();
    }
}
