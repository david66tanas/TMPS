namespace FactoryMethod
{
    public class Ballerina : Dancer
    {
        public override Dance Dance()
        {
            return new Ballet();
        }
    }
}