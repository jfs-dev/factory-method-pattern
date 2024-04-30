using factory_method_pattern.Interfaces;

namespace factory_method_pattern.Creators;

public abstract class SuperHeroCreator
{
    public abstract ISuperHero FactoryMethod();
}
