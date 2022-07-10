//classe command avec un attribut action et une fonctione Execute qui écrit dans la console l'action passer
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

//interface de command avec fonction Execute
public interface InterfaceCommand
{
    public void Execute();
}


public class Invoker
{
    //Invoker accèdes à interfaceCommand et ces fonctions
    private InterfaceCommand interfaceCommand;

    public Invoker(InterfaceCommand interfaceCommand)
    {
        this.interfaceCommand = interfaceCommand;
    }

    //fonction qui appel la fonction execute de interfaceCommand
    public void DoCommand()
    {
        interfaceCommand.Execute();
    }

}


public class main
{
    public static void Main()
    {
        //creation de command et d'invoker
        Command command = new Command("delete");
        Invoker invoker = new Invoker(command);
        //appel de la function DoCommand
        invoker.DoCommand();

    }
}
