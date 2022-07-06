using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAdmin.Data;
using WebAdmin.Models;

namespace WebAdmin.Controllers
{
    public class TblVentasController : Controller
    {
        private readonly nDbContext _context;

        public TblVentasController(nDbContext context)
        {
            _context = context;
        }

        // GET: TblVentas
        public async Task<IActionResult> Index()
        {
            return View(await _context.TblVenta.ToListAsync());
        }

        // GET: TblVentas/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblVenta = await _context.TblVenta
                .FirstOrDefaultAsync(m => m.IdVenta == id);
            if (tblVenta == null)
            {
                return NotFound();
            }

            return View(tblVenta);
        }

        // GET: TblVentas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TblVentas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdVenta,NumeroVenta,IdUsuarioVenta,IdCentro,IdCliente,Descuento,IdTipoPago,FechaAlterna,IdUsuarioModifico,FechaRegistro,IdEstatusRegistro")] TblVenta tblVenta)
        {
            if (ModelState.IsValid)
            {
                tblVenta.IdVenta = Guid.NewGuid();
                _context.Add(tblVenta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblVenta);
        }

        // GET: TblVentas/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblVenta = await _context.TblVenta.FindAsync(id);
            if (tblVenta == null)
            {
                return NotFound();
            }
            return View(tblVenta);
        }

        // POST: TblVentas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IdVenta,NumeroVenta,IdUsuarioVenta,IdCentro,IdCliente,Descuento,IdTipoPago,FechaAlterna,IdUsuarioModifico,FechaRegistro,IdEstatusRegistro")] TblVenta tblVenta)
        {
            if (id != tblVenta.IdVenta)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblVenta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblVentaExists(tblVenta.IdVenta))
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
            return View(tblVenta);
        }

        // GET: TblVentas/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblVenta = await _context.TblVenta
                .FirstOrDefaultAsync(m => m.IdVenta == id);
            if (tblVenta == null)
            {
                return NotFound();
            }

            return View(tblVenta);
        }

        // POST: TblVentas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var tblVenta = await _context.TblVenta.FindAsync(id);
            _context.TblVenta.Remove(tblVenta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblVentaExists(Guid id)
        {
            return _context.TblVenta.Any(e => e.IdVenta == id);
        }
    }
}
