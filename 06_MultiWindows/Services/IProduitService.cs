using MultiWindows.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiWindows.Services
{
    public interface IProduitService
    {
        List<Produit> GetAll();

        Produit GetById(int id);

        void Add(Produit p);

        void Update(Produit p);

        void Delete(int id);

        List<Produit> Filter(string key);
    }
}
