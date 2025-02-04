using Pattern.Gof.AbstractFactory.Meals;

namespace Pattern.Gof.AbstractFactory;

public class ClientAbstractFactory(IRestaurantFactory restaurantFactory)
{
    private readonly IMainDish _mainDish = restaurantFactory.CreateMainDish();
    private readonly IDessert _dessert = restaurantFactory.CreateDessert();

    public void DisplayMeal()
    {
        _mainDish.DisplayInfo();
        _dessert.DisplayInfo();
    }
}