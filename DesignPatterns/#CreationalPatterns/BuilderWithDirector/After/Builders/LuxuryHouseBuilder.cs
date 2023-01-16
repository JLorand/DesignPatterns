using DesignPatterns._CreationalPatterns.BuilderWithDirector.After.Houses;

namespace DesignPatterns._CreationalPatterns.BuilderWithDirector.After.Builders;


public class LuxuryHouseBuilder : ILuxuryHouseBuilder
{
    private LuxuryHouse _house;
    
    public LuxuryHouseBuilder()
    {
        this.Reset();
    }
    
    public IHouse Build()
    {
        return this._house;
    }

    public void Reset()
    {
        this._house = new LuxuryHouse();
    }

    public ILuxuryHouseBuilder WithNumberOfDoors(int numberOfDoors = 1)
    {
        this._house.NumberOfDoors = numberOfDoors;
        return this;
    }
    
    public ILuxuryHouseBuilder WithNumberOfWindows(int numberOfWindows = 1)
    {
        this._house.NumberOfWindows = numberOfWindows;
        return this;
    }
    
    public ILuxuryHouseBuilder WithNumberOfRooms(int numberOfRooms = 1)
    {
        this._house.NumberOfRooms = numberOfRooms;
        return this;
    }
    
    public ILuxuryHouseBuilder WithSizeOfGarage(int carCapacity = 1)
    {
        this._house.CarCapacity = carCapacity;
        return this;
    }
    
    public ILuxuryHouseBuilder WithSizeOfGarden(int sizeOfGarden = 1)
    {
        this._house.SizeOfGarden = sizeOfGarden;
        return this;
    }
    
    public ILuxuryHouseBuilder WithBalcony()
    {
        this._house.HasBalcony = true;
        return this;
    }
    
    public ILuxuryHouseBuilder WithPool()
    {
        this._house.HasPool = true;
        return this;
    }
    
    public ILuxuryHouseBuilder WithSauna()
    {
        this._house.HasSauna = true;
        return this;
    }
}
