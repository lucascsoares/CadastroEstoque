using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleEstoque.Models
{
    public class Process
    {

        private static void gravarUsandoEntity()
        {
            Produto p = new Produto();

            p.Nome = "Monitor 24 75hz ACER";
            p.Preco = 699.99;

            using (var repo = new ProdutoDAO())   // criar arquivo DAO para vincular com banco;
            {
                repo.Adicionar(p);
            }
        }

    }
}