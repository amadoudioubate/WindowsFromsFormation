using MultiWindows.Model;

namespace MultiWindows.DAO
{
    public interface IProduitDAO
    {

        // GRUD
        // C : Create
        // R : Read
        // U : Update
        // D : Delete
        void Insert(Produit p);
        List<Produit> FindByKey(string key);
        List<Produit> GetAll();
        Produit GetById(int id);
        void Update(Produit p);
        void DeleteById(int id);
    }
}
