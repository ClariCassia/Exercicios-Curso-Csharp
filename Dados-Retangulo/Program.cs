using System.Globalization;

namespace DadosRetangulo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Qual a largura do retângulo");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Qual a altura do retângulo");
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Resultados:");

            Console.WriteLine("Area = " + retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}