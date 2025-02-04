namespace Pattern.Gof.AbstractFactory.Meals;

internal class Sushi : IMainDish
{
    void IMainDish.DisplayInfo()
    {
        Console.WriteLine("🍣 Sushi");
    }
}