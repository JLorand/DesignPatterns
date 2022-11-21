namespace DesignPatterns._CreationalPatterns.Builder.Before.Houses;

public class DetachedHouse : House
{
    public DetachedHouse(
        int sizeOfGarden,
        int numberOfDoors,
        int numberOfWindows,
        int numberOfRooms) : base(numberOfDoors, numberOfWindows, numberOfRooms)
    {
        this.SizeOfGarden = sizeOfGarden;
    }

    public int SizeOfGarden { get; init; }
}
