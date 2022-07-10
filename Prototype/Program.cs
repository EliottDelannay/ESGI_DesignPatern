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

public class main
{
    //création d'un objet de type npc
    //changement de valeur de faction
    //création d'une copie de npc 
    //affichage des deux objets
    public static void Main()
    {
        Npc Npc = new Npc("test");
        Npc.Faction = "champion";
        Npc Npc2 = (Npc)Npc.clone();
        Console.WriteLine(Npc.Faction);
        Console.WriteLine(Npc2.Faction);
    }
    
}

