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
using WebAdmin.Services;

namespace WebAdmin.Controllers
{
    public class CatTipoAlumnoesController : Controller
    {
        private readonly nDbContext _context;
        private readonly INotyfService _notyf;
        private readonly IUserService _userService;

        public CatTipoAlumnoesController(nDbContext context, INotyfService notyf,IUserService userService)
        {
            _context = context;
            _notyf = notyf;
            _userService = userService;
        }

        // GET: CatTipoAlumnoes
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

                var DuplicadosEstatus = _context.CatTipoAlumno
                       .Where(s => s.TipoAlumnoDesc == catTipoAlumno.TipoAlumnoDesc)
                       .ToList();

                if (DuplicadosEstatus.Count == 0)
                    {
                        var fuser = _userService.GetUserId();
                        var isLoggedIn = _userService.IsAuthenticated();

                    catTipoAlumno.FechaRegistro = DateTime.Now;
                    catTipoAlumno.TipoAlumnoDesc = catTipoAlumno.TipoAlumnoDesc.ToString().ToUpper();
                    catTipoAlumno.IdEstatusRegistro = 1;
                    _context.SaveChanges();

                    _context.Add(catTipoAlumno);
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
