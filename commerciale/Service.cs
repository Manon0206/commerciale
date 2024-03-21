namespace commerciale
{
    internal class Service
    {
            private string nomService;
            private Commercial[] tableau;
            private int effectif;

        public string NomService { get => nomService; set => nomService = value; }
        internal Commercial[] Tableau { get => tableau; set => tableau = value; }
        public int Effectif { get => effectif; set => effectif = value; }

        public Service(string nomService)
            {
                this.NomService = nomService;
                Tableau = new Commercial[10];
                Effectif = 0;
            }

            public void AjouterCom(Commercial c)
            {
                if (Effectif < 10)
                {
                    Tableau[Effectif] = c;
                    Effectif++;
                }
                else
                {
                    Console.WriteLine("Impossible d'ajouter plus de commerciaux.");
                }
            }

            public void AfficherCommerciaux()
            {
                Console.WriteLine($"Commerciaux du service {NomService}:");
                for (int i = 0; i < Effectif; i++)
                {
                    Console.WriteLine(Tableau[i]);
                }
            }
    }
}

