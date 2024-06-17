using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Gestao_Funcionarios
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Quantos funcionários serão registrados: ");

            int qtde = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 1; i <= qtde; i++)
            {
                Console.WriteLine($"Emplyoee:{i}");
                Console.WriteLine();

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();

                funcionarios.Add(new Funcionario(id, name, salary));
            }

            Console.Write("Digite o id: ");

            int resposta = int.Parse(Console.ReadLine());

            Console.Write("De quantos por cento sera o aumento: ");

            double porcentagemAumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (funcionarios.Exists(o => o.Id == resposta)) // Se existe
                funcionarios.Find(o => o.Id == resposta).SetSalary(porcentagemAumento); // Busca
            else
                Console.WriteLine("Funcionario não encontrado");

            #region Teste 1

            //foreach (Funcionario func in funcionarios)
            //{
            //    if (func.Id == resposta)
            //    {
            //        func.SetSalary(porcentagemAumento);
            //    }

            //    Console.WriteLine(func.ToString());
            //}

            #endregion Teste 1

            funcionarios.ForEach(o => Console.WriteLine(o.ToString()));
        }
    }
}