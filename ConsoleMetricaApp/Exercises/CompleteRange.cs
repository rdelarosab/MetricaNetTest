using System.Collections.Generic;
using System.Linq;
using System.Text;
using CONSOLE = System.Console;

namespace ConsoleMetricaApp.Exercises
{
    public class CompleteRange
    {
        public CompleteRange()
        {
            var textContinuar = "";
            while (!textContinuar.Equals("N"))
            {
                CONSOLE.Clear();
                CONSOLE.WriteLine("- Problema 02");
                CONSOLE.WriteLine("Ingrese el tamaño del arreglo: ");
                CONSOLE.Write("Tamaño: ");

                var textLength = CONSOLE.ReadLine();
                int lengthList;

                if (int.TryParse(textLength, out lengthList))
                {
                    var lstNumbers = new List<int>();
                    var higher = 0;

                    for (int i = 0; i < lengthList; i++)
                    {
                        CONSOLE.Write("Posición " + i + ": ");
                        var valueTextTemp = CONSOLE.ReadLine();

                        int valueIntTemp;

                        if (int.TryParse(valueTextTemp, out valueIntTemp))
                        {
                            if (i == 0)
                            {
                                higher = valueIntTemp;
                            }
                            else
                            {
                                if (valueIntTemp > higher)
                                {
                                    higher = valueIntTemp;
                                }
                            }

                            lstNumbers.Add(valueIntTemp);
                        }
                        else
                        {
                            lstNumbers.Add(1);
                        }
                    }

                    Build(lstNumbers, higher);
                }
                else
                {
                    CONSOLE.WriteLine("Lo sentimos, debes ingresar solo números.");
                }

                CONSOLE.Write("¿Desea realizar otra consulta? (S/N)");
                textContinuar = CONSOLE.ReadLine().ToUpper();
            }
        }

        public void Build(List<int> collection, int higher)
        {
            var finalResult = Enumerable.Range(1, higher).ToList();
            CONSOLE.WriteLine("- Entrada: ");
            collection.ForEach(i => CONSOLE.WriteLine("{0}\t", i));
            CONSOLE.WriteLine("- Salida: ");
            finalResult.ForEach(i => CONSOLE.WriteLine("{0}\t", i));
        }
    }
}
