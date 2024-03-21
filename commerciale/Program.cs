class Program
{
    static void Main(string[] args)
    {
        Categorie salarie = new Categorie("001", "Salarie");
        Categorie independant = new Categorie("002", "Indépendant");

        Commercial com1 = new Commercial("Chabault", "Mathis", 1975, salarie);
        Commercial com2 = new Commercial("Boulec", "Tom", 1985, independant);
        Commercial com3 = new Commercial("Habert", "Manon", 1977, salarie);

        Console.WriteLine("Informations des commerciaux :");
        Console.WriteLine(com1);
        Console.WriteLine(com2);
        Console.WriteLine(com3);

        com1.Compare(com2);

        Service national = new Service("National");
        Service international = new Service("International");

        national.AjouterCom(com1);
        national.AjouterCom(com2);
        national.AjouterCom(com3);

        international.AjouterCom(com2);
        international.AjouterCom(com3);

        Console.WriteLine("\nCommerciaux du service National :");
        national.AfficherCommerciaux();

        Console.WriteLine("\nCommerciaux du service International :");
        international.AfficherCommerciaux();
    }
}