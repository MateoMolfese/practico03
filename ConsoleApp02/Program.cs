using System.Runtime.InteropServices;

namespace Ejercicio02Practico03.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tablas de Multiplicar");
            int nro;
            do
            {
                Console.Write("Ingrese un número a multiplicar:");
                if (int.TryParse(Console.ReadLine(), out nro))
                {
                    break;
                }
                Console.WriteLine("Número mal ingresado.. Reintentar");

            } while (true);
            for (int i = 1; i <= 12; i++)
            {
                var resultado = i * nro;
                Console.WriteLine($"{i}x{nro}={resultado}");
            }

        }
    }
}
