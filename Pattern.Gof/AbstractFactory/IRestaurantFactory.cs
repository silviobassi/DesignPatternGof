using Pattern.Gof.AbstractFactory.Meals;

namespace Pattern.Gof.AbstractFactory;

public interface IRestaurantFactory
{
    IMainDish CreateMainDish();
    IDessert CreateDessert();
}