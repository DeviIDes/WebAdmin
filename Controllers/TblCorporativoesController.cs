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
    public class TblCorporativoesController : Controller
    {
       private readonly nDbContext _context;
        private readonly INotyfService _notyf;

        public TblCorporativoesController(nDbContext context, INotyfService notyf)
        {
            _context = context;
            _notyf = notyf;
        }

        // GET: TblCorporativoes
        public async Task<IActionResult> Index()
        {
                      var ValidaEstatus = _context.CatEstatus.ToList();

            if (ValidaEstatus.Count == 2)
            {
                ViewBag.EstatusFlag = 1;
                var ValidaEmpresa = _context.TblEmpresa.ToList();

                if (ValidaEmpresa.Count == 1)
                {
                    ViewBag.EmpresaFlag = 1;
                }
                else
                {
                    ViewBag.EmpresaFlag = 0;
                    _notyf.Information("Favor de registrar los datos de la Empresa para la Aplicación", 5);
                }
            }
            else
            {
                ViewBag.EstatusFlag = 0;
                _notyf.Information("Favor de registrar los Estatus para la Aplicación", 5);
            }
            return View(await _context.TblCorporativos.ToListAsync());
        }

        // GET: TblCorporativoes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblCorporativo = await _context.TblCorporativos
                .FirstOrDefaultAsync(m => m.IdCorporativo == id);
            if (tblCorporativo == null)
            {
                return NotFound();
            }

            return View(tblCorporativo);
        }

        // GET: TblCorporativoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TblCorporativoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCorporativo,IdTipoLicencia,IdTipoCorporativo,NombreCorporativo,Calle,CodigoPostal,IdColonia,Colonia,LocalidadMunicipio,Ciudad,Estado,CorreoElectronico,Telefono,IdEmpresa,FechaRegistro,IdEstatusRegistro")] TblCorporativo tblCorporativo)
        {
            if (ModelState.IsValid)
            {
                tblCorporativo.IdCorporativo = Guid.NewGuid();
                _context.Add(tblCorporativo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblCorporativo);
        }

        // GET: TblCorporativoes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblCorporativo = await _context.TblCorporativos.FindAsync(id);
            if (tblCorporativo == null)
            {
                return NotFound();
            }
            return View(tblCorporativo);
        }

        // POST: TblCorporativoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IdCorporativo,IdTipoLicencia,IdTipoCorporativo,NombreCorporativo,Calle,CodigoPostal,IdColonia,Colonia,LocalidadMunicipio,Ciudad,Estado,CorreoElectronico,Telefono,IdEmpresa,FechaRegistro,IdEstatusRegistro")] TblCorporativo tblCorporativo)
        {
            if (id != tblCorporativo.IdCorporativo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblCorporativo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblCorporativoExists(tblCorporativo.IdCorporativo))
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
            return View(tblCorporativo);
        }

        // GET: TblCorporativoes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblCorporativo = await _context.TblCorporativos
                .FirstOrDefaultAsync(m => m.IdCorporativo == id);
            if (tblCorporativo == null)
            {
                return NotFound();
            }

            return View(tblCorporativo);
        }

        // POST: TblCorporativoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var tblCorporativo = await _context.TblCorporativos.FindAsync(id);
            _context.TblCorporativos.Remove(tblCorporativo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblCorporativoExists(Guid id)
        {
            return _context.TblCorporativos.Any(e => e.IdCorporativo == id);
        }
    }
}
