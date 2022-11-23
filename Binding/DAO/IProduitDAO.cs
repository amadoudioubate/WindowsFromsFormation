using Binding.Models;
using System.Collections.Generic;

namespace Binding.DAO
{
    public interface IProduitDAO
    {
        List<Produit> GetAll();

        Produit? GetById(int id); // GetById qui va nous retourner un produit ou non

        void Insert(Produit produit);
        void Update(Produit produit);

        void Delete(int id);

        // Créer un classe qui implemente cet interface => Class ProduitDAO
    }
}
