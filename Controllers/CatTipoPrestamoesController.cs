using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
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
        private readonly INotyfService _notyf;

        public CatTipoPrestamoesController(nDbContext context, INotyfService notyf)
        {
            _context = context;
            _notyf = notyf;
        }

        // GET: CatTipoPrestamoes
        public async Task<IActionResult> Index()
        {
            var ValidaEstatus = _context.CatEstatus.ToList();

            if (ValidaEstatus.Count == 2)
            {
                ViewBag.EstatusFlag = 1;
            }
            else
            {
                ViewBag.EstatusFlag = 0;
                _notyf.Information("Favor de registrar los Estatus para la Aplicación", 5);
            }
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

                var DuplicadosEstatus = _context.CatTipoPrestamo
                       .Where(s => s.TipoPrestamoDesc == catTipoPrestamo.TipoPrestamoDesc)
                       .ToList();

                if (DuplicadosEstatus.Count == 0)
                {

                    catTipoPrestamo.FechaRegistro = DateTime.Now;
                    catTipoPrestamo.TipoPrestamoDesc = catTipoPrestamo.TipoPrestamoDesc.ToString().ToUpper();
                    catTipoPrestamo.IdEstatusRegistro = 1;
                    _context.SaveChanges();

                    _context.Add(catTipoPrestamo);
                    await _context.SaveChangesAsync();
                    _notyf.Success("Registro creado con éxito", 5);
                }
                else
                {
                    //_notifyService.Custom("Custom Notification - closes in 5 seconds.", 5, "whitesmoke", "fa fa-gear");
                    _notyf.Information("Favor de validar, existe una Estatus con el mismo nombre", 5);
                }
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
