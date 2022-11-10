using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _03_Files
{
    public class Files
    {

        // Méthode d'écriture

        public static void Write(string path, string contenu, bool append)
        {
            if (File.Exists(path))
            {
                StreamWriter sw = new(path, append);

                sw.Write(contenu);
                sw.Close(); // Fermeture
            }
            else
            {
                throw new Exception("Fichier introuvable");
            }
        }


        // Méthode de lecture

        public static string Reader(string path)
        {
            if (File.Exists(path))
            {
                using (StreamReader sr = new(path))
                {
                    string contenu = sr.ReadToEnd(); // récupération du contenu du fichier dans le flux

                    // sr.close(); Fermeture superflue dans close 'using'
                    return contenu;
                }

                
            }
            else
            {
                throw new Exception("Fichier introuvable");
            }
        }
    }
}
