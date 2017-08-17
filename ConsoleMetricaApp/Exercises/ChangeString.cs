using System.Text;
using CONSOLE = System.Console;

namespace ConsoleMetricaApp.Exercises
{
    public class ChangeString
    {
        public ChangeString()
        {
            var textContinuar = "";
            while (!textContinuar.Equals("N"))
            {
                CONSOLE.Clear();
                CONSOLE.WriteLine("- Problema 01");
                CONSOLE.WriteLine("Ingrese una cadena: ");
                CONSOLE.Write("Entrada: ");
                var textRead = CONSOLE.ReadLine();
                Build(textRead);
                CONSOLE.Write("¿Desea realizar otra consulta? (S/N)");
                textContinuar = CONSOLE.ReadLine().ToUpper();
            }
        }

        public void Build(string textRead)
        {
            var textResult = new StringBuilder();

            foreach (var item in textRead)
            {
                if (char.IsLetter(item))
                {
                    if (item == 'z')
                        textResult.Append('a');
                    else if (item == 'Z')
                        textResult.Append('Z');
                    else
                        textResult.Append((char)((item) + 1));
                }
                else
                {
                    textResult.Append(item);
                }
            }

            CONSOLE.WriteLine("Salida: " + textResult);
        }
    }
}
