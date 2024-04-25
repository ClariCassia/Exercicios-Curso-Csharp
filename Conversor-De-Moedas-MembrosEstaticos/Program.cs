using System.Globalization;

namespace Conversor_De_Moedas_MembrosEstaticos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dolar? ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dolares você vai comprar? ");
            double qtdAcomprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pagamentoEmReais = ConversorDeMoeda.DolarParaReal(qtdAcomprar, cotacaoDolar);

            Console.Write($"Valor a ser pago em reais: {pagamentoEmReais.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        private class ConversorDeMoeda
        {
            public static double Iof = 6.0;

            public static double DolarParaReal(double quantia, double cotacao)
            {
                double total = quantia * cotacao;
                return total + total * Iof / 100.0;
            }
        }
    }
}