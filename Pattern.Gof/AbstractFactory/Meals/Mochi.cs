namespace Pattern.Gof.AbstractFactory.Meals;

internal class Mochi : IDessert
{
    void IDessert.DisplayInfo()
    {
        Console.WriteLine("🍡 Mochi");
    }
}