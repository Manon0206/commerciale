using commerciale;
using System;

class Commercial
{
    private string nom;
    private string prenom;
    private int anneeNaissance;
    private Categorie categorie;
    private Service service;

    public Commercial(string nom, string prenom, int anneeNaissance, Categorie categorie, Service service)
    {
        this.nom = nom;
        this.Prenom = prenom;
        this.anneeNaissance = anneeNaissance;
        this.categorie = categorie;
        this.service = service;
    }

    public string Nom { get => nom; set => nom = value; }
    public string Prenom { get => prenom; set => prenom = value; }
    public int AnneeNaissance { get => anneeNaissance; set => anneeNaissance = value; }
    public Categorie Categorie { get => categorie; set => categorie = value; }
    public Service Service { get => service; set => service = value; }

    public int CalculAge()
    {
        return DateTime.Now.Year - anneeNaissance;
    }

    public override string ToString()
    {
        return "Nom: " + nom + "\n Prénom:" + Prenom + "\n Âge: " + CalculAge() + " \n Catégorie: " + this.categorie;
    }

    public void Compare(Commercial c)
    {
        if (this.Nom.Split(' ')[0].Equals(c.Nom.Split(' ')[0]))
            Console.WriteLine($"{this.Nom} et {c.Nom} ont le même nom de famille.");
        else
            Console.WriteLine($"{this.Nom} et {c.Nom} n'ont pas le même nom de famille.");
    }
}
