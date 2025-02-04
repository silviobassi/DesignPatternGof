namespace Pattern.Gof.AbstractFactory.Meals;

internal class StrawberryPie : IDessert
{
    void IDessert.DisplayInfo()
    {
        Console.WriteLine("🍓 Strawberry Pie");
    }
}