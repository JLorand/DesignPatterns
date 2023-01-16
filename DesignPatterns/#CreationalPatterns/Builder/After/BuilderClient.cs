using DesignPatterns._CreationalPatterns.Builder.After.Builders;

namespace DesignPatterns.CreationalPatterns.Builder.After;

public static class BuilderClient
{
    public static void ExecutePattern()
    {
        // Some logic before creating concrete types
        
        var simpleHouseBuilder = new HouseBuilder();
        simpleHouseBuilder.WithNumberOfRooms(2);
        simpleHouseBuilder.WithNumberOfWindows(3);
        simpleHouseBuilder.WithNumberOfDoors(1);
        var simpleHouse = simpleHouseBuilder.Build();

        // Or with chaining the methods
        // var simpleHouse = new HouseBuilder()
        //     .WithNumberOfRooms(2)
        //     .WithNumberOfWindows(3)
        //     .WithNumberOfDoors(1)
        //     .Build();
        Console.WriteLine(simpleHouse);
        
        
        var luxoryHouseBuilder = new HouseBuilder();
        luxoryHouseBuilder.WithNumberOfRooms(6);
        luxoryHouseBuilder.WithNumberOfWindows(12);
        luxoryHouseBuilder.WithNumberOfDoors(3);
        luxoryHouseBuilder.WithSizeOfGarage(2);
        luxoryHouseBuilder.WithSizeOfGarden(1000);
        luxoryHouseBuilder.WithBalcony();
        luxoryHouseBuilder.WithPool();
        luxoryHouseBuilder.WithSauna();
        var luxoryHouse = luxoryHouseBuilder.Build();
        
        // Or with chaining the methods
        // var luxoryHouse = new HouseBuilder().WithNumberOfRooms(6)
        //     .WithNumberOfWindows(12)
        //     .WithNumberOfDoors(3)
        //     .WithSizeOfGarage(2)
        //     .WithSizeOfGarden(1000)
        //     .WithBalcony()
        //     .WithPool()
        //     .WithSauna()
        //     .Build();
        
        Console.WriteLine(luxoryHouse);
        // Some logic after concrete types created
    }
}
