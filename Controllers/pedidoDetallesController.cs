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
    public class pedidoDetallesController : Controller
    {
        private readonly DataContext _context;

        public pedidoDetallesController(DataContext context)
        {
            _context = context;
        }

        // GET: pedidoDetalles
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.pedidoDetalles.Include(p => p.pedido);
            return View(await dataContext.ToListAsync());
        }

        // GET: pedidoDetalles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedidoDetalle = await _context.pedidoDetalles
                .Include(p => p.pedido)
                .FirstOrDefaultAsync(m => m.idPedidoDetalle == id);
            if (pedidoDetalle == null)
            {
                return NotFound();
            }

            return View(pedidoDetalle);
        }

        // GET: pedidoDetalles/Create
        public IActionResult Create()
        {
            ViewData["idPedido"] = new SelectList(_context.pedidos, "idPedido", "observaciones");
            return View();
        }

        // POST: pedidoDetalles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idPedidoDetalle,cantidad,subTotal,impuesto,total,idPedido")] pedidoDetalle pedidoDetalle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pedidoDetalle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idPedido"] = new SelectList(_context.pedidos, "idPedido", "observaciones", pedidoDetalle.idPedido);
            return View(pedidoDetalle);
        }

        // GET: pedidoDetalles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedidoDetalle = await _context.pedidoDetalles.FindAsync(id);
            if (pedidoDetalle == null)
            {
                return NotFound();
            }
            ViewData["idPedido"] = new SelectList(_context.pedidos, "idPedido", "observaciones", pedidoDetalle.idPedido);
            return View(pedidoDetalle);
        }

        // POST: pedidoDetalles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idPedidoDetalle,cantidad,subTotal,impuesto,total,idPedido")] pedidoDetalle pedidoDetalle)
        {
            if (id != pedidoDetalle.idPedidoDetalle)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pedidoDetalle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!pedidoDetalleExists(pedidoDetalle.idPedidoDetalle))
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
            ViewData["idPedido"] = new SelectList(_context.pedidos, "idPedido", "observaciones", pedidoDetalle.idPedido);
            return View(pedidoDetalle);
        }

        // GET: pedidoDetalles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedidoDetalle = await _context.pedidoDetalles
                .Include(p => p.pedido)
                .FirstOrDefaultAsync(m => m.idPedidoDetalle == id);
            if (pedidoDetalle == null)
            {
                return NotFound();
            }

            return View(pedidoDetalle);
        }

        // POST: pedidoDetalles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pedidoDetalle = await _context.pedidoDetalles.FindAsync(id);
            _context.pedidoDetalles.Remove(pedidoDetalle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool pedidoDetalleExists(int id)
        {
            return _context.pedidoDetalles.Any(e => e.idPedidoDetalle == id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AdicionarArticulo([Bind("idPedidoDetalle,cantidad,subTotal,impuesto,total,precio,idPedido,idPlatos")] pedidoDetalle pedidoDetalle)
        {

            if (ModelState.IsValid)
            {
                int id = pedidoDetalle.idPedido;
                int idPlato = pedidoDetalle.idPlatos;

                plato plato = _context.plato.Find(idPlato);

                decimal precio = plato.Precio;
                decimal cantidad = pedidoDetalle.cantidad;

                pedidoDetalle.precio = precio;
                pedidoDetalle.total = cantidad * precio;

                plato.Cantidad += decimal.ToInt32(cantidad);
                _context.Update(plato);

                Models.pedidoDetalle pedidoss = _context.pedidoDetalles.Where(r => r.idPedido == id).FirstOrDefault();


                if (_context.pedidoDetalles.Any(o => o.idPedido == id) == false)
                {
                    _context.Add(pedidoDetalle);

                }
                else
                {
                    pedidoss.cantidad += decimal.ToInt32(cantidad);
                    _context.Update(pedidoss);
                }

                await _context.SaveChangesAsync();

                pedido pedido = _context.pedidos.Find(id);
                pedido.subTotal += cantidad * precio;
                pedido.total += cantidad * precio;

                _context.Update(pedido);
                _context.SaveChanges();

                return RedirectToAction("Details", "pedidos", new { id = id });
            }
            return View(pedidoDetalle);

        }

        public async Task<IActionResult> ValidarImprimir(int? id)
        {
            pedidoView dd = new pedidoView();

            dd.pedido = await _context.pedidos
                .Include(o => o.mesa)
                .Include(o => o.plato)
                .FirstOrDefaultAsync(m => m.idPedido == id);

            var data = _context.pedidoDetalles
                .Include(od => od.pedido)
                .Include(od => od.plato)
                .Where(od => od.idPedidoDetalle.Equals(id)).ToList();
             
            dd.pedidos = data;

            return View("Factura", dd);
        }
    }
}
