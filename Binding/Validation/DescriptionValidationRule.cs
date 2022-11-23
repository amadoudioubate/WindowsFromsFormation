using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Binding.Validation
{
    internal class DescriptionValidationRule : ValidationRule
    {

        public int Min { get; set; }

        public int Max { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if(value == null)
            {
                return new ValidationResult(false, "Vous devez saisir une description !");
            }

            string desc = (string)value;

            if (String.IsNullOrEmpty(desc))
            {
                return new ValidationResult(false, "Vous devez saisir une description !");
            }

            if(desc.Length < Min || desc.Length > Max)
            {
                return new ValidationResult(false, $"Vous devez saisir une description entre {Min} et {Max} caractères !");
            }

            return new ValidationResult(true, null);
        }
    }
}
