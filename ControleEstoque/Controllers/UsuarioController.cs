using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControleEstoque.Models;

namespace ControleEstoque.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {

            Usuario usuario = new Usuario();
            usuario.Id = 15;
            usuario.Nome = "Lucas";
            usuario.Sobrenome = "Cardoso Soares";

            ViewBag.idUsuario = usuario.Id;
            ViewBag.nomeUsuario = usuario.Nome;
            ViewBag.sobrenomeUsuario = usuario.Sobrenome;

            return View();
        }



        public ActionResult Produtos()
        {

            return View();
        }

    }
}