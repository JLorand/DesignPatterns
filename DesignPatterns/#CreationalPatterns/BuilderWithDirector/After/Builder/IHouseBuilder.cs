using DesignPatterns._CreationalPatterns.BuilderWithDirector.After.Houses;

namespace DesignPatterns._CreationalPatterns.BuilderWithDirector.After.Builder;

public interface IHouseBuilder
{
    public IHouse Build();

    public void Reset();

    public IHouseBuilder WithNumberOfDoors(int numberOfDoors = 1);

    public IHouseBuilder WithNumberOfWindows(int numberOfWindows = 1);

    public IHouseBuilder WithNumberOfRooms(int numberOfRooms = 1);
}
