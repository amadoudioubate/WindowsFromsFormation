using MultiWindows.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiWindows.DAO
{
    public interface IUtilisateurDAO
    {
        // GRUD
        // C : Create
        // R : Read
        // U : Update
        // D : Delete
        //void Insert(Utilisateur u);

        public string? Insert(Utilisateur u);
        //List<Utilisateur> FindByLogin(string login);
        List<Utilisateur> GetAll();
        Utilisateur? GetByLogin(string login);
        void Update(Utilisateur u);
        void DeleteByLogin(string login);
    }
}
