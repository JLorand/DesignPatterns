using DesignPatterns.CreationalPatterns.AbstractFactory.After.Types.Short;
using DesignPatterns.CreationalPatterns.AbstractFactory.After.Types.TShirt;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.After.Factories;

public class NonameClothesFactory : IClothesFactory
{
    public IShort CreateShort()
    {
        return new NonameShort();
    }

    public ITshirt CreateTshirt()
    {
        return new NonameTShirt();
    }
}