class Dossier
{
    private int Id { get; set; } 
    private string Type { get; set; }
    private class Client { }
    private class ClientAdress { } 

    public Dossier()
    { }

    public Dossier buildDossier(int id, string type, string nom, string prenom, string ville, string rue, int numero)
    {
        var dossier = new Dossier();
        var client = new Client();
        ClientAdress instance = new();
        
        var clientAdresse = new ClientAdress();
        client.BuildClient(nom, prenom);
        clientAdresse.buildClientAdress(ville, rue, numero);

        dossier.Id = id;
        dossier.Type = type;
        dossier.Client = client;
        dossier.ClientAdress = clientAdresse;

        return dossier;
    }
        
}


public class Client 
{
    public string Nom { get; set; }
    public string Prenom { get; set; }

    public Client()
    { }

    public static Client BuildClient(string nom, string prenom)
    {
        var client = new Client();
        client.Nom = nom;
        client.Prenom = prenom;
        return client;
    }

}

public class ClientAdress
{
    public string Ville { get; set; }
    public string Rue { get; set; }
    public int Numero { get; set; }
     
    public ClientAdress()
    { }

    public static ClientAdress buildClientAdress(string Ville, string Rue, int Numero)
    {
        var clientA = new ClientAdress();
        clientA.Ville=Ville;
        clientA.Rue = Rue;
        clientA.Numero = Numero;
        return clientA;
    }
 
}



class MainClass
{
    public static void Main()
    {
        var dossier = new Dossier();
        dossier.buildDossier(1, "composite", "test", "programme",  "incroyable",  "perdu",  10);

        Console.WriteLine(dossier);
        Console.WriteLine("Hello, World!");
    }

}