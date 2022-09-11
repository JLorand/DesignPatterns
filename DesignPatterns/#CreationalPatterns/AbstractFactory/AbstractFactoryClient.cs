using DesignPatterns.CreationalPatterns.AbstractFactory.After.Factories;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.After;

public class AbstractFactoryClient
{
    public static void ExecutePattern()
    {
        Console.WriteLine("Buying clothes from Nike shop");
        NikeClothesFactory nikeClothesFactory = new NikeClothesFactory();
        Shop nikeShop = new Shop(nikeClothesFactory);
        nikeShop.BuyProducts();

        Console.WriteLine("Buying clothes from Noname shop");
        NonameClothesFactory nonameClothesFactory = new NonameClothesFactory();
        Shop nonameShop = new Shop(nonameClothesFactory);
        nonameShop.BuyProducts();
    }
}