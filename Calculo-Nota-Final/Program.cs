using System.Globalization;

namespace Calculo_Nota_Final
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Nota 1º trimestre: ");
            aluno.NotaTrimestre1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nota 2º trimestre: ");
            aluno.NotaTrimestre2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nota 3º trimestre: ");
            aluno.NotaTrimestre3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double notaFinal = aluno.CalculaNotaFinal();
            string resultado = aluno.VerificaAprovacao(notaFinal);

            Console.WriteLine($"Nota Final: {notaFinal.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Status do Aluno: {resultado}");
        }
    }
}