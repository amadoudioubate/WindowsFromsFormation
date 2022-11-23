using Binding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binding.DAO
{
    public class ProduitDAO : IProduitDAO
    {
        // Comme on va pas utiliser la BD, on va le faire en dur dans le constructeur ProduitDAO

        private readonly List<Produit> _produits = new();


        public ProduitDAO()
        {
            _produits.Add(new Produit(1, "clavier", 45));
            _produits.Add(new Produit(1, "ordinateur", 450));
            _produits.Add(new Produit(1, "souris", 15));
        }
        

        public List<Produit> GetAll()
        {
            return _produits;
        }

        public Produit? GetById(int id)
        {
            return _produits.FirstOrDefault(p => p.Id == id);
        }

        public void Insert(Produit produit)
        {
            // Si on a des produits dans notre liste, on attribue le Max des Id des produits + 1, sinon on retourne 1
            produit.Id = _produits.Count() > 0 ? _produits.Max(p => p.Id) : 1;
            
            _produits.Add(produit);
        }

        public void Update(Produit produit)
        {
            Produit? found = GetById(produit.Id); // On trouve le produit à mettre à jour

            if (found is not null) // Si le produit existe , on le met à jour
            {
                _produits[_produits.IndexOf(found)] = produit;
            }
        }

        public void Delete(int id)
        {
            Produit? found = GetById(id); // On trouve le produit à supprimer

            if (found is not null) // Si le produit existe on le supprime
            {
                _produits.Remove(found);
            }
        }
    }
}
