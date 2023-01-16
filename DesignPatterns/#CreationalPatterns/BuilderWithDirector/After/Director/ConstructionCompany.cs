using DesignPatterns._CreationalPatterns.BuilderWithDirector.After.Builders;
using DesignPatterns._CreationalPatterns.BuilderWithDirector.After.Houses;

namespace DesignPatterns._CreationalPatterns.BuilderWithDirector.After.Director;

public class ConstructionCompany
{
    public IHouse BuildSimpleHouse(IHouseBuilder builder)
    {
        builder.WithNumberOfRooms(2);
        builder.WithNumberOfWindows(3);
        builder.WithNumberOfDoors(1);
        return builder.Build();
        
        // Or with chaining
        // return builder
        //     .WithNumberOfDoors(2)
        //     .WithNumberOfWindows(3)
        //     .WithNumberOfDoors(1)
        //     .Build();
    }
    
    public IHouse BuildLuxuryHouse(ILuxuryHouseBuilder builder)
    {
        builder.WithNumberOfRooms(6);
        builder.WithNumberOfWindows(12);
        builder.WithNumberOfDoors(3);
        builder.WithSizeOfGarage(2);
        builder.WithSizeOfGarden(1000);
        builder.WithBalcony();
        builder.WithPool();
        builder.WithSauna();
        return builder.Build();

        // Or with chaining
        // builder.WithNumberOfRooms(6)
        //     .WithNumberOfWindows(12)
        //     .WithNumberOfDoors(3)
        //     .WithSizeOfGarage(2)
        //     .WithSizeOfGarden(1000)
        //     .WithBalcony()
        //     .WithPool()
        //     .WithSauna()
        //     .Build();
    }
}
