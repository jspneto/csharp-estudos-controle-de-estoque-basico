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

        Console.Write("Dados do produto: ");
        ExibirDados(produto);

        Console.WriteLine("");
        Console.WriteLine("Adicionando 5 produtos...");
        produto.AdicionarProdutos(5);
        Console.Write("Dados atualizados: ");
        ExibirDados(produto);

        Console.WriteLine("");
        Console.WriteLine("Removendo 2 produtos...");
        produto.RemoverProdutos(2);
        Console.Write("Dados atualizados: ");
        ExibirDados(produto);
    }

    static void ExibirDados(Produto produto)
    {
        Console.Write(produto.Nome + ", R$ ");
        Console.Write(produto.Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " );
        Console.Write(produto.Quantidade + " unidade(s), Valor em estoque: R$ ");
        Console.WriteLine(produto.ValorEstoque().ToString("F2", CultureInfo.InvariantCulture) + ".");
    }
}
