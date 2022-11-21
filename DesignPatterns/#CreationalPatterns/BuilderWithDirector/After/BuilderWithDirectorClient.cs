﻿using DesignPatterns._CreationalPatterns.BuilderWithDirector.After.Builder;
using DesignPatterns._CreationalPatterns.BuilderWithDirector.After.Director;

namespace DesignPatterns.CreationalPatterns.Builder.After;

public static class BuilderWithDirectorClient
{
    public static void ExecutePattern()
    {
        // Some logic before creating concrete types

        var company = new ConstructionCompany();
        
        var simpleHouseBuilder = new SimpleHouseBuilder();
        var simpleHouse = company.BuildSimpleHouse(simpleHouseBuilder);
        Console.WriteLine(simpleHouse);
        
        
        var luxuryHouseBuilder = new LuxuryHouseBuilder();
        var luxurxHouse = company.BuildLuxuryHouse(luxuryHouseBuilder);
        Console.WriteLine(luxurxHouse);
        
        // Some logic after concrete types created
    }
}
