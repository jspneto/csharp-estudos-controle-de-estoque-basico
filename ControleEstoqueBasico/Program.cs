using System;
using System.Globalization;

namespace ControleEstoqueBasico;

class Program
{
    static void Main(string[] args)
    {
        Produto produto = CriarProduto();
        Console.WriteLine(produto.ToString());

        Console.WriteLine();
        AdicionarUnidades(produto);
        Console.WriteLine(produto.ToString());

        Console.WriteLine();
        RemoverUnidades(produto);
        Console.WriteLine(produto.ToString());
    }

    static Produto CriarProduto()
    {
        Console.WriteLine("Entre com os dados do produto: ");
        Console.Write("Nome: ");
        string nome = Console.ReadLine()!;
        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Número de unidades: ");
        int quantidade = int.Parse(Console.ReadLine()!);

        Produto produto = new Produto(nome, preco, quantidade);

        return produto;
    }

    static void AdicionarUnidades(Produto produto)
    {
        Console.WriteLine("Digite o número de unidades que deseja adicionar: ");
        int quantidade = int.Parse(Console.ReadLine()!);
        produto.AdicionarProdutos(quantidade);
    }

    static void RemoverUnidades(Produto produto)
    {
        Console.WriteLine("Digite o número de unidades que deseja remover: ");
        int quantidade = int.Parse(Console.ReadLine()!);
        produto.RemoverProdutos(quantidade);
    }
}
