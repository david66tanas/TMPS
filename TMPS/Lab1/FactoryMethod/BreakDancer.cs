namespace FactoryMethod
{
    public class BreakDancer : Dancer
    {
        public override Dance Dance()
        {
            return new BreakDance();
        }
    }
}