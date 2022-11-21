using DesignPatterns._CreationalPatterns.BuilderWithDirector.After.Houses;

namespace DesignPatterns._CreationalPatterns.BuilderWithDirector.After.Builder;


public class SimpleHouseBuilder : IHouseBuilder
{
    private SimpleHouse _house;
    
    public SimpleHouseBuilder()
    {
        this.Reset();
    }
    
    public IHouse Build()
    {
        return this._house;
    }

    public void Reset()
    {
        this._house = new SimpleHouse();
    }

    public IHouseBuilder WithNumberOfDoors(int numberOfDoors = 1)
    {
        this._house.NumberOfDoors = numberOfDoors;
        return this;
    }
    
    public IHouseBuilder WithNumberOfWindows(int numberOfWindows = 1)
    {
        this._house.NumberOfWindows = numberOfWindows;
        return this;
    }
    
    public IHouseBuilder WithNumberOfRooms(int numberOfRooms = 1)
    {
        this._house.NumberOfRooms = numberOfRooms;
        return this;
    }
}
