using factory_method_pattern.Interfaces;

namespace factory_method_pattern.Entities;

public class SpiderMan : ISuperHero
{
    public void UseSuperPower()
    {
        Console.WriteLine("Homem-Aranha usa seu sentido de aranha que o avisa sobre o perigo!");
    }
}
