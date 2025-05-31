using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patentes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numero = rnd.Next(0,26 * 26 * 26 * 1000);

            int letras = numero / 1000;
            int numeros = numero % 1000;

            int letra1 = letras / (26 * 26);
            int letra2 = (letras / 26) % 26;
            int letra3 = letras % 26;

            char c1 = (char)('A' + letra1);
            char c2 = (char)('A' + letra2);
            char c3 = (char)('A' + letra3);

            string resultado = $"{c1}{c2}{c3}-{numeros:D3}";

            Console.WriteLine($"La Patente generada es: {resultado}");
        }
    }
}