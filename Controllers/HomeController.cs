using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrimerParcial.Data;
using PrimerParcial.Models;
using Restaurantee.Models;

namespace PrimerParcial.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;

        public HomeController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult GetUsuarios([Bind("nombre", "clave")] usuario usuario1)
        {
            var usuario = _context.usuario.Where(s => s.nombre == usuario1.nombre && s.clave == usuario1.clave);

            if (usuario.Any())
            {
                if (usuario.Where(s => s.nombre == usuario1.nombre && s.clave == usuario1.clave).Any())
                {
                    var usuarioEncontrado = _context.usuario
                        .FirstOrDefault(o => o.nombre == usuario1.nombre && o.clave == usuario1.clave);
                    usuarioEncontrado.estado = true;

                    _context.Update(usuarioEncontrado);
                    _context.SaveChanges();

                    return RedirectToAction("Index", "Home");

                }
                else
                {
                    usuario1.estado = false;
                    _context.Update(usuario1);
                    _context.SaveChangesAsync();
                    return RedirectToAction("login");
                }
            }
            else
            {
                usuario1.estado = false;
                _context.Update(usuario1);
                _context.SaveChangesAsync();
                return RedirectToAction("login");
            }

        }

        public async Task<IActionResult> logout()
        {
            var usuarioEncontrado = _context.usuario
                        .FirstOrDefault(o => o.estado == true);
            usuarioEncontrado.estado = false;

            _context.Update(usuarioEncontrado);
            _context.SaveChanges();

            return RedirectToAction("login", "Home");
        }


        [HttpPost]
        public IActionResult GetRoles(String NombreUsuario, String Clave)
        {
            var usuario = _context.usuario.Where(s => s.estado == true);

            if (usuario.Any())
            {
                if (usuario.Where(s => s.estado == true).Any())
                {
                    string texto = usuario.FirstOrDefault().role.ToString();
                    return Json(new { role = texto });
                }
                else
                {
                    string texto = usuario.FirstOrDefault().role.ToString();
                    return Json(new { role = texto });
                }
            }
            else
            {

                return Json(new { role = "ss" });
            }

        }

        public IActionResult finalizarOrden(int idMesaBusqueda1)
        {
            var pedidoEncontrado = _context.pedidos
                       .FirstOrDefault(o => o.estado == true && o.idMesa == idMesaBusqueda1);
            pedidoEncontrado.estado = true;

            return Json(new {estado = true, id= pedidoEncontrado.idPedido });
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
