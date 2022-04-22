namespace AbstractFactory.Movements
{
    internal class FlyMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Zburam");
        }
    }
}