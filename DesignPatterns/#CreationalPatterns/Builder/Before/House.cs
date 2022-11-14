namespace DesignPatterns.CreationalPatterns.Builder.Before;

public abstract class House
{
    public House(
        int numberOfDoors,
        int numberOfWindows,
        int numberOfRooms)
    {
        NumberOfDoors = numberOfDoors;
        NumberOfWindows = numberOfWindows;
        NumberOfRooms = numberOfRooms;
    }

    public int NumberOfDoors { get; init; }
    public int NumberOfWindows { get; init; }
    public int NumberOfRooms { get; init; }
}