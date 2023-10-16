using System;
using Avalonia.Controls;
using System.Linq;

namespace CalculatorQuest
{
    public class Calc
    {
        private string[] _signs = { "+", "-" , "x", "/", "%" };

        public Calc() {}

        public string Operator(string Input)

        {
            var processed = Input.Replace(".", ",");
            string[] parts = processed.Split(_signs, StringSplitOptions.RemoveEmptyEntries);
            //Console.Write(parts[0]);

            if (Input.StartsWith("-"))
            {
                parts[0] = "-" + parts[0];
            }



            if (parts.Length != 2)
            {
                return "Please enter an operation";
            }
            //declaration parties calcul
            double nombre1, nombre2;

            if (!double.TryParse(parts[0], out nombre1) || !double.TryParse(parts[1], out nombre2))
            {
                return "Not valid Number";
            }

            if (Input.Contains("+"))
            {
                return (nombre1 + nombre2).ToString();
            }
            if (Input.Contains("-"))
            {
                return (nombre1 - nombre2).ToString();
            }
            if (Input.Contains("x"))
            {
                return (nombre1 * nombre2).ToString();
            }
            if (Input.Contains("/"))
            {
                if (nombre1 == 0 || nombre2 == 0)
                {
                    return "Division by 0 is IMPOSSIBLE";
                }
                return (nombre1 / nombre2).ToString();
            }
            if (Input.Contains("%"))
            {
                return (nombre1 % nombre2).ToString();
            }

            return "Please enter an operation";
        }
    }

}