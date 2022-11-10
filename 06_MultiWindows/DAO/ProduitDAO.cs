using MultiWindows.Model;
using System.Data.SqlClient;

namespace MultiWindows.DAO
{
    public class ProduitDAO : IProduitDAO
    {

        public string ConnexionString { get; set; } // Qui sera récuperée via le constructeur

        public ProduitDAO(string connexionString)
        {
            this.ConnexionString = connexionString;
        }

        public void DeleteById(int id)
        {
            string sql = "DELETE FROM Produits WHERE id=@id";

            using (SqlConnection cnx = new(ConnexionString))
            {
                SqlCommand cmd = new(sql, cnx);
                cmd.Parameters.AddWithValue("@id", id);
                cnx.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public List<Produit> FindByKey(string key)
        {

            // UTILISATION D'UNE PROCEDURE STOCKEE PREALABLEMENT CREE DANS LA BDD

            /*
             * CREATE PROCEDURE [dbo].[spGetProductByDescription]
             * @Description [nvarchar](1000)
             * AS
             * SELECT * FROM Produits WHERE description LIKE @Description
             * RETURN 0
            */


            List<Produit> produits = new();

            string sql = "spGetProductByDescription";

            using (SqlConnection cnx = new(ConnexionString))
            {
                SqlCommand cmd = new(sql, cnx);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Description", $"%{key}%");

                cnx.Open();


                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Produit p = new()
                        {
                            Id = reader.GetInt32(0),
                            Description = reader.GetString(1),
                            Prix = reader.GetDouble(2),
                            Quantite = reader.GetInt32(3),
                        };

                        produits.Add(p);

                    }


                }

            }


            return produits;
        }

        public List<Produit> GetAll()
        {
            List<Produit> produits = new();

            string sql = "SELECT * FROM Produits";

            //using (ressource) m'évitera à utiliser try catch
            using (SqlConnection cnx = new(ConnexionString))
            {
                SqlCommand cmd = new(sql, cnx);
                cnx.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Produit p = new()
                        {
                            Id = reader.GetInt32(0),
                            Description = reader.GetString(1),
                            Prix = reader.GetDouble(2),
                            Quantite = reader.GetInt32(3),
                        };

                        produits.Add(p);

                    }


                }
            }



            return produits;
        }


        public Produit GetById(int id)
        {
            Produit produit = new();

            string sql = "SELECT * FROM Produits WHERE id=@id";

            using (SqlConnection cnx = new(ConnexionString))
            {
                SqlCommand cmd = new(sql, cnx);

                cmd.Parameters.AddWithValue("@id", id);
                cnx.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        produit.Id = reader.GetInt32(0);
                        produit.Description = reader.GetString(1);
                        produit.Prix = reader.GetDouble(2);
                        produit.Quantite = reader.GetInt32(3);
                    }
                }
            }

            return produit;
        }

        public void Insert(Produit p)
        {
            string sql = "INSERT INTO Produits(description, prix, quantite) VALUES (@description, @prix, @quantite)";

            using (SqlConnection cnx = new(ConnexionString))
            {
                SqlCommand cmd = new(sql, cnx);

                cmd.Parameters.AddWithValue("@description", p.Description);
                cmd.Parameters.AddWithValue("@prix", p.Prix);
                cmd.Parameters.AddWithValue("@quantite", p.Quantite);

                cnx.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Produit p)
        {
            string sql = "UPDATE Produits SET description=@description, prix=@prix, quantite=@quantite WHERE id=@id";

            using (SqlConnection cnx = new(ConnexionString))
            {
                SqlCommand cmd = new(sql, cnx);

                cmd.Parameters.AddWithValue("@description", p.Description);
                cmd.Parameters.AddWithValue("@prix", p.Prix);
                cmd.Parameters.AddWithValue("@quantite", p.Quantite);
                cmd.Parameters.AddWithValue("@id", p.Id);

                cnx.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
