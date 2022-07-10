public class Command : InterfaceCommand
{
    private string Action { get; set; }

    public Command(string action)
    {
        Action = action;
    }

    public void Execute()
    {
        Console.WriteLine(Action);
    }

}

public interface InterfaceCommand
{
    public void Execute();
}


public class Invoker
{
    private InterfaceCommand interfaceCommand;

    public Invoker(InterfaceCommand interfaceCommand)
    {
        this.interfaceCommand = interfaceCommand;
    }

    public void Write()
    {
        interfaceCommand.Execute();
    }

}


public class main
{
    public static void Main()
    {
        Command command = new Command("delete");
        Invoker invoker = new Invoker(command);
        invoker.Write();

    }
}
