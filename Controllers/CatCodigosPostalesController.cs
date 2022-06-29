using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebAdmin.Data;
using WebAdmin.Models;

namespace WebAdmin.Controllers
{
   
    public class CatCodigosPostalesController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
      

      
        public CatCodigosPostalesController(ILogger<HomeController> logger,ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }

   
        // GET: CatCodigosPostales

        public async Task<IActionResult> Index()
        {
            return View(await _context.CatCodigosPostales.ToListAsync());
        }
        [HttpGet]
        public ActionResult FiltroColonia(string id, string idC)
        {
            var fcatColonias = (from ta in _context.CatCodigosPostales
                                where ta.Dcodigo == id
                                where ta.IdAsentaCpcons == idC
                                select ta).Distinct().ToList();

            return Json(fcatColonias);
        }
        [HttpGet]
        public ActionResult FiltroCodigosPostales(string id)
        {
            var fcatCodigosPostales = _context.CatCodigosPostales
                       .Where(s => s.Dcodigo == id).Distinct().ToList();
            return Json(fcatCodigosPostales);
        }
        // GET: CatCodigosPostales/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catCodigosPostale = await _context.CatCodigosPostales
                .FirstOrDefaultAsync(m => m.IdCodigosPostales == id);
            if (catCodigosPostale == null)
            {
                return NotFound();
            }

            return View(catCodigosPostale);
        }

        // GET: CatCodigosPostales/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CatCodigosPostales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCodigosPostales,Dcodigo,Dasenta,DtipoAsenta,Dmnpio,Destado,Dciudad,Dcp,Cestado,Coficina,Ccp,CtipoAsenta,Cmnpio,IdAsentaCpcons,Dzona,CcveCiudad")] CatCodigosPostale catCodigosPostale)
        {
            if (ModelState.IsValid)
            {
                _context.Add(catCodigosPostale);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(catCodigosPostale);
        }

        // GET: CatCodigosPostales/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catCodigosPostale = await _context.CatCodigosPostales.FindAsync(id);
            if (catCodigosPostale == null)
            {
                return NotFound();
            }
            return View(catCodigosPostale);
        }

        // POST: CatCodigosPostales/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCodigosPostales,Dcodigo,Dasenta,DtipoAsenta,Dmnpio,Destado,Dciudad,Dcp,Cestado,Coficina,Ccp,CtipoAsenta,Cmnpio,IdAsentaCpcons,Dzona,CcveCiudad")] CatCodigosPostale catCodigosPostale)
        {
            if (id != catCodigosPostale.IdCodigosPostales)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(catCodigosPostale);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CatCodigosPostaleExists(catCodigosPostale.IdCodigosPostales))
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
            return View(catCodigosPostale);
        }

        // GET: CatCodigosPostales/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catCodigosPostale = await _context.CatCodigosPostales
                .FirstOrDefaultAsync(m => m.IdCodigosPostales == id);
            if (catCodigosPostale == null)
            {
                return NotFound();
            }

            return View(catCodigosPostale);
        }

        // POST: CatCodigosPostales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var catCodigosPostale = await _context.CatCodigosPostales.FindAsync(id);
            _context.CatCodigosPostales.Remove(catCodigosPostale);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CatCodigosPostaleExists(int id)
        {
            return _context.CatCodigosPostales.Any(e => e.IdCodigosPostales == id);
        }
    }
}
