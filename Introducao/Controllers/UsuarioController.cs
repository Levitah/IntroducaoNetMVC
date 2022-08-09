using Introducao.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            Usuario usuario = new Usuario();
            return View(usuario);
        }

        public ActionResult Usuario(Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.Nome))
            {
                ModelState.AddModelError("Nome", "O campo nome é obrigatório");
            }

            if (usuario.Senha != usuario.ConfirmarSenha)
            {
                ModelState.AddModelError("", "As senhas são diferentes");
            }

            if (ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }

            return View(usuario);
        }

        [HttpPost]
        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }

        public ActionResult LoginUnico(string login)
        {
            var bdExemplo = new Collection<string>
            {
                "Hugo",
                "Freitas",
                "Paula"
            };

            return Json(bdExemplo.All(x => x.ToLower() != login));
        }
    }
}