using Introducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class NoticiaController : Controller
    {
        IEnumerable<Noticia> todasNoticias;
        public NoticiaController()
        {
            todasNoticias = new Noticia().TodasAsNoticias().OrderByDescending(x => x.Data);
        }

        // GET: Noticia
        public ActionResult Index()
        {
            var ultimasNoticias = todasNoticias.Take(3);
            var categorias = todasNoticias.Select(x => x.Categoria).Distinct().ToList();

            ViewBag.Categorias = categorias;

            return View(ultimasNoticias);
        }

        public ActionResult MostrarNoticia(int id, string titulo, string categoria)
        {
            return View(new Noticia().BuscarPorId(id));
        }

        public ActionResult MostrarTodas()
        {
            var categorias = todasNoticias.Select(x => x.Categoria).Distinct().ToList();
            ViewBag.Categorias = categorias;
            return View(todasNoticias);
        }

        public ActionResult MostrarCategoria(string categoria)
        {
            ViewBag.Categoria = categoria;
            return View(new Noticia().BuscarPorCategoria(categoria));
        }
    }
}