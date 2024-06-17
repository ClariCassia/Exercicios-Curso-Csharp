using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes
{
    public class Carro(string? modelo, string? montadora, string? marca, int ano, int potencia)
    {
        public string? Modelo = modelo;
        public string? Montadora = montadora;
        public string? Marca = marca;
        public int Ano = ano;
        public int Potencia = potencia;

        public static void Acelerar(string marca)
        {
            Console.WriteLine($"Acelerando o {marca}..!!");
        }

        public static void PassandoDados(Carro car)
        {
            Console.WriteLine($"Modelo: {car.Modelo}");
            Console.WriteLine($"Montadora: {car.Montadora}");
            Console.WriteLine($"Ano: {car.Ano}");
            Console.WriteLine($"Potência: {car.Potencia}");
        }

        public void Exibir()
        {
            Console.WriteLine();
            PassandoDados(this);
        }
    }
}