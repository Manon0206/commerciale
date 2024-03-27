namespace commerciale
{
    class Service
    {
        private string nomService;
        private Commercial[] tableau;
        private int effectif;

        public string NomService { get => nomService; set => nomService = value; }
        internal Commercial[] Tableau { get => tableau; set => tableau = value; }
        public int Effectif { get => effectif; set => effectif = value; }

        public Service(string nomService)
        {
            this.nomService = nomService;
            tableau = new Commercial[10];
            effectif = 0;
        }

        public void AjouterCom(Commercial c)
        {
            if (effectif < 10)
            {
                Tableau[effectif] = c;
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
                Console.WriteLine(Tableau[i]);
            }
        }

        public Commercial CommercialPlusAge()
        {
            Commercial plusAge = Tableau[0];
            foreach (Commercial c in Tableau)
            {
                if (c.CalculAge() > plusAge.CalculAge())
                {
                    plusAge = c;
                }
            }
            return plusAge;
        }
    }
}
