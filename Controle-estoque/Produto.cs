using System.Globalization;

namespace ExerciciosCsharp
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionaProduto(int qtd)
        {
            Quantidade += qtd;
        }

        public void RemoveProduto(int qtd)
        {
            Quantidade -= qtd;
        }

        public override string ToString()
        {
            return $"{Nome}, R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, " +
                   $"unidades: {Quantidade}, Total: R$ {ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}