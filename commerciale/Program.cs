using commerciale;

class Program
{
    static void Main(string[] args)
    {
        Categorie cat1 = new Categorie("001", "Salarie");
        Categorie cat2 = new Categorie("002", "Indépendant");

        Service national = new Service("National");
        Service international = new Service("International");

        Commercial com1 = new Commercial("Chabault", "Mathis", 2004, cat2 , national);
        Commercial com2 = new Commercial("Boulec", "Tom", 1985, cat1, international);
        Commercial com3 = new Commercial("Kalemba", "Exocé", 1977, cat2, national);

        Console.WriteLine("Informations des commerciaux :");
        Console.WriteLine(com1);
        Console.WriteLine(com2);
        Console.WriteLine(com3);

        com1.Compare(com2);

        national.AjouterCom(com1);
        national.AjouterCom(com2);
        national.AjouterCom(com3);

        international.AjouterCom(com2);
        international.AjouterCom(com3);
    }
}