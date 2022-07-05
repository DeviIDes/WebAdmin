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
    public class CatTipoClientesController : Controller
    {
        private readonly nDbContext _context;
        private readonly INotyfService _notyf;
        private readonly IUserService _userService;

        public CatTipoClientesController(nDbContext context, INotyfService notyf,IUserService userService)
        {
            _context = context;
            _notyf = notyf;
            _userService = userService;
        }

        // GET: CatTipoClienteses
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
            return View(await _context.CatTipoClientes.ToListAsync());
        }

        // GET: CatTipoClienteses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var CatTipoClientes = await _context.CatTipoClientes
                .FirstOrDefaultAsync(m => m.IdTipoCliente == id);
            if (CatTipoClientes == null)
            {
                return NotFound();
            }

            return View(CatTipoClientes);
        }

        // GET: CatTipoClienteses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CatTipoClienteses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTipoCliente,TipoClienteDesc,FechaRegistro,IdEstatusRegistro")] CatTipoCliente CatTipoClientes)
        {
            if (ModelState.IsValid)
            {

                var DuplicadosEstatus = _context.CatTipoClientes
                       .Where(s => s.TipoClienteDesc == CatTipoClientes.TipoClienteDesc)
                       .ToList();

                if (DuplicadosEstatus.Count == 0)
                    {
                        var fuser = _userService.GetUserId();
                        var isLoggedIn = _userService.IsAuthenticated();

                    CatTipoClientes.FechaRegistro = DateTime.Now;
                    CatTipoClientes.TipoClienteDesc = CatTipoClientes.TipoClienteDesc.ToString().ToUpper();
                    CatTipoClientes.IdEstatusRegistro = 1;
                    _context.SaveChanges();

                    _context.Add(CatTipoClientes);
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
            return View(CatTipoClientes);
        }

        // GET: CatTipoClienteses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var CatTipoClientes = await _context.CatTipoClientes.FindAsync(id);
            if (CatTipoClientes == null)
            {
                return NotFound();
            }
            return View(CatTipoClientes);
        }

        // POST: CatTipoClienteses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTipoCliente,TipoClienteDesc,FechaRegistro,IdEstatusRegistro")] CatTipoCliente CatTipoClientes)
        {
            if (id != CatTipoClientes.IdTipoCliente)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(CatTipoClientes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CatTipoClientesExists(CatTipoClientes.IdTipoCliente))
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
            return View(CatTipoClientes);
        }

        // GET: CatTipoClienteses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var CatTipoClientes = await _context.CatTipoClientes
                .FirstOrDefaultAsync(m => m.IdTipoCliente == id);
            if (CatTipoClientes == null)
            {
                return NotFound();
            }

            return View(CatTipoClientes);
        }

        // POST: CatTipoClienteses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var CatTipoClientes = await _context.CatTipoClientes.FindAsync(id);
            _context.CatTipoClientes.Remove(CatTipoClientes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CatTipoClientesExists(int id)
        {
            return _context.CatTipoClientes.Any(e => e.IdTipoCliente == id);
        }
    }
}
