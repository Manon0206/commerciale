namespace commerciale
{
    internal class Service
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
}

