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
    public class CatTipoServiciosController : Controller
    {
        private readonly nDbContext _context;

        public CatTipoServiciosController(nDbContext context)
        {
            _context = context;
        }

        // GET: CatTipoServicios
        public async Task<IActionResult> Index()
        {
            return View(await _context.CatTipoServicio.ToListAsync());
        }

        // GET: CatTipoServicios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catTipoServicio = await _context.CatTipoServicio
                .FirstOrDefaultAsync(m => m.IdTipoServicio == id);
            if (catTipoServicio == null)
            {
                return NotFound();
            }

            return View(catTipoServicio);
        }

        // GET: CatTipoServicios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CatTipoServicios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTipoServicio,TipoServicioDesc,FechaRegistro,IdEstatusRegistro")] CatTipoServicio catTipoServicio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(catTipoServicio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(catTipoServicio);
        }

        // GET: CatTipoServicios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catTipoServicio = await _context.CatTipoServicio.FindAsync(id);
            if (catTipoServicio == null)
            {
                return NotFound();
            }
            return View(catTipoServicio);
        }

        // POST: CatTipoServicios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTipoServicio,TipoServicioDesc,FechaRegistro,IdEstatusRegistro")] CatTipoServicio catTipoServicio)
        {
            if (id != catTipoServicio.IdTipoServicio)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(catTipoServicio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CatTipoServicioExists(catTipoServicio.IdTipoServicio))
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
            return View(catTipoServicio);
        }

        // GET: CatTipoServicios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catTipoServicio = await _context.CatTipoServicio
                .FirstOrDefaultAsync(m => m.IdTipoServicio == id);
            if (catTipoServicio == null)
            {
                return NotFound();
            }

            return View(catTipoServicio);
        }

        // POST: CatTipoServicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var catTipoServicio = await _context.CatTipoServicio.FindAsync(id);
            _context.CatTipoServicio.Remove(catTipoServicio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CatTipoServicioExists(int id)
        {
            return _context.CatTipoServicio.Any(e => e.IdTipoServicio == id);
        }
    }
}
