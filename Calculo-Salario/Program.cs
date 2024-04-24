using System.Globalization;

namespace Calculo_Salario
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Dados atualizados:{funcionario}");

            Console.Write("Digite a porcentagem para aumentar: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine($"Dados atualizados:{funcionario}");
        }
    }
}