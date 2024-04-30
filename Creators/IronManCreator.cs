using factory_method_pattern.Entities;
using factory_method_pattern.Interfaces;

namespace factory_method_pattern.Creators;

public class IronManCreator : SuperHeroCreator
{
    public override ISuperHero FactoryMethod() => new IronMan();
}
