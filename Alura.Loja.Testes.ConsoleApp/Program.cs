﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //GravarUsandoAdoNet();
            GravarUsandoEntity();
        }

        private static void GravarUsandoEntity()
        {
            Produto p = new Produto();
            p.Nome = "Jogos Vorazes em Chamas";
            p.Categoria = "Livros";
            p.Preco = 20.89;

            Produto p2 = new Produto();
            p2.Nome = "Matrix";
            p2.Categoria = "Livros";
            p2.Preco = 36.50;

            using (var contexto = new LojaContext())
            {
                contexto.Produtos.AddRange(p, p2);
                contexto.SaveChanges();
            }
        }

        private static void GravarUsandoAdoNet()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var repo = new ProdutoDAO())
            {
                repo.Adicionar(p);
            }
        }
    }
}
