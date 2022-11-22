using MultiWindows.Model;
using System.Data.SqlClient;

namespace MultiWindows.DAO
{
    public class UtilisateurDAO : IUtilisateurDAO
    {
        public string ConnexionString { get; set; } // Qui sera récuperée via le constructeur

        // Constructeur
        public UtilisateurDAO(string connexionString)
        {
            this.ConnexionString = connexionString;
        }

        // DELETE
        public void DeleteByLogin(string login)
        {
            string sql = "DELETE FROM Utilisateurs WHERE login=@login";

            using (SqlConnection cnx = new(ConnexionString))
            {
                SqlCommand cmd = new(sql, cnx);
                cmd.Parameters.AddWithValue("@login", login);
                cnx.Open();

                cmd.ExecuteNonQuery();
            }
        }



        // GETALL
        public List<Utilisateur> GetAll()
        {
            List<Utilisateur> users = new();

            string sql = "SELECT * FROM Utilisateurs";

            //using (ressource) m'évitera à utiliser try catch
            using (SqlConnection cnx = new(ConnexionString))
            {
                SqlCommand cmd = new(sql, cnx);
                cnx.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Utilisateur u = new()
                        {
                            /*SQL Server Data Type Mappings 
                             * 
                             * https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/sql-server-data-type-mappings
                             * 
                             * bigint           - GetInt64
                             * binary           - GetBytes  
                             * int              - GetInt32  
                             * money            - GetDecimal  
                             * rowversion       - GetBytes  
                             * smallint         - GetInt16  
                             * tinyint          - GetByte  
                             * uniqueidentifier - GetGuid
                             */


                            Login = reader.GetString(0),
                            Password = reader.GetString(1),
                            Photo = reader.IsDBNull(2) ? null : reader.GetString(2),
                            Profile = (Profile)reader.GetByte(3),    
                        };

                        users.Add(u);

                    }


                }
            }

            return users;
        }


        // GETBYLOGIN
        public Utilisateur? GetByLogin(string login)
        {
            //Utilisateur user = new();

            string sql = "SELECT * FROM Utilisateurs WHERE login=@login";

            using (SqlConnection cnx = new(ConnexionString))
            {
                SqlCommand cmd = new(sql, cnx);

                cmd.Parameters.AddWithValue("@login", login);
                cnx.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Utilisateur user = new();
                        user.Login = reader.GetString(0);
                        user.Password = reader.GetString(1);
                        user.Photo = reader.GetString(2);
                        user.Profile = (Profile)reader.GetByte(3);

                        return user;
                    }
                }
            }

            return null;

        }




        public string? Insert(Utilisateur u)
        {
            string sql = "spAddUser"; // <PROCEDURE STOCKEE

            SqlParameter outputLogin;

            using (SqlConnection cnx = new(ConnexionString))
            {
                SqlCommand cmd = new(sql, cnx);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@login", u.Login);
                cmd.Parameters.AddWithValue("@password", u.Password);
                cmd.Parameters.AddWithValue("@photo", (object?)u.Photo ?? DBNull.Value); // A ?? B => retourne A si A != NULL / Retourne B sinon
                cmd.Parameters.AddWithValue("@profile", u.Profile);

                outputLogin = new SqlParameter()
                {
                    ParameterName = "@nextLogin",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Size = 1000,
                    Direction = System.Data.ParameterDirection.Output
                };

                cmd.Parameters.Add(outputLogin);

                cnx.Open();

                cmd.ExecuteNonQuery();
            }

            return outputLogin.Value.ToString();


        }
        



        public void Update(Utilisateur u)
        {
            string sql = "UPDATE Utilisateurs SET password=@password, photo=@photo, profile=@profile WHERE login=@login";

            using (SqlConnection cnx = new(ConnexionString))
            {
                SqlCommand cmd = new(sql, cnx);

                cmd.Parameters.AddWithValue("@login", u.Login);
                cmd.Parameters.AddWithValue("@password", u.Password);
                cmd.Parameters.AddWithValue("@photo", (object?)u.Photo ?? DBNull.Value); // A ?? B => retourne A si A != NULL / Retourne B sinon
                cmd.Parameters.AddWithValue("@profile", u.Profile);

                cnx.Open();

                cmd.ExecuteNonQuery();
            }

        }


    }
}
