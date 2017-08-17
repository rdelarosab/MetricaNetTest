using System;
using System.Linq;
using ConsoleMetricaApp.Exercises;
using CONSOLE = System.Console;

namespace ConsoleMetricaApp
{
    public class Program
    {
        public static readonly string[] ProcessOptions = { "1", "2", "3" };

        public const string ProblemOne = "Problema 01";
        public const string ProblemTwo = "Problema 02";
        public const string ProblemThree = "Problema 03";

        static void Main(string[] args)
        {
            var processKey = default(ConsoleKeyInfo);
            while (processKey.KeyChar.ToString().ToUpper() != "S")
            {
                ReadSelectProcess();
                processKey = CONSOLE.ReadKey();

                if (processKey.KeyChar.ToString().ToUpper() != "S" && ProcessOptions.Contains(processKey.KeyChar.ToString().ToUpper()))
                {
                    ExecuteMethods(processKey.KeyChar);
                }
            }

            ReleaseVariables();
        }

        static void ExecuteMethods(char process)
        {
            switch (process)
            {
                case '1':
                    new ChangeString();
                    break;
                case '2':
                    new CompleteRange();
                    break;
                case '3':
                    new MoneyParts();
                    break;
            }
        }
        
        static void ReadSelectProcess()
        {
            CONSOLE.Clear();
            CONSOLE.WriteLine("Escoger proceso: ");
            CONSOLE.WriteLine("- {0} (1)", ProblemOne);
            CONSOLE.WriteLine("- {0} (2)", ProblemTwo);
            CONSOLE.WriteLine("- {0} (3)", ProblemThree);
            CONSOLE.WriteLine("- Salir (S)");
            CONSOLE.Write("Ingresar opción: ");
        }
        
        static void ReleaseVariables()
        {
            GC.Collect();
        }
    }
}
