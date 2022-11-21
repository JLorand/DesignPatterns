namespace DesignPatterns._CreationalPatterns.Builder.Before.Houses;

public class LuxoryDetachedHouse : DetachedHouse
{
    public LuxoryDetachedHouse(
        bool hasBalcony,
        bool hasPool,
        bool hasSauna,
        int carCapacity,
        int sizeOfGarden,
        int numberOfDoors,
        int numberOfWindows,
        int numberOfRooms) : base(sizeOfGarden, numberOfDoors, numberOfWindows, numberOfRooms)
    {
        this.HasBalcony = hasBalcony;
        this.HasPool = hasPool;
        this.HasSauna = hasSauna;
        this.CarCapacity = carCapacity;
    }

    public bool HasBalcony { get; init; }
    public bool HasPool { get; init; }
    public bool HasSauna { get; init; }
    public int CarCapacity { get; init; }
}
