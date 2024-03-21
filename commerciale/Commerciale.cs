using commerciale;
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
