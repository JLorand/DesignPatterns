namespace DesignPatterns._CreationalPatterns.Builder.Before.Houses;

public abstract class House
{
    public House(
        int numberOfDoors,
        int numberOfWindows,
        int numberOfRooms)
    {
        this.NumberOfDoors = numberOfDoors;
        this.NumberOfWindows = numberOfWindows;
        this.NumberOfRooms = numberOfRooms;
    }

    public int NumberOfDoors { get; init; }
    public int NumberOfWindows { get; init; }
    public int NumberOfRooms { get; init; }
}