using System;
using System.Globalization;

namespace ControleEstoqueBasico;

class Program
{
    static void Main(string[] args)
    {
        Produto produto = new Produto();
        produto.Nome = "Exemplo";
        produto.Preco = 10.00;
        produto.Quantidade = 0;

        ExibirDados(produto);

        Console.WriteLine("");
        Console.WriteLine("Adicionando 5 produtos...");
        produto.AdicionarProdutos(5);
        ExibirDados(produto);

        Console.WriteLine("");
        Console.WriteLine("Removendo 2 produtos...");
        produto.RemoverProdutos(2);
        ExibirDados(produto);
    }

    static void ExibirDados(Produto produto)
    {
        Console.WriteLine("Nome do produto: " + produto.Nome + ".");
        Console.WriteLine("Preço do produto: R$ " + produto.Preco.ToString("F2", CultureInfo.InvariantCulture) + ".");
        Console.WriteLine("Quantidade em estoque: " + produto.Quantidade + " unidade(s).");
        Console.WriteLine("Valor do Estoque: R$ " + produto.ValorEstoque().ToString("F2", CultureInfo.InvariantCulture) + ".");
    }
}
