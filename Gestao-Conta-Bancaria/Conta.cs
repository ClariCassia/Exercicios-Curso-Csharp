using System.Globalization;

namespace Gestao_Conta_Bancaria
{
    internal class Conta
    {
        public readonly double NumeroConta;
        public string Titular { get; set; }

        public double Saldo { get; private set; }

        public Conta(double numeroConta, string nome)
        {
            NumeroConta = numeroConta;
            Titular = nome;
        }

        public Conta(double numeroConta, string titular, double depositoInicial) : this(numeroConta, titular)
        {
            Depositar(depositoInicial);
        }

        public void Depositar(double valorDeposito)
        {
            Saldo += valorDeposito;
        }

        public double Sacar(double valorSaque)
        {
            double taxaSaque = 5.0;
            if (Saldo >= valorSaque + taxaSaque)
            {
                Saldo -= (valorSaque + taxaSaque);
                return Saldo;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
                Console.WriteLine();

                return 0;
            }
        }

        public override string ToString()
        {
            return ($"Conta: {NumeroConta}, Titular: {Titular} Saldo: R${Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}