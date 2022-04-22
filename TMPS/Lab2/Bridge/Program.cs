internal class Program
{
    private static void Main(string[] args)
    {

        Programmer freelancer = new FreelanceProgrammer(new CPPLanguage());
        freelancer.DoWork();
        freelancer.EarnMoney();

        freelancer.Language = new CSharpLanguage();
        freelancer.DoWork();
        freelancer.EarnMoney();

        Console.Read();
    }
}

internal interface ILanguage
{
    void Build();

    void Execute();
}

internal class CPPLanguage : ILanguage
{
    public void Build()
    {
        Console.WriteLine("Using the C++ compiler, compile the program into binary code");
    }

    public void Execute()
    {
        Console.WriteLine("Run the executable file of the program");
    }
}

internal class CSharpLanguage : ILanguage
{
    public void Build()
    {
        Console.WriteLine("Using the Roslyn compiler, compile the source code into an exe file");
    }

    public void Execute()
    {
        Console.WriteLine("JIT compiles program binary code");
        Console.WriteLine("CLR executes compiled binary code");
    }
}

internal abstract class Programmer
{
    protected ILanguage language;

    public ILanguage Language
    {
        set { language = value; }
    }

    public Programmer(ILanguage lang)
    {
        language = lang;
    }

    public virtual void DoWork()
    {
        language.Build();
        language.Execute();
    }

    public abstract void EarnMoney();
}

internal class FreelanceProgrammer : Programmer
{
    public FreelanceProgrammer(ILanguage lang) : base(lang)
    {
    }

    public override void EarnMoney()
    {
        Console.WriteLine("Receiving payment for the completed order");
    }
}

internal class CorporateProgrammer : Programmer
{
    public CorporateProgrammer(ILanguage lang)
    : base(lang)
    {
    }

    public override void EarnMoney()
    {
        Console.WriteLine("Getting paid at the end of the month");
    }
}