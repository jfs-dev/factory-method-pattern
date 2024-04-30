using factory_method_pattern.Creators;
using factory_method_pattern.Interfaces;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine();
Console.WriteLine("Factory Method Pattern");
Console.WriteLine("----------------------");
Console.ForegroundColor = ConsoleColor.Magenta;

SuperHeroCreator spiderManCreator = new SpiderManCreator();

ISuperHero spiderMan = spiderManCreator.FactoryMethod();
spiderMan.UseSuperPower();

SuperHeroCreator ironManCreator = new IronManCreator();

ISuperHero ironMan = ironManCreator.FactoryMethod();
ironMan.UseSuperPower();
