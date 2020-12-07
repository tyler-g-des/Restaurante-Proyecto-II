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
    public class clasificacionIngredientesController : Controller
    {
        private readonly DataContext _context;

        public clasificacionIngredientesController(DataContext context)
        {
            _context = context;
        }

        // GET: clasificacionIngredientes
        public async Task<IActionResult> Index()
        {
            return View(await _context.clasificacionIngredientes.ToListAsync());
        }

        // GET: clasificacionIngredientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clasificacionIngredientes = await _context.clasificacionIngredientes
                .FirstOrDefaultAsync(m => m.idClasificacionIngredientes == id);
            if (clasificacionIngredientes == null)
            {
                return NotFound();
            }

            return View(clasificacionIngredientes);
        }

        // GET: clasificacionIngredientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: clasificacionIngredientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idClasificacionIngredientes,tipoClientes")] clasificacionIngredientes clasificacionIngredientes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clasificacionIngredientes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clasificacionIngredientes);
        }

        // GET: clasificacionIngredientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clasificacionIngredientes = await _context.clasificacionIngredientes.FindAsync(id);
            if (clasificacionIngredientes == null)
            {
                return NotFound();
            }
            return View(clasificacionIngredientes);
        }

        // POST: clasificacionIngredientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idClasificacionIngredientes,tipoClientes")] clasificacionIngredientes clasificacionIngredientes)
        {
            if (id != clasificacionIngredientes.idClasificacionIngredientes)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clasificacionIngredientes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!clasificacionIngredientesExists(clasificacionIngredientes.idClasificacionIngredientes))
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
            return View(clasificacionIngredientes);
        }

        // GET: clasificacionIngredientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clasificacionIngredientes = await _context.clasificacionIngredientes
                .FirstOrDefaultAsync(m => m.idClasificacionIngredientes == id);
            if (clasificacionIngredientes == null)
            {
                return NotFound();
            }

            return View(clasificacionIngredientes);
        }

        // POST: clasificacionIngredientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clasificacionIngredientes = await _context.clasificacionIngredientes.FindAsync(id);
            _context.clasificacionIngredientes.Remove(clasificacionIngredientes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool clasificacionIngredientesExists(int id)
        {
            return _context.clasificacionIngredientes.Any(e => e.idClasificacionIngredientes == id);
        }
    }
}
