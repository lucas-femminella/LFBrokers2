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
    public class EspecialidadPrimaPorSumaController : Controller
    {
        private readonly LFbrokersContext _context;

        public EspecialidadPrimaPorSumaController(LFbrokersContext context)
        {
            _context = context;
        }

        // GET: EspecialidadPrimaPorSuma
        public async Task<IActionResult> Index()
        {
            var lFbrokersContext = _context.EspecialidadPrimaPorSuma.Include(e => e.EspecialidadNavigation).Include(e => e.ProductoAseguradoraNavigation);
            return View(await lFbrokersContext.ToListAsync());
        }

        // GET: EspecialidadPrimaPorSuma/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var especialidadPrimaPorSuma = await _context.EspecialidadPrimaPorSuma
                .Include(e => e.EspecialidadNavigation)
                .Include(e => e.ProductoAseguradoraNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (especialidadPrimaPorSuma == null)
            {
                return NotFound();
            }

            return View(especialidadPrimaPorSuma);
        }

        // GET: EspecialidadPrimaPorSuma/Create
        public IActionResult Create()
        {
            ViewData["Especialidad"] = new SelectList(_context.Especialidad, "Id", "Nombre");
            ViewData["ProductoAseguradora"] = new SelectList(_context.ProductoAseguradora, "Id", "Id");
            return View();
        }

        // POST: EspecialidadPrimaPorSuma/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Especialidad,PrimaBase,SumaAsegurada,ProductoAseguradora,EspecialidadCodigoExterno,PrimaVigenteDesde")] EspecialidadPrimaPorSuma especialidadPrimaPorSuma)
        {
            if (ModelState.IsValid)
            {
                _context.Add(especialidadPrimaPorSuma);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Especialidad"] = new SelectList(_context.Especialidad, "Id", "Nombre", especialidadPrimaPorSuma.Especialidad);
            ViewData["ProductoAseguradora"] = new SelectList(_context.ProductoAseguradora, "Id", "Id", especialidadPrimaPorSuma.ProductoAseguradora);
            return View(especialidadPrimaPorSuma);
        }

        // GET: EspecialidadPrimaPorSuma/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var especialidadPrimaPorSuma = await _context.EspecialidadPrimaPorSuma.FindAsync(id);
            if (especialidadPrimaPorSuma == null)
            {
                return NotFound();
            }
            ViewData["Especialidad"] = new SelectList(_context.Especialidad, "Id", "Nombre", especialidadPrimaPorSuma.Especialidad);
            ViewData["ProductoAseguradora"] = new SelectList(_context.ProductoAseguradora, "Id", "Id", especialidadPrimaPorSuma.ProductoAseguradora);
            return View(especialidadPrimaPorSuma);
        }

        // POST: EspecialidadPrimaPorSuma/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Especialidad,PrimaBase,SumaAsegurada,ProductoAseguradora,EspecialidadCodigoExterno,PrimaVigenteDesde")] EspecialidadPrimaPorSuma especialidadPrimaPorSuma)
        {
            if (id != especialidadPrimaPorSuma.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(especialidadPrimaPorSuma);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EspecialidadPrimaPorSumaExists(especialidadPrimaPorSuma.Id))
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
            ViewData["Especialidad"] = new SelectList(_context.Especialidad, "Id", "Nombre", especialidadPrimaPorSuma.Especialidad);
            ViewData["ProductoAseguradora"] = new SelectList(_context.ProductoAseguradora, "Id", "Id", especialidadPrimaPorSuma.ProductoAseguradora);
            return View(especialidadPrimaPorSuma);
        }

        // GET: EspecialidadPrimaPorSuma/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var especialidadPrimaPorSuma = await _context.EspecialidadPrimaPorSuma
                .Include(e => e.EspecialidadNavigation)
                .Include(e => e.ProductoAseguradoraNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (especialidadPrimaPorSuma == null)
            {
                return NotFound();
            }

            return View(especialidadPrimaPorSuma);
        }

        // POST: EspecialidadPrimaPorSuma/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var especialidadPrimaPorSuma = await _context.EspecialidadPrimaPorSuma.FindAsync(id);
            _context.EspecialidadPrimaPorSuma.Remove(especialidadPrimaPorSuma);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EspecialidadPrimaPorSumaExists(int id)
        {
            return _context.EspecialidadPrimaPorSuma.Any(e => e.Id == id);
        }
    }
}
