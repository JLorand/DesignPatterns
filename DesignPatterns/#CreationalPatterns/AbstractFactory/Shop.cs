using DesignPatterns.CreationalPatterns.AbstractFactory.After.Factories;
using DesignPatterns.CreationalPatterns.AbstractFactory.After.Types.Short;
using DesignPatterns.CreationalPatterns.AbstractFactory.After.Types.TShirt;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.After;

public class Shop
{
    private readonly IShort @short;
    private readonly ITshirt tShirt;

    public Shop(IClothesFactory clothesFactory)
    {
        this.@short = clothesFactory.CreateShort();
        this.tShirt = clothesFactory.CreateTshirt();
    }

    public void BuyProducts()
    {
        Console.WriteLine($"You just bought a pair of {@short.Details()}");
        Console.WriteLine($"You just bought a pair of {tShirt.Details()}");
    }
}