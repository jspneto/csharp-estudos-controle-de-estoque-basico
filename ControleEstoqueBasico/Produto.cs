using System;
using System.Globalization;

namespace ControleEstoqueBasico;

class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public Produto(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public double ValorEstoque()
    {
        return Preco * Quantidade;
    }

    public void AdicionarProdutos(int quantidade)
    {
        Quantidade+=quantidade;
    }

    public void RemoverProdutos(int quantidade)
    {
        Quantidade-=quantidade;
    }

    public override string ToString()
    {
        return Nome
            + ", R$ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidade(s), Valor em estoque: R$ "
            + ValorEstoque().ToString("F2", CultureInfo.InvariantCulture)
            + ".";
    }
}