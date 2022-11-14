namespace DesignPatterns.CreationalPatterns.Builder.Before;

public class StoreyHouse : House
{
    public StoreyHouse(
        int numberOfStoreys,
        int numberOfDoors,
        int numberOfWindows,
        int numberOfRooms) : base(numberOfDoors, numberOfWindows, numberOfRooms)
    {
        NumberOfStoreys = numberOfStoreys;
    }
    
    public int NumberOfStoreys { get; init; }
}