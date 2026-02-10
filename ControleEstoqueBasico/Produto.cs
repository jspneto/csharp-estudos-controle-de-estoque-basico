using System;

namespace ControleEstoqueBasico;

class Produto
{
    public string Nome = "Produto";
    public double Preco;
    public int Quantidade;

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
}