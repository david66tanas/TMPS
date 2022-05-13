﻿internal class Program
{
    private static void Main(string[] args)
    {
        ManagerMediator mediator = new ManagerMediator();
        Colleague customer = new CustomerColleague(mediator);
        Colleague programmer = new ProgrammerColleague(mediator);
        Colleague tester = new TesterColleague(mediator);
        mediator.Customer = customer;
        mediator.Programmer = programmer;
        mediator.Tester = tester;
        customer.Send("Avem comanda, trebuie de facut o aplicatie");
        programmer.Send("Applicatie este gata, ea trebuie sa fie testata");
        tester.Send("Programa e testata si e gata pentru prod");

        Console.Read();
    }
}

internal abstract class Mediator
{
    public abstract void Send(string msg, Colleague colleague);
}

internal abstract class Colleague
{
    protected Mediator mediator;

    public Colleague(Mediator mediator)
    {
        this.mediator = mediator;
    }

    public virtual void Send(string message)
    {
        mediator.Send(message, this);
    }

    public abstract void Notify(string message);
}

internal class CustomerColleague : Colleague
{
    public CustomerColleague(Mediator mediator)
    : base(mediator)
    { }

    public override void Notify(string message)
    {
        Console.WriteLine("Mesaj pentru client: " + message);
    }
}

// класс программиста
internal class ProgrammerColleague : Colleague
{
    public ProgrammerColleague(Mediator mediator)
    : base(mediator)
    { }

    public override void Notify(string message)
    {
        Console.WriteLine("Mesaj pentru programist: " + message);
    }
}

// класс тестера
internal class TesterColleague : Colleague
{
    public TesterColleague(Mediator mediator)
    : base(mediator)
    { }

    public override void Notify(string message)
    {
        Console.WriteLine("Mesaj pentru tester: " + message);
    }
}

internal class ManagerMediator : Mediator
{
    public Colleague Customer { get; set; }
    public Colleague Programmer { get; set; }
    public Colleague Tester { get; set; }

    public override void Send(string msg, Colleague colleague)
    {
        // если отправитель - заказчик, значит есть новый заказ
        // отправляем сообщение программисту - выполнить заказ
        if (Customer == colleague)
            Programmer.Notify(msg);
        // если отправитель - программист, то можно приступать к тестированию
        // отправляем сообщение тестеру
        else if (Programmer == colleague)
            Tester.Notify(msg);
        // если отправитель - тест, значит продукт готов
        // отправляем сообщение заказчику
        else if (Tester == colleague)
            Customer.Notify(msg);
    }
}