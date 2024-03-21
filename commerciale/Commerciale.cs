using System;

class Commercial
{
    private string nom;
    private string prenom;
    private int anneeNaissance;
    private Categorie categorie;

    public Commercial(string nom, string prenom, int anneeNaissance, Categorie categorie)
    {
        this.nom = nom;
        this.prenom = prenom;
        this.anneeNaissance = anneeNaissance;
        this.categorie = categorie;
    }

    public string Nom
    {
        get { return nom; }
        set { nom = value; }
    }

    public string Prenom
    {
        get { return prenom; }
        set { prenom = value; }
    }

    public int AnneeNaissance
    {
        get { return anneeNaissance; }
        set { anneeNaissance = value; }
    }

    public int CalculAge()
    {
        return DateTime.Now.Year - anneeNaissance;
    }

    public override string ToString()
    {
        return $"Nom: {nom}, Prénom: {prenom}, Âge: {CalculAge()}, Catégorie: {categorie}";
    }

    public void Compare(Commercial c)
    {
        if (this.nom.Split(' ')[0].Equals(c.nom.Split(' ')[0]))
            Console.WriteLine($"{this.nom} et {c.nom} ont le même nom de famille.");
        else
            Console.WriteLine($"{this.nom} et {c.nom} n'ont pas le même nom de famille.");
    }
}

class Categorie
{
    private string codeCategorie;
    private string libCategorie;

    public Categorie(string codeCategorie, string libCategorie)
    {
        this.codeCategorie = codeCategorie;
        this.libCategorie = libCategorie;
    }

    public string CodeCategorie
    {
        get { return codeCategorie; }
        set { codeCategorie = value; }
    }

    public string LibCategorie
    {
        get { return libCategorie; }
        set { libCategorie = value; }
    }

    public override string ToString()
    {
        return $"Code: {codeCategorie}, Libellé: {libCategorie}";
    }
}

class Service
{
    private string nomService;
    private Commercial[] commerciaux;
    private int effectif;

    public Service(string nomService)
    {
        this.nomService = nomService;
        commerciaux = new Commercial[10];
        effectif = 0;
    }

    public void AjouterCom(Commercial c)
    {
        if (effectif < 10)
        {
            commerciaux[effectif] = c;
            effectif++;
        }
        else
        {
            Console.WriteLine("Impossible d'ajouter plus de commerciaux.");
        }
    }

    public void AfficherCommerciaux()
    {
        Console.WriteLine($"Commerciaux du service {nomService}:");
        for (int i = 0; i < effectif; i++)
        {
            Console.WriteLine(commerciaux[i]);
        }
    }
}