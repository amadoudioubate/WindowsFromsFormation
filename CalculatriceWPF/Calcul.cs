using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoonSharp.Interpreter;

namespace CalculatriceWPF
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
