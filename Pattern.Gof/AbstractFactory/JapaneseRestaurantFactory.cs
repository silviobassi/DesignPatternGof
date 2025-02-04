using Pattern.Gof.AbstractFactory.Meals;

namespace Pattern.Gof.AbstractFactory;

public class JapaneseRestaurantFactory : IRestaurantFactory
{
    public IMainDish CreateMainDish()
    {
        return new Sushi();
    }

    public IDessert CreateDessert()
    {
        return new Mochi();
    }
}