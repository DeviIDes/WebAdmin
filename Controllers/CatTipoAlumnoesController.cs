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
    public class CatTipoAlumnoesController : Controller
    {
        private readonly nDbContext _context;

        public CatTipoAlumnoesController(nDbContext context)
        {
            _context = context;
        }

        // GET: CatTipoAlumnoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.CatTipoAlumno.ToListAsync());
        }

        // GET: CatTipoAlumnoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catTipoAlumno = await _context.CatTipoAlumno
                .FirstOrDefaultAsync(m => m.IdTipoAlumno == id);
            if (catTipoAlumno == null)
            {
                return NotFound();
            }

            return View(catTipoAlumno);
        }

        // GET: CatTipoAlumnoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CatTipoAlumnoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTipoAlumno,TipoAlumnoDesc,FechaRegistro,IdEstatusRegistro")] CatTipoAlumno catTipoAlumno)
        {
            if (ModelState.IsValid)
            {
                _context.Add(catTipoAlumno);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(catTipoAlumno);
        }

        // GET: CatTipoAlumnoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catTipoAlumno = await _context.CatTipoAlumno.FindAsync(id);
            if (catTipoAlumno == null)
            {
                return NotFound();
            }
            return View(catTipoAlumno);
        }

        // POST: CatTipoAlumnoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTipoAlumno,TipoAlumnoDesc,FechaRegistro,IdEstatusRegistro")] CatTipoAlumno catTipoAlumno)
        {
            if (id != catTipoAlumno.IdTipoAlumno)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(catTipoAlumno);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CatTipoAlumnoExists(catTipoAlumno.IdTipoAlumno))
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
            return View(catTipoAlumno);
        }

        // GET: CatTipoAlumnoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catTipoAlumno = await _context.CatTipoAlumno
                .FirstOrDefaultAsync(m => m.IdTipoAlumno == id);
            if (catTipoAlumno == null)
            {
                return NotFound();
            }

            return View(catTipoAlumno);
        }

        // POST: CatTipoAlumnoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var catTipoAlumno = await _context.CatTipoAlumno.FindAsync(id);
            _context.CatTipoAlumno.Remove(catTipoAlumno);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CatTipoAlumnoExists(int id)
        {
            return _context.CatTipoAlumno.Any(e => e.IdTipoAlumno == id);
        }
    }
}
