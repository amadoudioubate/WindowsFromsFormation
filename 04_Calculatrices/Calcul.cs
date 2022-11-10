
using MoonSharp.Interpreter;

namespace _04_Calculatrices
{
    public class Calcul
    {
        public string Expression { get; set; }

        public Calcul(string expression)
        {
            Expression = expression;
        }   

        public double GetResult()
        {

            return Script.RunString($"return {Expression}").Number;
        }
    }
}
