namespace DesignPatterns.CreationalPatterns.Builder.Before;

public class StoreyHouseWithGarage : StoreyHouse
{
    public StoreyHouseWithGarage(
        int carCapacity,
        int numberOfStorey,
        int numberOfDoors,
        int numberOfWindows,
        int numberOfRooms) : base(numberOfStorey, numberOfDoors, numberOfWindows, numberOfRooms)
    {
        CarCapacity = carCapacity;
    }

    public int CarCapacity { get; init; }
}