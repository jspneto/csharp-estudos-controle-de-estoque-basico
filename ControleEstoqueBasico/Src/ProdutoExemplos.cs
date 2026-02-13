using System;
using System.Globalization;

namespace ControleEstoqueBasico.Src;

static class ProdutoExemplos
{
    static public void ExemploGeral()
    {
        Produto produto = ProdutoAuxiliares.CriarProduto();
        Console.WriteLine(produto.ToString());

        Console.WriteLine();
        ProdutoAuxiliares.AdicionarUnidades(produto);
        Console.WriteLine(produto.ToString());

        Console.WriteLine();
        ProdutoAuxiliares.RemoverUnidades(produto);
        Console.WriteLine(produto.ToString());
    }

    static public void ExemploConstrutores()
    {
        Console.WriteLine("Exemplo de uso de construtor completo:");
        Console.WriteLine("Digite o nome: ");
        string nome = Console.ReadLine()!;
        Console.WriteLine("Digite o preço: ");
        double preco = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.WriteLine("Digite a quantidade em estoque: ");
        int quantidade = int.Parse(Console.ReadLine()!);
        Produto produto1 = new Produto(nome, preco, quantidade);
        Console.WriteLine(produto1.ToString());

        Console.WriteLine();
        Console.WriteLine("Exemplo de uso com construtor parcial (sobrecarga): ");
        Console.WriteLine("Digite o nome: ");
        nome = Console.ReadLine()!;
        Console.WriteLine("Digite o preço: ");
        preco = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Produto produto2 = new Produto(nome, preco);
        Console.WriteLine(produto2.ToString());
    }
}