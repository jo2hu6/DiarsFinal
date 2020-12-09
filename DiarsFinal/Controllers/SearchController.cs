using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiarsFinal.BD;
using Microsoft.AspNetCore.Mvc;

namespace DiarsFinal.Controllers
{
    public class SearchController : Controller
    {
        private SimuladorContext context = new SimuladorContext();
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult _IndexB(string busqueda)
        {
            var query = context.Posts.AsQueryable();
            if (!string.IsNullOrEmpty(busqueda))
            {
                query = query.Where(a => a.Titulo.Contains(busqueda));

            }
            ViewBag.posts= query.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult _Index(string busqueda, int? tag = null)
        {
            var query = context.Posts.AsQueryable();
            var queryq = context.Tags.AsQueryable();
            if (tag.HasValue)
            {
                query = query.Where(a => a.DetallePostTags.Any(y => y.IdTags == tag));
            }


            if (!string.IsNullOrEmpty(busqueda))
            {
                busqueda = busqueda.ToLower().Trim();
                query = query.Where(a => a.Titulo.ToLower().Trim().Contains(busqueda));
            }
            if (!string.IsNullOrEmpty(busqueda))
            {
                busqueda = busqueda.ToLower().Trim();
                queryq = queryq.Where(a => a.Nombre.ToLower().Trim().Contains(busqueda)).Take(10);
            }

            ViewBag.que = queryq;
            query.ToList();
            return View(query.Take(10));
        }

        [HttpGet]
        public IActionResult Tagsss()
        {
        
            return View(context.Tags.ToList());
        }
    }
}