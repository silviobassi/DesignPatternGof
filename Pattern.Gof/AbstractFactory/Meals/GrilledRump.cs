namespace Pattern.Gof.AbstractFactory.Meals;

internal class GrilledRump : IMainDish
{
    void IMainDish.DisplayInfo()
    {
        Console.WriteLine("🥩 Grilled Rump");
    }
}