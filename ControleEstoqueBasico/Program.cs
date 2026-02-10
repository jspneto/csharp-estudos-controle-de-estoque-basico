using System;
using System.Globalization;

namespace ControleEstoqueBasico;

class Program
{
    static void Main(string[] args)
    {
        Produto produto = new Produto();
        Console.WriteLine("Entre com os dados do produto:");
        Console.Write("Nome: ");
        produto.Nome = Console.ReadLine()!;
        Console.Write("Preço: ");
        produto.Preco = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Quantidade em estoque: ");
        produto.Quantidade = int.Parse(Console.ReadLine()!);

        Console.WriteLine("");
        Console.WriteLine("Dados do produto: " + produto.ToString());

        Console.WriteLine("");
        Console.Write("Digite o número de unidades a ser adicionada ao estoque: ");
        int quantidade = int.Parse(Console.ReadLine()!);
        produto.AdicionarProdutos(quantidade);
        Console.WriteLine("Dados atualizados: " + produto.ToString());

        Console.WriteLine("");
        Console.Write("Digite o número de unidades a ser removida do estoque: ");
        quantidade = int.Parse(Console.ReadLine()!);
        produto.RemoverProdutos(quantidade);
        Console.WriteLine("Dados atualizados: " + produto.ToString());
    }
}
