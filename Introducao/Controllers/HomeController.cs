using Introducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEnumerable<Noticia> todasNoticias;

        public HomeController()
        {
            todasNoticias = new Noticia().TodasAsNoticias().OrderByDescending(x => x.Data);
        }

        public ActionResult Index()
        {
            var ultimasNoticias = todasNoticias.Take(3);
            var categorias = todasNoticias.Select(x => x.Categoria).Distinct().ToList();

            ViewBag.Categorias = categorias;

            return View(ultimasNoticias);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Teste()
        {
            return View();
        }

        public ActionResult Contatos()
        {
            Pessoa pessoa = new Pessoa()
            {
                Id = 1,
                Nome = "Lucas Sant'Anna",
                Tipo = 1
            };

            ViewData["Id"] = pessoa.Id;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Tipo"] = pessoa.Tipo;

            ViewBag.Id = pessoa.Id;
            ViewBag.Nome = pessoa.Nome;
            ViewBag.Tipo = pessoa.Tipo;

            return View();
        }

        public ActionResult NovoContato()
        {
            Pessoa pessoa = new Pessoa()
            {
                Id = 1,
                Nome = "Lucas Sant'Anna",
                Tipo = 1
            };

            return View(pessoa);
        }

        //[HttpPost]
        //public ActionResult Lista(int id, string nome, int tipo)
        //{
        //    ViewData["Id"] = id;
        //    ViewData["Nome"] = nome;
        //    ViewData["TIpo"] = tipo;

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Lista(FormCollection form)
        //{
        //    ViewData["Id"] = form["Id"];
        //    ViewData["Nome"] = form["Nome"];
        //    ViewData["TIpo"] = form["Tipo"];

        //    return View();
        //}

        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {
            //ViewData["Id"] = pessoa.Id;
            //ViewData["Nome"] = pessoa.Nome;
            //ViewData["TIpo"] = pessoa.Tipo;

            return View(pessoa);
        }
    }
}