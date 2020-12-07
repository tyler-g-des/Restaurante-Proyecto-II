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
    public class platosController : Controller
    {
        private readonly DataContext _context;

        public platosController(DataContext context)
        {
            _context = context;
        }

        // GET: platos
        public async Task<IActionResult> Index()
        {
            return View(await _context.plato.ToListAsync());
        }

        // GET: platos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plato = await _context.plato
                .FirstOrDefaultAsync(m => m.idPlatos == id);
            if (plato == null)
            {
                return NotFound();
            }

            return View(plato);
        }

        // GET: platos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: platos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idPlatos,Nombre,Precio,Cantidad")] plato plato)
        {
            if (ModelState.IsValid)
            {
                _context.Add(plato);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(plato);
        }

        // GET: platos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plato = await _context.plato.FindAsync(id);
            if (plato == null)
            {
                return NotFound();
            }
            return View(plato);
        }

        // POST: platos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idPlatos,Nombre,Precio,Cantidad")] plato plato)
        {
            if (id != plato.idPlatos)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(plato);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!platoExists(plato.idPlatos))
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
            return View(plato);
        }

        // GET: platos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plato = await _context.plato
                .FirstOrDefaultAsync(m => m.idPlatos == id);
            if (plato == null)
            {
                return NotFound();
            }

            return View(plato);
        }

        // POST: platos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var plato = await _context.plato.FindAsync(id);
            _context.plato.Remove(plato);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool platoExists(int id)
        {
            return _context.plato.Any(e => e.idPlatos == id);
        }
    }
}
