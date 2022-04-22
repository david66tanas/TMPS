using FactoryMethod;

internal class UnknownDancer : Dancer
{
    public override Dance Dance()
    {
        return new UnknownDance();
    }
}