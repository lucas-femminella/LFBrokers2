using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LFbrokersV2.Models;

namespace LFbrokersV2.Controllers
{
    public class OpcionesCotizacionesController : Controller
    {
        private readonly LFbrokersContext _context;

        public OpcionesCotizacionesController(LFbrokersContext context)
        {
            _context = context;
        }

        // GET: OpcionesCotizaciones
        public async Task<IActionResult> Index()
        {
            var lFbrokersContext = _context.OpcionesCotizacion.Include(o => o.PolizaNavigation);
            return View(await lFbrokersContext.ToListAsync());
        }

        // GET: OpcionesCotizaciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opcionesCotizacion = await _context.OpcionesCotizacion
                .Include(o => o.PolizaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (opcionesCotizacion == null)
            {
                return NotFound();
            }

            return View(opcionesCotizacion);
        }

        // GET: OpcionesCotizaciones/Create
        public IActionResult Create()
        {
            ViewData["Poliza"] = new SelectList(_context.Poliza, "Id", "Estado");
            return View();
        }

        // POST: OpcionesCotizaciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Poliza,PrimaBase,SumaAsegurada,RecargoPrima,ComisionPrima,PrimaPoliza,PremioTotal,PremioCuota,Condicion,Aseguradora,OpcionElegida")] OpcionesCotizacion opcionesCotizacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(opcionesCotizacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Poliza"] = new SelectList(_context.Poliza, "Id", "Estado", opcionesCotizacion.Poliza);
            return View(opcionesCotizacion);
        }

        // GET: OpcionesCotizaciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opcionesCotizacion = await _context.OpcionesCotizacion.FindAsync(id);
            if (opcionesCotizacion == null)
            {
                return NotFound();
            }
            ViewData["Poliza"] = new SelectList(_context.Poliza, "Id", "Estado", opcionesCotizacion.Poliza);
            return View(opcionesCotizacion);
        }

        // POST: OpcionesCotizaciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Poliza,PrimaBase,SumaAsegurada,RecargoPrima,ComisionPrima,PrimaPoliza,PremioTotal,PremioCuota,Condicion,Aseguradora,OpcionElegida")] OpcionesCotizacion opcionesCotizacion)
        {
            if (id != opcionesCotizacion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(opcionesCotizacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OpcionesCotizacionExists(opcionesCotizacion.Id))
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
            ViewData["Poliza"] = new SelectList(_context.Poliza, "Id", "Estado", opcionesCotizacion.Poliza);
            return View(opcionesCotizacion);
        }

        // GET: OpcionesCotizaciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opcionesCotizacion = await _context.OpcionesCotizacion
                .Include(o => o.PolizaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (opcionesCotizacion == null)
            {
                return NotFound();
            }

            return View(opcionesCotizacion);
        }

        // POST: OpcionesCotizaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var opcionesCotizacion = await _context.OpcionesCotizacion.FindAsync(id);
            _context.OpcionesCotizacion.Remove(opcionesCotizacion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OpcionesCotizacionExists(int id)
        {
            return _context.OpcionesCotizacion.Any(e => e.Id == id);
        }
    }
}
