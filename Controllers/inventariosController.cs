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
    public class inventariosController : Controller
    {
        private readonly DataContext _context;

        public inventariosController(DataContext context)
        {
            _context = context;
        }

        // GET: inventarios
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.inventarios.Include(i => i.clasificacion);
            return View(await dataContext.ToListAsync());
        }

        // GET: inventarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventario = await _context.inventarios
                .Include(i => i.clasificacion)
                .FirstOrDefaultAsync(m => m.idInventario == id);
            if (inventario == null)
            {
                return NotFound();
            }

            return View(inventario);
        }

        // GET: inventarios/Create
        public IActionResult Create()
        {
            ViewData["idClasificacionIngredientes"] = new SelectList(_context.clasificacionIngredientes, "idClasificacionIngredientes", "idClasificacionIngredientes");
            return View();
        }

        // POST: inventarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idInventario,ingrediente,cantidad,idClasificacionIngredientes")] inventario inventario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inventario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idClasificacionIngredientes"] = new SelectList(_context.clasificacionIngredientes, "idClasificacionIngredientes", "idClasificacionIngredientes", inventario.idClasificacionIngredientes);
            return View(inventario);
        }

        // GET: inventarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventario = await _context.inventarios.FindAsync(id);
            if (inventario == null)
            {
                return NotFound();
            }
            ViewData["idClasificacionIngredientes"] = new SelectList(_context.clasificacionIngredientes, "idClasificacionIngredientes", "idClasificacionIngredientes", inventario.idClasificacionIngredientes);
            return View(inventario);
        }

        // POST: inventarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idInventario,ingrediente,cantidad,idClasificacionIngredientes")] inventario inventario)
        {
            if (id != inventario.idInventario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inventario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!inventarioExists(inventario.idInventario))
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
            ViewData["idClasificacionIngredientes"] = new SelectList(_context.clasificacionIngredientes, "idClasificacionIngredientes", "idClasificacionIngredientes", inventario.idClasificacionIngredientes);
            return View(inventario);
        }

        // GET: inventarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventario = await _context.inventarios
                .Include(i => i.clasificacion)
                .FirstOrDefaultAsync(m => m.idInventario == id);
            if (inventario == null)
            {
                return NotFound();
            }

            return View(inventario);
        }

        // POST: inventarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inventario = await _context.inventarios.FindAsync(id);
            _context.inventarios.Remove(inventario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool inventarioExists(int id)
        {
            return _context.inventarios.Any(e => e.idInventario == id);
        }
    }
}
