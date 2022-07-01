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
    public class CatTipoCentroesController : Controller
    {
        private readonly nDbContext _context;

        public CatTipoCentroesController(nDbContext context)
        {
            _context = context;
        }

        // GET: CatTipoCentroes
        public async Task<IActionResult> Index()
        {
            return View(await _context.CatTipoCentros.ToListAsync());
        }

        // GET: CatTipoCentroes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catTipoCentro = await _context.CatTipoCentros
                .FirstOrDefaultAsync(m => m.IdTipoCentro == id);
            if (catTipoCentro == null)
            {
                return NotFound();
            }

            return View(catTipoCentro);
        }

        // GET: CatTipoCentroes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CatTipoCentroes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTipoCentro,TipoCentroDesc,FechaRegistro,IdEstatusRegistro")] CatTipoCentro catTipoCentro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(catTipoCentro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(catTipoCentro);
        }

        // GET: CatTipoCentroes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catTipoCentro = await _context.CatTipoCentros.FindAsync(id);
            if (catTipoCentro == null)
            {
                return NotFound();
            }
            return View(catTipoCentro);
        }

        // POST: CatTipoCentroes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTipoCentro,TipoCentroDesc,FechaRegistro,IdEstatusRegistro")] CatTipoCentro catTipoCentro)
        {
            if (id != catTipoCentro.IdTipoCentro)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(catTipoCentro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CatTipoCentroExists(catTipoCentro.IdTipoCentro))
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
            return View(catTipoCentro);
        }

        // GET: CatTipoCentroes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catTipoCentro = await _context.CatTipoCentros
                .FirstOrDefaultAsync(m => m.IdTipoCentro == id);
            if (catTipoCentro == null)
            {
                return NotFound();
            }

            return View(catTipoCentro);
        }

        // POST: CatTipoCentroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var catTipoCentro = await _context.CatTipoCentros.FindAsync(id);
            _context.CatTipoCentros.Remove(catTipoCentro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CatTipoCentroExists(int id)
        {
            return _context.CatTipoCentros.Any(e => e.IdTipoCentro == id);
        }
    }
}
