using System;
using System.Globalization;

namespace ControleEstoqueBasico;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entre com os dados do produto:");
        Console.Write("Nome: ");
        string nome = Console.ReadLine()!;
        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Quantidade em estoque: ");
        int quantidade = int.Parse(Console.ReadLine()!);

        Produto produto = new Produto(nome, preco, quantidade);

        Console.WriteLine("");
        Console.WriteLine("Dados do produto: " + produto.ToString());

        Console.WriteLine("");
        Console.Write("Digite o número de unidades a ser adicionada ao estoque: ");
        int quantidadeAlterada = int.Parse(Console.ReadLine()!);
        produto.AdicionarProdutos(quantidadeAlterada);
        Console.WriteLine("Dados atualizados: " + produto.ToString());

        Console.WriteLine("");
        Console.Write("Digite o número de unidades a ser removida do estoque: ");
        quantidadeAlterada = int.Parse(Console.ReadLine()!);
        produto.RemoverProdutos(quantidadeAlterada);
        Console.WriteLine("Dados atualizados: " + produto.ToString());
    }
}
