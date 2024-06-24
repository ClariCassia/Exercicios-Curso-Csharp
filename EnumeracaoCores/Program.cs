using System.Security.AccessControl;
using static EnumeracaoCores.EnumCores;

namespace EnumeracaoCores
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Selecione a cor desejada para seu veiculo: \n");

            Console.WriteLine("Digite 1 para branco");
            Console.WriteLine("Digite 2 para vermelho");
            Console.WriteLine("Digite 3 para preto");
            Console.WriteLine("Digite 4 para cinza");
            Console.WriteLine("Digite 5 para prata");
            Console.WriteLine("Digite 6 para azul \n");

            Console.Write("Digite a cor escolhida: ");

            int corEscolhida = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Carro carro1 = new(corEscolhida, "Ford");

            carro1.ExibirInfo("Ford");
            carro1.ExibirInfo("Fiat", corEscolhida);
        }

        private class Carro
        {
            public int Cor;
            public string Nome;

            public Carro(int corEscolhida, string nome)
            {
                Cor = corEscolhida;
                Nome = nome;
            }

            public void ExibirInfo(string nome, int cor = 1)
            {
                var corEscolhida = (Cores)cor;
                Console.WriteLine($"Seu carro {nome} será da cor {corEscolhida} ");
            }
        }
    }
}