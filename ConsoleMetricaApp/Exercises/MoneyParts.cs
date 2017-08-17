using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using CONSOLE = System.Console;

namespace ConsoleMetricaApp.Exercises
{
    public class MoneyParts
    {
        public MoneyParts()
        {
            var textContinuar = "";
            while (!textContinuar.Equals("N"))
            {
                CONSOLE.Clear();
                CONSOLE.WriteLine("- Problema 03");
                CONSOLE.WriteLine("Combinaciones: 0.05, 0.1, 0.2, 0.5, 1, 2, 5, 10, 20, 50, 100, 200");
                CONSOLE.Write("Ingrese un número: ");

                var combinations = new[] { 0.05, 0.1, 0.2, 0.5, 1, 2, 5, 10, 20, 50, 100, 200 };
                var txtnumber = CONSOLE.ReadLine();
                double numberDbl;

                if (double.TryParse(txtnumber, out numberDbl))
                {
                    var response = Build(combinations, numberDbl, string.Empty).ToList();
                    CONSOLE.WriteLine("- Entrada: " + txtnumber);
                    CONSOLE.WriteLine("- Salida: ");
                    response.ForEach(i => CONSOLE.WriteLine("{0}\t", i));
                }
                else
                {
                    CONSOLE.WriteLine("Lo sentimos, debes ingresar solo números.");
                }

                CONSOLE.Write("¿Desea realizar otra consulta? (S/N)");
                textContinuar = CONSOLE.ReadLine().ToUpper();
            }
        }

        public static IEnumerable<string> Build(double[] combinations, double inputValue, string rowsTemp)
        {
            for (int i = 0; i < combinations.Length; i++)
            {
                double difference = Math.Round(inputValue - combinations[i], 2);
                string rowsFinal = !string.IsNullOrEmpty(rowsTemp) ? combinations[i] + ", " + rowsTemp : combinations[i].ToString(CultureInfo.InvariantCulture);
                if (difference == 0.00)
                {
                    yield return "[ " + rowsFinal + " ]";
                }
                else if(difference > 0)
                {
                    double[] subCombinations = combinations.Where(n => n <= inputValue).ToArray();
                    if (subCombinations.Length > 0)
                    {
                        foreach (string s in Build(subCombinations, difference, rowsFinal))
                        {
                            yield return s;
                        }
                    }
                }
            }
        }
    }
}