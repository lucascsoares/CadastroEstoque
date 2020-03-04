using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControleEstoque.Models;

namespace ControleEstoque.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            Produto produto = new Produto();
         //   IList<Produto> produtos = dao      Comportamento do dao para alimentar a lista.

            ViewBag.idProduto = produto.Id;
            ViewBag.nomeProduto = produto.Nome;
            ViewBag.precoProduto = produto.Preco;

            return View();
        }
    }
}