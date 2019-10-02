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
    public class EspecialidadesCubiertasController : Controller
    {
        private readonly LFbrokersContext _context;

        public EspecialidadesCubiertasController(LFbrokersContext context)
        {
            _context = context;
        }

        // GET: EspecialidadesCubiertas
        public async Task<IActionResult> Index()
        {
            var lFbrokersContext = _context.EspecialidadesCubiertas.Include(e => e.EspecialidadNavigation).Include(e => e.PolizaNavigation);
            return View(await lFbrokersContext.ToListAsync());
        }

        // GET: EspecialidadesCubiertas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var especialidadesCubiertas = await _context.EspecialidadesCubiertas
                .Include(e => e.EspecialidadNavigation)
                .Include(e => e.PolizaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (especialidadesCubiertas == null)
            {
                return NotFound();
            }

            return View(especialidadesCubiertas);
        }

        // GET: EspecialidadesCubiertas/Create
        public IActionResult Create()
        {
            ViewData["Especialidad"] = new SelectList(_context.Especialidad, "Id", "Nombre");
            ViewData["Poliza"] = new SelectList(_context.Poliza, "Id", "Estado");
            return View();
        }

        // POST: EspecialidadesCubiertas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Especialidad,MayorRiesgo,Poliza")] EspecialidadesCubiertas especialidadesCubiertas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(especialidadesCubiertas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Especialidad"] = new SelectList(_context.Especialidad, "Id", "Nombre", especialidadesCubiertas.Especialidad);
            ViewData["Poliza"] = new SelectList(_context.Poliza, "Id", "Estado", especialidadesCubiertas.Poliza);
            return View(especialidadesCubiertas);
        }

        // GET: EspecialidadesCubiertas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var especialidadesCubiertas = await _context.EspecialidadesCubiertas.FindAsync(id);
            if (especialidadesCubiertas == null)
            {
                return NotFound();
            }
            ViewData["Especialidad"] = new SelectList(_context.Especialidad, "Id", "Nombre", especialidadesCubiertas.Especialidad);
            ViewData["Poliza"] = new SelectList(_context.Poliza, "Id", "Estado", especialidadesCubiertas.Poliza);
            return View(especialidadesCubiertas);
        }

        // POST: EspecialidadesCubiertas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Especialidad,MayorRiesgo,Poliza")] EspecialidadesCubiertas especialidadesCubiertas)
        {
            if (id != especialidadesCubiertas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(especialidadesCubiertas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EspecialidadesCubiertasExists(especialidadesCubiertas.Id))
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
            ViewData["Especialidad"] = new SelectList(_context.Especialidad, "Id", "Nombre", especialidadesCubiertas.Especialidad);
            ViewData["Poliza"] = new SelectList(_context.Poliza, "Id", "Estado", especialidadesCubiertas.Poliza);
            return View(especialidadesCubiertas);
        }

        // GET: EspecialidadesCubiertas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var especialidadesCubiertas = await _context.EspecialidadesCubiertas
                .Include(e => e.EspecialidadNavigation)
                .Include(e => e.PolizaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (especialidadesCubiertas == null)
            {
                return NotFound();
            }

            return View(especialidadesCubiertas);
        }

        // POST: EspecialidadesCubiertas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var especialidadesCubiertas = await _context.EspecialidadesCubiertas.FindAsync(id);
            _context.EspecialidadesCubiertas.Remove(especialidadesCubiertas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EspecialidadesCubiertasExists(int id)
        {
            return _context.EspecialidadesCubiertas.Any(e => e.Id == id);
        }
    }
}
