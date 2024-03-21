namespace commerciale
{
    internal class Categorie
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

}

