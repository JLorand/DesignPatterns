using DesignPatterns.CreationalPatterns.AbstractFactory.After.Types.Short;
using DesignPatterns.CreationalPatterns.AbstractFactory.After.Types.TShirt;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.After.Factories;

public interface IClothesFactory
{
    ITshirt CreateTshirt();
    IShort CreateShort();
}