using System.Runtime.Serialization;

namespace _05_Serializable_dll
{
    [Serializable]

    [DataContract] ///Pour serialization json
    public class CompteBancaire
    {
        [DataMember]
        public string Numero { get; set; } = String.Empty;
        [DataMember]
        public double Solde { get; set; }

        public static readonly string Banque = "Credit Lyonnais";

        public static int NbComptes { get; private set; }

        public CompteBancaire()
        {
            NbComptes++;
        }
        public CompteBancaire(string numero, double solde) : this()
        {
            Numero = numero;
            Solde = solde;
        }

        public override string ToString()
        {
            return $"Numéro : {Numero} - Solde :  {Solde}";
        }
    }
}

