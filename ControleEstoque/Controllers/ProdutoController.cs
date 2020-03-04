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

            produto.Id = 15;
            produto.Nome = "Notebook";
            produto.Preco = 3500;

            ViewBag.idProduto = produto.Id;
            ViewBag.nomeProduto = produto.Nome;
            ViewBag.precoProduto = produto.Preco;

            return View();
        }
    }
}