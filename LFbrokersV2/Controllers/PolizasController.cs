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
    public class PolizasController : Controller
    {
        private readonly LFbrokersContext _context;

        public PolizasController(LFbrokersContext context)
        {
            _context = context;
        }

        // GET: Polizas
        public async Task<IActionResult> Index()
        {
            var lFbrokersContext = _context.Poliza.Include(p => p.AgenteNavigation).Include(p => p.ClienteNavigation).Include(p => p.ClienteNavigation.CodigoPostalNavigation.LocalidadNavigation.ProvinciaNavigation);
            return View(await lFbrokersContext.ToListAsync());
        }

        // GET: Polizas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poliza = await _context.Poliza
                .Include(p => p.AgenteNavigation)
                .Include(p => p.ClienteNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (poliza == null)
            {
                return NotFound();
            }

            return View(poliza);
        }

        // GET: Polizas/Create
        public IActionResult Create()
        {
            ViewData["Agente"] = new SelectList(_context.Persona, "Id", "Apellidos");
            ViewData["Cliente"] = new SelectList(_context.Persona, "Id", "Apellidos");
            return View();
        }

        // POST: Polizas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Cliente,Estado,CantidadCuotas,ProductoAseguradora,RecargosFinancieros,Impuestos,SumaAsegurada,PrimaBase,RecargoPrima,ComisionPrima,PrimaPoliza,PremioTotal,PremioCuota,VigenciaDesde,VigenciaHasta,Matricula,NumeroPoliza,Agente,MotivoRecotizacion")] Poliza poliza)
        {
            if (ModelState.IsValid)
            {
                _context.Add(poliza);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["Agente"] = new SelectList(_context.Persona, "Id", "Apellidos", poliza.Agente);
            ViewData["Cliente"] = new SelectList(_context.Persona, "Id", "Apellidos", poliza.Cliente);
            return View(poliza);
        }

        // GET: Polizas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poliza = await _context.Poliza.FindAsync(id);
            if (poliza == null)
            {
                return NotFound();
            }
            ViewData["Agente"] = new SelectList(_context.Persona, "Id", "Apellidos", poliza.Agente);
            ViewData["Cliente"] = new SelectList(_context.Persona, "Id", "Apellidos", poliza.Cliente);
            return View(poliza);
        }

        // POST: Polizas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Cliente,Estado,CantidadCuotas,ProductoAseguradora,RecargosFinancieros,Impuestos,SumaAsegurada,PrimaBase,RecargoPrima,ComisionPrima,PrimaPoliza,PremioTotal,PremioCuota,VigenciaDesde,VigenciaHasta,Matricula,NumeroPoliza,Agente,MotivoRecotizacion")] Poliza poliza)
        {
            if (id != poliza.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(poliza);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PolizaExists(poliza.Id))
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
            ViewData["Agente"] = new SelectList(_context.Persona, "Id", "Apellidos", poliza.Agente);
            ViewData["Cliente"] = new SelectList(_context.Persona, "Id", "Apellidos", poliza.Cliente);
            return View(poliza);
        }

        // GET: Polizas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poliza = await _context.Poliza
                .Include(p => p.AgenteNavigation)
                .Include(p => p.ClienteNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (poliza == null)
            {
                return NotFound();
            }

            return View(poliza);
        }

        // POST: Polizas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var poliza = await _context.Poliza.FindAsync(id);
            _context.Poliza.Remove(poliza);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PolizaExists(int id)
        {
            return _context.Poliza.Any(e => e.Id == id);
        }
    }
}
