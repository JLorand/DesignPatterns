namespace DesignPatterns.CreationalPatterns.Builder.Before;

public class DetachedHouseWithGarage : DetachedHouse
{
    public DetachedHouseWithGarage(
        int carCapacity,
        int sizeOfGarden,
        int numberOfDoors,
        int numberOfWindows,
        int numberOfRooms) : base(sizeOfGarden, numberOfDoors, numberOfWindows, numberOfRooms)
    {
        CarCapacity = carCapacity;
    }

    public int CarCapacity { get; init; }
}