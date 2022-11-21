using DesignPatterns._CreationalPatterns.Builder.After.Houses;

namespace DesignPatterns._CreationalPatterns.Builder.After.Builders;


public class HouseBuilder
{
    private House _house;
    
    public HouseBuilder()
    {
        this.Reset();
    }
    
    public House Build()
    {
        return this._house;
    }

    public void Reset()
    {
        this._house = new House();
    }

    public HouseBuilder WithSizeOfGarage(int carCapacity = 1)
    {
        this._house.CarCapacity = carCapacity;
        return this;
    }
    
    public HouseBuilder WithSizeOfGarden(int sizeOfGarden = 1)
    {
        this._house.SizeOfGarden = sizeOfGarden;
        return this;
    }
    
    public HouseBuilder WithNumberOfDoors(int numberOfDoors = 1)
    {
        this._house.NumberOfDoors = numberOfDoors;
        return this;
    }
    
    public HouseBuilder WithNumberOfWindows(int numberOfWindows = 1)
    {
        this._house.NumberOfWindows = numberOfWindows;
        return this;
    }
    
    public HouseBuilder WithNumberOfRooms(int numberOfRooms = 1)
    {
        this._house.NumberOfRooms = numberOfRooms;
        return this;
    }
    
    public HouseBuilder WithBalcony()
    {
        this._house.HasBalcony = true;
        return this;
    }
    
    public HouseBuilder WithPool()
    {
        this._house.HasPool = true;
        return this;
    }
    
    public HouseBuilder WithSauna()
    {
        this._house.HasSauna = true;
        return this;
    }
}
