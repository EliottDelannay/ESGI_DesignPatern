public abstract class Personnage {
    //Classe mère avec une fonction clone
    public string name { get; set; }

    public Personnage()
    {}

    public Personnage(string name)
    {
        this.name = name;
    }

     public Personnage clone()
    {
        return (Personnage)this.MemberwiseClone();
    }
}

public class Npc : Personnage
{
    //Class fille héritant de personnage
    public Npc(string faction)
    {
        this.Faction = faction;
    }

    public Personnage clone()
    {
        return (Npc)this.MemberwiseClone();
    }

    public string Faction { get; set; }
}

public class Pc : Personnage
{
    //Class fille héritant de personnage
    public Pc(string guildName)
    {
        this.guildName = guildName;
    }

    public Personnage clone()
    {
        return (Pc)this.MemberwiseClone();
    }

    public string guildName { get; set; }
}

public class main
{
    //création d'un objet de type npc
    //création d'une copie de npc 
    public static void Main()
    {
        Npc Npc = new Npc("test");
        Npc Npc2 = (Npc)Npc.clone();
        Console.WriteLine(Npc);
        Console.WriteLine(Npc2);
        Console.WriteLine("Hello, World!");
    }
    
}

