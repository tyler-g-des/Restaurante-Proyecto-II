using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PrimerParcial.Data;
using Restaurantee.Models;

namespace Restaurantee.Controllers
{
    public class usuariosController : Controller
    {
        private readonly DataContext _context;

        public usuariosController(DataContext context)
        {
            _context = context;
        }

        // GET: usuarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.usuario.ToListAsync());
        }

      /*  [HttpPost]
        public  IActionResult GetUsuarios([Bind("nombre","clave")] usuario usuario1)
        {
            var usuario = _context.usuario.Where(s => s.nombre == usuario1.nombre && s.clave == usuario1.clave);

            if (usuario.Any())
            {
                if (usuario.Where(s => s.nombre == usuario1.nombre && s.clave == usuario1.clave).Any())
                {
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    return Json(new { status = false, message = "usuario Incorrecto" });
                }
            }
            else 
            {
                return Json(new { status = false, message = "usuario Incorrecto" });

            }

        } */

        // GET: usuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.usuario
                .FirstOrDefaultAsync(m => m.idUsuario == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: usuarios/Create
        public IActionResult Create()
        {
            List<String> lista = new List<string>();
            lista.Add("administrador");
            lista.Add("cocinero");
            lista.Add("mesero");
            lista.Add("cajera");
            ViewData["rolesBien"] = new SelectList(lista.ToList());

            return View();
        }

        // POST: usuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idUsuario,nombre,apellido,telefono,direccion,clave,role,estado")] usuario usuario)
        {

            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: usuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            List<String> lista = new List<string>();
            lista.Add("administrador");
            lista.Add("cocinero");
            lista.Add("mesero");
            lista.Add("cajera");
            ViewData["rolesBien"] = new SelectList(lista.ToList());

            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.usuario.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        // POST: usuarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idUsuario,nombre,apellido,telefono,direccion,clave,role,estado")] usuario usuario)
        {
            if (id != usuario.idUsuario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!usuarioExists(usuario.idUsuario))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: usuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.usuario
                .FirstOrDefaultAsync(m => m.idUsuario == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuario = await _context.usuario.FindAsync(id);
            _context.usuario.Remove(usuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool usuarioExists(int id)
        {
            return _context.usuario.Any(e => e.idUsuario == id);
        }
    }
}
