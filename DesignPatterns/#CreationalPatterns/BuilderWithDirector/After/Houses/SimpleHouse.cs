using DesignPatterns._CreationalPatterns.BuilderWithDirector.After.Houses;

namespace DesignPatterns._CreationalPatterns.BuilderWithDirector.After.Houses;

public class SimpleHouse : IHouse
{
    public int NumberOfDoors { get; set; }
    public int NumberOfWindows { get; set; }
    public int NumberOfRooms { get; set; }

    public override string ToString()
    {
        return $"NumberOfDoors = {NumberOfDoors}, " +
               $"NumberOfWindows = {NumberOfWindows}, " +
               $"NumberOfRooms = {NumberOfRooms}";
    }
}
