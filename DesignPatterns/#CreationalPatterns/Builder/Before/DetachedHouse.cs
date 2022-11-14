namespace DesignPatterns.CreationalPatterns.Builder.Before;

public class DetachedHouse : House
{
    public DetachedHouse(
        int sizeOfGarden,
        int numberOfDoors,
        int numberOfWindows,
        int numberOfRooms) : base(numberOfDoors, numberOfWindows, numberOfRooms)
    {
        SizeOfGarden = sizeOfGarden;
    }

    public int SizeOfGarden { get; init; }
}