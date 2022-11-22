using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    public class WebSite
    {
        public string Url { get; set; } = String.Empty;

        public string Donnees { get; set; } = String.Empty;

        public static WebSite Download(string url)
        {
            WebSite result = new();

            WebClient client = new(); 

            /*
             * WebClient est obsolète mais propose des méthodes non asynchrones qu'on va utiliser pour
             * implémenter nos propres méthodes asynchrones
             */

            result.Url = url;

            result.Donnees = client.DownloadString(url);

            return result;
        }

        public static async Task<WebSite> DownloadAsync(string url)
        {
            WebSite result = new();

            WebClient client = new();

            /*
             * WebClient est obsolète mais propose des méthodes non asynchrones qu'on va utiliser pour
             * implémenter nos propres méthodes asynchrones
             */

            result.Url = url;

            result.Donnees = await client.DownloadStringTaskAsync(result.Url);

            return result;
        }
        public override string ToString()
        {
            return $"{Url} - taille {Donnees.Length}\n";
        }
    }
}
