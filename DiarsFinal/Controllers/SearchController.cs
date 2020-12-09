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
        public IActionResult _Index(string busqueda)
        {
            var query = context.Posts.AsQueryable();
            var queryq = context.Tags.AsQueryable();

            if (!string.IsNullOrEmpty(busqueda))
            {
                query = query.Where(a => a.Titulo.Contains(busqueda)).Take(5);
                
            }
            if (!string.IsNullOrEmpty(busqueda))
            {
                queryq = queryq.Where(a => a.Nombre.Contains(busqueda)).Take(5);
                
            }
            ViewBag.que = queryq;
            query.ToList();
            return View(query);
        }

        [HttpGet]
        public IActionResult Tagsss()
        {
        
            return View(context.Tags.ToList());
        }
    }
}