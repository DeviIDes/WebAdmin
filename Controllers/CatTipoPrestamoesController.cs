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
    public class CatTipoPrestamoesController : Controller
    {
        private readonly nDbContext _context;

        public CatTipoPrestamoesController(nDbContext context)
        {
            _context = context;
        }

        // GET: CatTipoPrestamoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.CatTipoPrestamo.ToListAsync());
        }

        // GET: CatTipoPrestamoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catTipoPrestamo = await _context.CatTipoPrestamo
                .FirstOrDefaultAsync(m => m.IdTipoPrestamo == id);
            if (catTipoPrestamo == null)
            {
                return NotFound();
            }

            return View(catTipoPrestamo);
        }

        // GET: CatTipoPrestamoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CatTipoPrestamoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTipoPrestamo,TipoPrestamoDesc,FechaRegistro,IdEstatusRegistro")] CatTipoPrestamo catTipoPrestamo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(catTipoPrestamo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(catTipoPrestamo);
        }

        // GET: CatTipoPrestamoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catTipoPrestamo = await _context.CatTipoPrestamo.FindAsync(id);
            if (catTipoPrestamo == null)
            {
                return NotFound();
            }
            return View(catTipoPrestamo);
        }

        // POST: CatTipoPrestamoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTipoPrestamo,TipoPrestamoDesc,FechaRegistro,IdEstatusRegistro")] CatTipoPrestamo catTipoPrestamo)
        {
            if (id != catTipoPrestamo.IdTipoPrestamo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(catTipoPrestamo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CatTipoPrestamoExists(catTipoPrestamo.IdTipoPrestamo))
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
            return View(catTipoPrestamo);
        }

        // GET: CatTipoPrestamoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catTipoPrestamo = await _context.CatTipoPrestamo
                .FirstOrDefaultAsync(m => m.IdTipoPrestamo == id);
            if (catTipoPrestamo == null)
            {
                return NotFound();
            }

            return View(catTipoPrestamo);
        }

        // POST: CatTipoPrestamoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var catTipoPrestamo = await _context.CatTipoPrestamo.FindAsync(id);
            _context.CatTipoPrestamo.Remove(catTipoPrestamo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CatTipoPrestamoExists(int id)
        {
            return _context.CatTipoPrestamo.Any(e => e.IdTipoPrestamo == id);
        }
    }
}
