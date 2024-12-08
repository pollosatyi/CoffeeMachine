namespace CoffeeMachine;

public class MenuCoffeeMachine
{
    public static void Menu()
    {
        while (true)
        {
            Print();
            bool IsNumber=int.TryParse(Console.ReadLine(), out int numberOfCoffee);
            if (!IsNumber)
            {
                Console.WriteLine("Этот не число");
                continue;
            }

            if (numberOfCoffee == 0){Console.WriteLine("Выход из программы"); break;}
            if (numberOfCoffee < 0 || numberOfCoffee > 5)
            {
                Console.WriteLine("Такой команды нет");
                continue;
            }
            CreateCoffee createCoffee=new CreateCoffee(numberOfCoffee);
            createCoffee.ChooseCreateCoffee();
        }
        
    }

    private static void Print()
    {
        Console.WriteLine("Кофемашина готова для работы");
        Console.WriteLine(
            "Нажмите 0 для выхода\n" +
            "1 - для приготовления черного кофе\n" +
            "2 - черного кофе с сахаром\n" +
            "3 - капучино\n" +
            "4 - капучино с сахаром\n" +
            "5 - латте");
    }
}