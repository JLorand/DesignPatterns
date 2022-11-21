using DesignPatterns._CreationalPatterns.BuilderWithDirector.After.Houses;

namespace DesignPatterns._CreationalPatterns.BuilderWithDirector.After.Builder;

public interface ILuxuryHouseBuilder
{
    public IHouse Build();

    public void Reset();

    public ILuxuryHouseBuilder WithNumberOfDoors(int numberOfDoors = 1);

    public ILuxuryHouseBuilder WithNumberOfWindows(int numberOfWindows = 1);

    public ILuxuryHouseBuilder WithNumberOfRooms(int numberOfRooms = 1);

    public ILuxuryHouseBuilder WithSizeOfGarage(int carCapacity = 1);
    
    public ILuxuryHouseBuilder WithSizeOfGarden(int sizeOfGarden = 1);
    
    public ILuxuryHouseBuilder WithBalcony();
    
    public ILuxuryHouseBuilder WithPool();
    
    public ILuxuryHouseBuilder WithSauna();
}
