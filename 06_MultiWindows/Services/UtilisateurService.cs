
using _07_MultiWindows.Tools;
using MultiWindows.DAO;
using MultiWindows.Model;

namespace _07_MultiWindows.Services
{
    public class UtilisateurService : IUtilisateurService
    {
        IUtilisateurDAO _dao;

        public UtilisateurService(IUtilisateurDAO dao)
        {
            _dao = dao;
        }

        public bool Authenticate(string login, string password)
        {
            Utilisateur u = _dao.GetByLogin(login);

            if (u is not null
                && u.Password is not null
                && u.Password.Equals(HashTool.HashPassword(password)))
            {
                return true;
            }
            return false;
        }

        public List<Utilisateur> GetAll()
        {
            return _dao.GetAll();
        }

        public Utilisateur? GetByLogin(string login)
        {
            return _dao.GetByLogin(login);
        }

        public string? Insert(Utilisateur user)
        {
            user.Password = HashTool.HashPassword(user.Password);
            return _dao.Insert(user);
        }

        public bool IsUserAdmin(string login)
        {
            Utilisateur u = _dao.GetByLogin(login);

            if (u.Profile.ToString() == "ADMIN")
            {
                return true;
            }

            return false;
        }

        public void RemoveByLogin(string login)
        {
            _dao.DeleteByLogin(login);
        }

        public void Update(Utilisateur user)
        {
            Utilisateur userBDD = _dao.GetByLogin(user.Login);

            if (user.Password is null)
            {
                return;
            }

            if (userBDD is null)
            {
                return;
            }

            if (!userBDD.Password.Equals(user.Password))
            {
                user.Password = HashTool.HashPassword(user.Password);
            }

            _dao.Update(user);
        }
    }
}

