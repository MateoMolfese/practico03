namespace Ejercicio03Practico03.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var palabra = "Arko";
            if (EsValida(palabra))
            {
                var cantidadVocales = ContarVocales(palabra);
                var cantidadConsonantes = ContarConsonantes(palabra);
                Console.WriteLine($"{palabra} tiene {cantidadVocales} vocales");
                Console.WriteLine($"{palabra} tiene {cantidadConsonantes} consonantes");

            }
        }

        private static int ContarConsonantes(string palabra)
        {
            return palabra.Length - ContarVocales(palabra);
        }

        private static int ContarVocales(string palabra)
        {
            int cantidad = 0;
            foreach (char c in palabra.ToLower())
            {
                if (EsVocal(c))
                {
                    cantidad++;
                }
            }
            return cantidad;
        }

        private static bool EsVocal(char c)
        {
            return "aeiou".Contains(c);
        }

        private static bool EsValida(string palabra)
        {
            return palabra.Length >= 3;
        }
    }
}