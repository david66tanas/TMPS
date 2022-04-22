internal class Program
{
    private static void Main(string[] args)
    {
        Driver driver = new Driver();
        Auto auto = new Auto();

        driver.Travel(auto);

        Horse horse = new Horse();
        ITransport camelTransport = new HorseToTransportAdapter(horse);

        driver.Travel(camelTransport);
    }
}

internal interface ITransport
{
    void Drive();
}

internal class Auto : ITransport
{
    public void Drive()
    {
        Console.WriteLine("Cu masina mergem pe drum");
    }
}

internal class Driver
{
    public void Travel(ITransport transport)
    {
        transport.Drive();
    }
}

internal interface IAnimal
{
    void Move();
}

internal class Horse : IAnimal
{
    public void Move()
    {
        Console.WriteLine("Cu calul mergem pe camp");
    }
}

internal class HorseToTransportAdapter : ITransport
{
    private Horse horse;

    public HorseToTransportAdapter(Horse c)
    {
        horse = c;
    }

    public void Drive()
    {
        horse.Move();
    }
}