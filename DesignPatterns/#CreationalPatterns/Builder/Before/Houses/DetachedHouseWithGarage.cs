namespace DesignPatterns._CreationalPatterns.Builder.Before.Houses;

public class DetachedHouseWithGarage : DetachedHouse
{
    public DetachedHouseWithGarage(
        int carCapacity,
        int sizeOfGarden,
        int numberOfDoors,
        int numberOfWindows,
        int numberOfRooms) : base(sizeOfGarden, numberOfDoors, numberOfWindows, numberOfRooms)
    {
        this.CarCapacity = carCapacity;
    }

    public int CarCapacity { get; init; }
}