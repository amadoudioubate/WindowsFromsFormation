namespace MultiWindows.Model
{
    public class Produit
    {
        public int Id { get; set; }
        public string Description { get; set; } = String.Empty;
        public double Prix { get; set; } = 0.0;
        public int Quantite { get; set; } = 0;

        public Produit()
        {

        }

        public Produit(int id, string description, double prix, int quantite)
        {
            Id = id;
            Description = description;
            Prix = prix;
            Quantite = quantite;
        }

        public override string ToString()
        {
            return "Description: " + Description + " Prix: " + Prix + " Quantité: " + Quantite;
        }
    }
}
