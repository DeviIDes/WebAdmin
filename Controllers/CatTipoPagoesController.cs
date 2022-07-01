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
    public class CatTipoPagoesController : Controller
    {
        private readonly nDbContext _context;

        public CatTipoPagoesController(nDbContext context)
        {
            _context = context;
        }

        // GET: CatTipoPagoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.CatTipoPago.ToListAsync());
        }

        // GET: CatTipoPagoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catTipoPago = await _context.CatTipoPago
                .FirstOrDefaultAsync(m => m.IdTipoPago == id);
            if (catTipoPago == null)
            {
                return NotFound();
            }

            return View(catTipoPago);
        }

        // GET: CatTipoPagoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CatTipoPagoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTipoPago,TipoCentroDesc,FechaRegistro,IdEstatusRegistro")] CatTipoPago catTipoPago)
        {
            if (ModelState.IsValid)
            {
                _context.Add(catTipoPago);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(catTipoPago);
        }

        // GET: CatTipoPagoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catTipoPago = await _context.CatTipoPago.FindAsync(id);
            if (catTipoPago == null)
            {
                return NotFound();
            }
            return View(catTipoPago);
        }

        // POST: CatTipoPagoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTipoPago,TipoCentroDesc,FechaRegistro,IdEstatusRegistro")] CatTipoPago catTipoPago)
        {
            if (id != catTipoPago.IdTipoPago)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(catTipoPago);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CatTipoPagoExists(catTipoPago.IdTipoPago))
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
            return View(catTipoPago);
        }

        // GET: CatTipoPagoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catTipoPago = await _context.CatTipoPago
                .FirstOrDefaultAsync(m => m.IdTipoPago == id);
            if (catTipoPago == null)
            {
                return NotFound();
            }

            return View(catTipoPago);
        }

        // POST: CatTipoPagoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var catTipoPago = await _context.CatTipoPago.FindAsync(id);
            _context.CatTipoPago.Remove(catTipoPago);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CatTipoPagoExists(int id)
        {
            return _context.CatTipoPago.Any(e => e.IdTipoPago == id);
        }
    }
}
