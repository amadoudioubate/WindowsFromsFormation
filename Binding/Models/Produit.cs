using System;

namespace Binding.Models
{
    public class Produit
    {
        public int Id { get; set; }

        public string Description { get; set; } = String.Empty;

        private double _prix = 0.0;


        public double Prix
        {
            get { return _prix; }
            set 
            { 
                if(value < 0)
                {
                    throw new Exception("Un prix ne peut pas être négatif");
                }
                _prix = value;
            }
        }

        public Produit()
        {

        }

        public Produit(int id, string description, double prix)
        {
            Id = id;
            Description = description;
            Prix = prix;
           
        }
    }
}
