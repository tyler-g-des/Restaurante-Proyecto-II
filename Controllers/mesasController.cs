using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PrimerParcial.Data;
using Restaurantee.Models;

namespace Restaurantee.Controllers
{
    public class mesasController : Controller
    {
        private readonly DataContext _context;

        public mesasController(DataContext context)
        {
            _context = context;
        }

        // GET: mesas
        public async Task<IActionResult> Index()
        {
            return View(await _context.mesas.ToListAsync());
        }

        // GET: mesas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mesa = await _context.mesas
                .FirstOrDefaultAsync(m => m.idMesa == id);
            if (mesa == null)
            {
                return NotFound();
            }

            return View(mesa);
        }

        #region mesas
        [HttpPost]
        public IActionResult GetStatusMesa1(int idMesaBusqueda1)
        {
            var mesa1 = _context.mesas.Where(s => s.idMesa == idMesaBusqueda1);
            if (mesa1.Where(s =>  s.idMesa == idMesaBusqueda1 && s.estado == "Libre").Any())
            {
                return Json(new { mesa1 = "Libre" });
            }
            else if(mesa1.Where(s => s.idMesa == idMesaBusqueda1 && s.estado == "Ocupada").Any())
            {
                return Json(new { mesa1 = "Ocupada" });
            }
            else if(mesa1.Where(s => s.idMesa == idMesaBusqueda1 && s.estado == "Atendida").Any())
            {
                return Json(new { mesa1 = "Atendida" });
            }
            return Json(new { mesa1 = "Libre" });


        }

        [HttpPost]
        public IActionResult GetStatusMesa2(int idMesaBusqueda2)
        {
            var mesa2 = _context.mesas.Where(s => s.idMesa == idMesaBusqueda2);
            if (mesa2.Where(s => s.idMesa == idMesaBusqueda2 && s.estado == "Libre").Any())
            {
                return Json(new { mesa2 = "Libre" });
            }
            else if (mesa2.Where(s => s.idMesa == idMesaBusqueda2 && s.estado == "Ocupada").Any())
            {
                return Json(new { mesa2 = "Ocupada" });
            }
            else if (mesa2.Where(s => s.idMesa == idMesaBusqueda2 && s.estado == "Atendida").Any())
            {
                return Json(new { mesa2 = "Atendida" });
            }
            return Json(new { mesa2 = "Libre" });
        }

        [HttpPost]
        public IActionResult GetStatusMesa3(int idMesaBusqueda3)
        {
            var mesa3 = _context.mesas.Where(s => s.idMesa == idMesaBusqueda3);
            if (mesa3.Where(s => s.idMesa == idMesaBusqueda3 && s.estado == "Libre").Any())
            {
                return Json(new { mesa3 = "Libre" });
            }
            else if (mesa3.Where(s => s.idMesa == idMesaBusqueda3 && s.estado == "Ocupada").Any())
            {
                return Json(new { mesa3 = "Ocupada" });
            }
            else if (mesa3.Where(s => s.idMesa == idMesaBusqueda3 && s.estado == "Atendida").Any())
            {
                return Json(new { mesa3 = "Atendida" });
            }
            return Json(new { mesa3 = "Libre" });
        }

        [HttpPost]
        public IActionResult GetStatusMesa4(int idMesaBusqueda4)
        {
            var mesa4 = _context.mesas.Where(s => s.idMesa == idMesaBusqueda4);
            if (mesa4.Where(s => s.idMesa == idMesaBusqueda4 && s.estado == "Libre").Any())
            {
                return Json(new { mesa4 = "Libre" });
            }
            else if (mesa4.Where(s => s.idMesa == idMesaBusqueda4 && s.estado == "Ocupada").Any())
            {
                return Json(new { mesa4 = "Ocupada" });
            }
            else if (mesa4.Where(s => s.idMesa == idMesaBusqueda4 && s.estado == "Atendida").Any())
            {
                return Json(new { mesa4 = "Atendida" });
            }
            return Json(new { mesa4 = "Libre" });
        }

        [HttpPost]
        public IActionResult GetStatusMesa5(int idMesaBusqueda5)
        {
            var mesa5 = _context.mesas.Where(s => s.idMesa == idMesaBusqueda5);
            if (mesa5.Where(s => s.idMesa == idMesaBusqueda5 && s.estado == "Libre").Any())
            {
                return Json(new { mesa5 = "Libre" });
            }
            else if (mesa5.Where(s => s.idMesa == idMesaBusqueda5 && s.estado == "Ocupada").Any())
            {
                return Json(new { mesa5 = "Ocupada" });
            }
            else if (mesa5.Where(s => s.idMesa == idMesaBusqueda5 && s.estado == "Atendida").Any())
            {
                return Json(new { mesa5 = "Atendida" });
            }
            return Json(new { mesa5 = "Libre" });
        }

