using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DiarsFinal.BD;
using DiarsFinal.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;

namespace DiarsFinal.Controllers
{
    public class PostController : Controller
    {
        private SimuladorContext context = new SimuladorContext();
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public IActionResult _IndexB()
        {
            var query=context.Posts.ToList();
            ViewBag.posts = query;
            return View();
        }

        public IActionResult VerDetalle(int id)
        {
            ViewBag.tag = context.Tags.Where(a => a.Id == id).ToList();
            ViewBag.posts = context.Posts.Where(a => a.Id == id).ToList();
            ViewBag.tagsDelPost = context.Tags.ToList();
            ViewBag.detalle = context.DetallePostTages.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Crear()
        {
            var categorias = context.Tags.ToList();
            ViewBag.cat = categorias;
            return View(new Post());
        }

        [HttpPost]
        public IActionResult Crear(Post post, List<int> tags)
        {
            var categorias = context.Tags.ToList();
            ViewBag.cat = categorias;
           
             if (ModelState.IsValid) {
                var fechita = DateTime.Now;
                post.Fecha = fechita;
                context.Add(post);
                context.SaveChanges();
                //Agregar tags
                var postss = context.Posts.First(o=>o.Titulo==post.Titulo);
               
                foreach (var tagc in tags) {
                    var detalle = new DetallePostTags(postss.Id,tagc);
                    context.Add(detalle);
                    context.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }

        
        public IActionResult Eliminar(int ID)
        {
            var eliminarPost = context.Posts.First(a => a.Id == ID);
            context.Posts.Remove(eliminarPost);
            context.SaveChanges();
            return RedirectToAction("Index","Post");
        }

       
        [HttpGet]
        public IActionResult Editar(int id)
        {

            var post = context.Posts.Where(o => o.Id == id).FirstOrDefault();

            ViewBag.Id = post.Id;
            ViewBag.Post = post;
            ViewBag.Contenido = post.Contenido;

            return View(post);
        }


        [HttpPost]
        public IActionResult Editar( Post post )
        {

            var posts = context.Posts.Where(o => o.Id == post.Id).FirstOrDefault();

            posts.Titulo = post.Titulo;
            posts.Fecha = DateTime.Now;
            posts.Contenido = post.Contenido;

            context.SaveChanges();

            return RedirectToAction( "Index" );
        }


        public IActionResult Tags(int Id)
        {

            var tags= context.Tags.ToList();
            var post= context.Posts.ToList();
            ViewBag.Detalles = context.DetallePostTages.ToList();

            ViewBag.Tags = tags;
            ViewBag.Post = post;
            return View();
        }

    }
}