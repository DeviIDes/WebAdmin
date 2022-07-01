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
    public class CatTipoContratacionsController : Controller
    {
        private readonly nDbContext _context;

        public CatTipoContratacionsController(nDbContext context)
        {
            _context = context;
        }

        // GET: CatTipoContratacions
        public async Task<IActionResult> Index()
        {
            return View(await _context.CatTipoContratacion.ToListAsync());
        }

        // GET: CatTipoContratacions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catTipoContratacion = await _context.CatTipoContratacion
                .FirstOrDefaultAsync(m => m.IdTipoContratacion == id);
            if (catTipoContratacion == null)
            {
                return NotFound();
            }

            return View(catTipoContratacion);
        }

        // GET: CatTipoContratacions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CatTipoContratacions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTipoContratacion,TipoContratacionDesc,FechaRegistro,IdEstatusRegistro")] CatTipoContratacion catTipoContratacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(catTipoContratacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(catTipoContratacion);
        }

        // GET: CatTipoContratacions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catTipoContratacion = await _context.CatTipoContratacion.FindAsync(id);
            if (catTipoContratacion == null)
            {
                return NotFound();
            }
            return View(catTipoContratacion);
        }

        // POST: CatTipoContratacions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTipoContratacion,TipoContratacionDesc,FechaRegistro,IdEstatusRegistro")] CatTipoContratacion catTipoContratacion)
        {
            if (id != catTipoContratacion.IdTipoContratacion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(catTipoContratacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CatTipoContratacionExists(catTipoContratacion.IdTipoContratacion))
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
            return View(catTipoContratacion);
        }

        // GET: CatTipoContratacions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catTipoContratacion = await _context.CatTipoContratacion
                .FirstOrDefaultAsync(m => m.IdTipoContratacion == id);
            if (catTipoContratacion == null)
            {
                return NotFound();
            }

            return View(catTipoContratacion);
        }

        // POST: CatTipoContratacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var catTipoContratacion = await _context.CatTipoContratacion.FindAsync(id);
            _context.CatTipoContratacion.Remove(catTipoContratacion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CatTipoContratacionExists(int id)
        {
            return _context.CatTipoContratacion.Any(e => e.IdTipoContratacion == id);
        }
    }
}
