using System;

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
}