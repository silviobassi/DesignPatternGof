using Pattern.Gof.AbstractFactory.Meals;

namespace Pattern.Gof.AbstractFactory;

public class BrazilianRestaurantFactory : IRestaurantFactory
{
    public IMainDish CreateMainDish()
    {
        return new GrilledRump();
    }

    public IDessert CreateDessert()
    {
        return new StrawberryPie();
    }
}