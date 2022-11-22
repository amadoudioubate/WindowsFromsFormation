using MultiWindows.DAO;
using MultiWindows.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiWindows.Services
{
    public class ProduitService : IProduitService
    {
        IProduitDAO _dao;   

        public ProduitService(IProduitDAO dao)
        {
            _dao = dao;
        }

        public void Add(Produit p)
        {
            _dao.Insert(p);
        }

        public void Delete(int id)
        {
           _dao.DeleteById(id);
        }

        public List<Produit> Filter(string key)
        {
            return _dao.FindByKey(key);
        }

        public List<Produit> GetAll()
        {
            return _dao.GetAll();
        }

        public Produit GetById(int id)
        {
            return _dao.GetById(id);
        }

        public void Update(Produit p)
        {
            _dao.Update(p);
        }
    }
}
