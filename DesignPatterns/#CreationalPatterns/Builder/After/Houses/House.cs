namespace DesignPatterns._CreationalPatterns.Builder.After.Houses;

public class House
{
    public bool HasBalcony { get; set; }
    public bool HasPool { get; set; }
    public bool HasSauna { get; set; }
    public int CarCapacity { get; set; }
    public int SizeOfGarden { get; set; }
    public int NumberOfDoors { get; set; }
    public int NumberOfWindows { get; set; }
    public int NumberOfRooms { get; set; }

    public override string ToString()
    {
        return $"HasBalcony = {HasBalcony}, " +
               $"HasPool = {HasPool}, " +
               $"HasSauna = {HasSauna}, " +
               $"CarCapacity = {CarCapacity}, " +
               $"SizeOfGarden = {SizeOfGarden}, " +
               $"NumberOfDoors = {NumberOfDoors}, " +
               $"NumberOfWindows = {NumberOfWindows}, " +
               $"NumberOfRooms = {NumberOfRooms}";
    }
}
