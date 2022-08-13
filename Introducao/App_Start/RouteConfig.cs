using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Introducao
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Todas as Notícias",
                url: "news/" ,
                defaults: new { controller = "Noticia", action = "MostrarTodas" }
            );

            routes.MapRoute(
                name: "Categoria Específica",
                url: "news/{categoria}",
                defaults: new { controller = "Noticia", action = "MostrarCategoria" }
            );

            routes.MapRoute(
                name: "Motrar Notícia",
                url: "news/{categoria}/{titulo}-{id}",
                defaults: new { controller = "Noticia", action = "MostrarNoticia" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Area", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
