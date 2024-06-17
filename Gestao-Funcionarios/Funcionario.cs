using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Funcionarios
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Funcionario(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void SetSalary(double porcentagem)
        {
            Salary = CalculaAumento(porcentagem, Salary);
        }

        private static double CalculaAumento(double porcentagem, double salarioAtual)
        {
            return salarioAtual + (salarioAtual * (porcentagem / 100));
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}