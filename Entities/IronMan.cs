using factory_method_pattern.Interfaces;

namespace factory_method_pattern.Entities;

public class IronMan : ISuperHero
{
    public void UseSuperPower()
    {
        Console.WriteLine("Homem de Ferro dispara seus feixes repulsores!");
    }
}
