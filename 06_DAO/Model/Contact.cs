using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_DAO.Model
{
    public class Contact
    {
       /* private string v1;
        private string v2;
        private string v3;
        private string v4;*/

        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty;

        public string Prenom { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Telephone { get; set; } = string.Empty;

        public Contact()
        {

        }

        public Contact(string nom, string prenom, string email, string telephone)
        {
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Telephone = telephone;
        }

        
        public override string ToString()
        {
            return $"Nom : {Nom} - Prenom : {Prenom} - Email : {Email} - Téléphone : {Telephone}";
        }
    }
}
