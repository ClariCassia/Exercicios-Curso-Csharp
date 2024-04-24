using System.Globalization;

namespace ExerciciosCsharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto");

            Produto produto = new Produto();

            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {produto}");

            Console.WriteLine();

            Console.WriteLine("Digite o numeros de produtos a ser adicionado do estoque: ");
            int qtdAdicionado = int.Parse(Console.ReadLine());

            produto.AdicionaProduto(qtdAdicionado);

            Console.WriteLine($"Dados do produto: {produto}");

            Console.WriteLine();

            Console.WriteLine("Digite o numeros de produtos a serrem removidos do estoque: ");

            int qtdeRemovido = int.Parse(Console.ReadLine());

            produto.RemoveProduto(qtdeRemovido);

            Console.WriteLine($"Dados do produto: {produto}");
        }
    }
}