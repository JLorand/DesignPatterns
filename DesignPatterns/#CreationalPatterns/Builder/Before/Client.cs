using DesignPatterns._CreationalPatterns.Builder.Before.Houses;

namespace DesignPatterns.CreationalPatterns.Builder.Before;

public static class Client
{
    public static void Execute()
    {
        // Some logic before creating concrete types
        
        var detachedHouseWithGarage = new LuxuryDetachedHouse(true, true, true, 2, 100, 2, 8, 8);

        // Some logic after concrete types created
    }
}