        [HttpPost]
        public IActionResult GetStatusMesa6(int idMesaBusqueda6)
        {
            var mesa6 = _context.mesas.Where(s => s.idMesa == idMesaBusqueda6);
            if (mesa6.Where(s => s.idMesa == idMesaBusqueda6 && s.estado == "Libre").Any())
            {
                return Json(new { mesa6 = "Libre" });
            }
            else if (mesa6.Where(s => s.idMesa == idMesaBusqueda6 && s.estado == "Ocupada").Any())
            {
                return Json(new { mesa6 = "Ocupada" });
            }
            else if (mesa6.Where(s => s.idMesa == idMesaBusqueda6 && s.estado == "Atendida").Any())
            {
                return Json(new { mesa6 = "Atendida" });
            }
            return Json(new { mesa6 = "Libre" });
        }

        [HttpPost]
        public IActionResult GetStatusMesa7(int idMesaBusqueda7)
        {
            var mesa7 = _context.mesas.Where(s => s.idMesa == idMesaBusqueda7);
            if (mesa7.Where(s => s.idMesa == idMesaBusqueda7 && s.estado == "Libre").Any())
            {
                return Json(new { mesa7 = "Libre" });
            }
            else if (mesa7.Where(s => s.idMesa == idMesaBusqueda7 && s.estado == "Ocupada").Any())
            {
                return Json(new { mesa7 = "Ocupada" });
            }
            else if (mesa7.Where(s => s.idMesa == idMesaBusqueda7 && s.estado == "Atendida").Any())
            {
                return Json(new { mesa7 = "Atendida" });
            }
            return Json(new { mesa7 = "Libre" });
        }

        [HttpPost]
        public IActionResult GetStatusMesa8(int idMesaBusqueda8)
        {
            var mesa8 = _context.mesas.Where(s => s.idMesa == idMesaBusqueda8);
            if (mesa8.Where(s => s.idMesa == idMesaBusqueda8 && s.estado == "Libre").Any())
            {
                return Json(new { mesa8 = "Libre" });
            }
            else if (mesa8.Where(s => s.idMesa == idMesaBusqueda8 && s.estado == "Ocupada").Any())
            {
                return Json(new { mesa8 = "Ocupada" });
            }
            else if (mesa8.Where(s => s.idMesa == idMesaBusqueda8 && s.estado == "Atendida").Any())
            {
                return Json(new { mesa8 = "Atendida" });
            }
            return Json(new { mesa8 = "Libre" });
        }

        [HttpPost]
        public IActionResult GetStatusMesa9(int idMesaBusqueda9)
        {
            var mesa9 = _context.mesas.Where(s => s.idMesa == idMesaBusqueda9);
            if (mesa9.Where(s => s.idMesa == idMesaBusqueda9 && s.estado == "Libre").Any())
            {
                return Json(new { mesa9 = "Libre" });
            }
            else if (mesa9.Where(s => s.idMesa == idMesaBusqueda9 && s.estado == "Ocupada").Any())
            {
                return Json(new { mesa9 = "Ocupada" });
            }
            else if (mesa9.Where(s => s.idMesa == idMesaBusqueda9 && s.estado == "Atendida").Any())
            {
                return Json(new { mesa9 = "Atendida" });
            }
            return Json(new { mesa9 = "Libre" });
        }
        #endregion

        // GET: mesas/Create
        public IActionResult Create()
        {
            List<String> lista = new List<string>();
            lista.Add("Libre");
            lista.Add("Ocupada");
            lista.Add("Reservada");
            ViewData["status"] = new SelectList(lista.ToList());

            return View();
        }

        // POST: mesas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idMesa,numeroMaximoDePersonas,ubicacion,descripcion,estado")] mesa mesa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mesa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mesa);
        }

        // GET: mesas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            List<String> lista = new List<string>();
            lista.Add("Libre");
            lista.Add("Ocupada");
            lista.Add("Reservada");
            ViewData["status"] = new SelectList(lista.ToList());

            if (id == null)
            {
                return NotFound();
            }

            var mesa = await _context.mesas.FindAsync(id);
            if (mesa == null)
            {
                return NotFound();
            }
            return View(mesa);
        }

        // POST: mesas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idMesa,numeroMaximoDePersonas,ubicacion,descripcion,estado")] mesa mesa)
        {
            if (id != mesa.idMesa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mesa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!mesaExists(mesa.idMesa))
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
            List<String> lista = new List<string>();
            lista.Add("Libre");
            lista.Add("Ocupada");
            lista.Add("Reservada");
            ViewData["status"] = new SelectList(lista.ToList());

            return View(mesa);
        }

        // GET: mesas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mesa = await _context.mesas
                .FirstOrDefaultAsync(m => m.idMesa == id);
            if (mesa == null)
            {
                return NotFound();
            }

            return View(mesa);
        }

        // POST: mesas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mesa = await _context.mesas.FindAsync(id);
            _context.mesas.Remove(mesa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool mesaExists(int id)
        {
            return _context.mesas.Any(e => e.idMesa == id);
        }
    }
}
