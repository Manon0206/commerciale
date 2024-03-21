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
        this.Prenom = prenom;
        this.anneeNaissance = anneeNaissance;
        this.categorie = categorie;
    }

    public string Nom { get => nom; set => nom = value; }
    public string Prenom { get => prenom; set => prenom = value; }
    public int AnneeNaissance { get => anneeNaissance; set => anneeNaissance = value; }
    public Categorie Categorie { get => categorie; set => categorie = value; }

    public int CalculAge()
    {
        return DateTime.Now.Year - anneeNaissance;
    }

    public override string ToString()
    {
        return $"Nom: {nom}, Prénom: {Prenom}, Âge: {CalculAge()}, Catégorie: {categorie}";
    }

    public void Compare(Commercial c)
    {
        if (this.nom.Split(' ')[0].Equals(c.nom.Split(' ')[0]))
            Console.WriteLine($"{this.nom} et {c.nom} ont le même nom de famille.");
        else
            Console.WriteLine($"{this.nom} et {c.nom} n'ont pas le même nom de famille.");
    }
}
