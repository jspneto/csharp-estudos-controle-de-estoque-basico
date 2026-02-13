using System;
using System.Globalization;

namespace ControleEstoqueBasico.Src;

class Produto
{
    private string _nome;
    public double Preco { get; private set; }
    public int Quantidade { get; private set; }

    public Produto(string nome, double preco)
    {
        _nome = nome;
        Preco = preco;
        Quantidade = 0;
    }

    public Produto(string nome, double preco, int quantidade) : this(nome, preco)
    {
        Quantidade = quantidade;
    }

    public string Nome
    {
        get
        {
            return _nome;
        }

        set
        {
            if (value != null && value.Length > 1)
            {
                _nome = value;
            }
        }
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
        return $"{_nome}, "
            + $"R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, "
            + $"{Quantidade} unidade(s), "
            + $"Valor em estoque: R$ {ValorEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
    }
}