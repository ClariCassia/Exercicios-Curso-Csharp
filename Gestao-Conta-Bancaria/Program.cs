using System.Globalization;

namespace Gestao_Conta_Bancaria
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Conta conta1;

            Console.Write("Digite o numero da conta: ");
            double numeroConta = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o nome do titular kda conta: ");
            Console.Write("Digite o nome do titular kda conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");

            char resposta = char.Parse(Console.ReadLine());

            double depositoInicial = 0;

            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                depositoInicial = double.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);
                conta1 = new Conta(numeroConta, titular, depositoInicial);
            }
            else
            {
                conta1 = new Conta(numeroConta, titular);
            }

            Console.WriteLine(conta1);

            Console.Write("Entre com o valor do depósito: ");

            conta1.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine(conta1);

            Console.Write("Entre um valor para saque: ");

            conta1.Sacar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine(conta1);
        }
    }
}