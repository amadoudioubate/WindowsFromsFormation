
using MultiWindows.Model;

namespace _07_MultiWindows.Services
{
    public interface IUtilisateurService
    {
        void RemoveByLogin(string login);

        string? Insert(Utilisateur user);

        void Update(Utilisateur user);

        Utilisateur? GetByLogin(string login);

        List<Utilisateur> GetAll();

        bool IsUserAdmin(string login);

        bool Authenticate(string login, string password);
    }
}

