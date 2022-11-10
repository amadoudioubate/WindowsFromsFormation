using _06_DAO.Model;
using System.Data.SqlClient;


/*
 * Ajouter nuget.org dans les paramètre du gestionnaire de package
 * https://api.nuget.org/v3/index.json
 * 
 * Ajouter System.Data.SqlClient via le gestionnaire de package
 */


//Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CsharpBureau;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
namespace _06_DAO.DAO
{
    public class ContactDAO : IContactDAO
    {
        public string ConnexionString { get; set; } // Qui sera récuperée via le constructeur

        public ContactDAO(string connexionString)
        {
            this.ConnexionString = connexionString;
        }

        public void AddContact(Contact c)
        {
            SqlConnection cnx = new(ConnexionString); // Objet de type sql connexion

            // NE PAS UTILISER DE CONCATENATION DE string pour passer les paramètres de la requête
            // CAR CA EXPOSE AU RISQUE D'INJECTION SQL
            //string sql = "INSERT INTO Contacts(nom, prenom, email, telephone) VALUES ({c.Nom}, {c.Prenom}, {c.Email}, {c.Telephone})";


            try
            {

                string sql = "INSERT INTO Contacts(nom, prenom, email, telephone) VALUES (@nom, @prenom, @email, @telephone)";

                SqlCommand cmd = new(sql, cnx);

                cmd.Parameters.AddWithValue("@nom", c.Nom);
                cmd.Parameters.AddWithValue("@prenom", c.Prenom);
                cmd.Parameters.AddWithValue("@email", c.Email);
                cmd.Parameters.AddWithValue("@telephone", c.Telephone);

                cnx.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cnx.Close();
            }
        }

        // Retourne une liste de contact
        public List<Contact> GetAll()
        {
            List<Contact> contacts = new();

            string sql = "SELECT * FROM Contacts";

            //using (ressource) m'évitera à utiliser try catch
            using (SqlConnection cnx = new(ConnexionString))
            {
                SqlCommand cmd = new(sql, cnx);
                cnx.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Contact c = new()
                        {
                            Id = reader.GetInt32(0),
                            Nom = reader.GetString(1),
                            Prenom = reader.GetString(2),
                            Email = reader.GetString(3),
                            Telephone = reader.GetString(4)
                        };

                        contacts.Add(c);

                    }


                }
            }



            return contacts;
        }
    }
}
