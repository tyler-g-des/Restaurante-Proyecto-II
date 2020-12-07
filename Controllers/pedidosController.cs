using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PrimerParcial.Data;
using Restaurantee.Models;
using Restaurantee.ViewModel;

namespace Restaurantee.Controllers
{
    public class pedidosController : Controller
    {
        private readonly DataContext _context;

        public pedidosController(DataContext context)
        {
            _context = context;
        }

        // GET: pedidos
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.pedidos.Include(p => p.mesa);
            return View(await dataContext.ToListAsync());
        }

        // GET: pedidos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedidoView = new pedidoView();
            var pedidoDetalle = new pedidoDetalle();
   

            pedidoView.pedido = await _context.pedidos
                .Include(p => p.mesa)
                .Include(p => p.plato)
                .FirstOrDefaultAsync(m => m.idPedido == id);

            var data = _context.pedidoDetalles.Include(od => od.pedido).Where(od => od.idPedido.Equals(id)).ToList();
            pedidoView.pedidos = data;

            ViewData["Platoo"] = new SelectList(_context.plato, "idPlatos", "Nombre", pedidoDetalle);


            return View(pedidoView);
        }

        // GET: pedidos/Create
        public IActionResult Create()
        {
            ViewData["idMesa"] = new SelectList(_context.mesas, "idMesa", "idMesa");
            return View();
        }

        // POST: pedidos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idPedido,persona,fechaPedido,subTotal,impuesto,total,observaciones,idMesa,estado")] pedido pedido)
        {
            if (ModelState.IsValid)
            {
                //cambiar estado mesa
                var mesaEncontrado = _context.mesas
                        .FirstOrDefault(o => o.idMesa == pedido.idMesa);
                mesaEncontrado.estado = "Ocupada";

                _context.Update(mesaEncontrado);
                await _context.SaveChangesAsync();

                pedido.estado = true;

                _context.Add(pedido);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idMesa"] = new SelectList(_context.mesas, "idMesa", "idMesa", pedido.idMesa);
            return View(pedido);
        }

        // GET: pedidos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.pedidos.FindAsync(id);
            if (pedido == null)
            {
                return NotFound();
            }
            ViewData["idMesa"] = new SelectList(_context.mesas, "idMesa", "idMesa", pedido.idMesa);
            return View(pedido);
        }

        // POST: pedidos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idPedido,persona,fechaPedido,subTotal,impuesto,total,observaciones,idMesa,estado")] pedido pedido)
        {
            if (id != pedido.idPedido)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pedido);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!pedidoExists(pedido.idPedido))
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
            ViewData["idMesa"] = new SelectList(_context.mesas, "idMesa", "idMesa", pedido.idMesa);
            return View(pedido);
        }

        // GET: pedidos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.pedidos
                .Include(p => p.mesa)
                .FirstOrDefaultAsync(m => m.idPedido == id);
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

        // POST: pedidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pedido = await _context.pedidos.FindAsync(id);
            _context.pedidos.Remove(pedido);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool pedidoExists(int id)
        {
            return _context.pedidos.Any(e => e.idPedido == id);
        }
    }
}
