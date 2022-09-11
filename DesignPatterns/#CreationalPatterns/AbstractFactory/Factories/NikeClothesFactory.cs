using DesignPatterns.CreationalPatterns.AbstractFactory.After.Types.Short;
using DesignPatterns.CreationalPatterns.AbstractFactory.After.Types.TShirt;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.After.Factories;

public class NikeClothesFactory : IClothesFactory
{
    public IShort CreateShort()
    {
        return new NikeShort();
    }

    public ITshirt CreateTshirt()
    {
        return new NikeTShirt();
    }
}