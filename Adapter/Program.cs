class KiloAdapter : Gramme
{
    // interface permettant de passer un kilo en kiloAdapter
    private Kilo Kilo;

    public KiloAdapter(Kilo kilo)
    {
        this.Kilo = kilo;
       
    }

    public int getPoids()
    {
        return Kilo.PoidsKilo*1000;
    }
}

class Gramme
{
    //class gramme avec un attribut et constructeur
    public int Poids { get; set ; }

    public Gramme(int Poids)
    {
        this.Poids = Poids;
    }

    public Gramme()
    {
       
    }

    //methode vérifiant si le poids passé en paramètre est équivalent à celui de l'objet
    public Boolean equivalent(int kilo)
    {
        if (Poids == kilo)
        {
            return true;
        }
        return false;
    }

}


class Kilo
{
    //class Kilo avec un attribut et constructeur
    public int PoidsKilo { get; set; }

    public Kilo(int PoidsKilo)
    {
        this.PoidsKilo = PoidsKilo;
    }

}


class main
{
    public static void Main()
    {
        //creation de nouveau objets de type gramme et killo
        Gramme gramme = new Gramme(1000);
        
        Kilo kilo = new Kilo(1);

        //conversion d'un kilo en kiloAdapter
        KiloAdapter kiloAdapter = new KiloAdapter(kilo);
        gramme.equivalent(kilo.PoidsKilo);

        //verification si le kiloAdapter a le même poids que gramme
        Console.WriteLine(gramme.equivalent(kiloAdapter.getPoids()));      

    }

}

