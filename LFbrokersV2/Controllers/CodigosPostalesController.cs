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
    public class CodigosPostalesController : Controller
    {
        private readonly LFbrokersContext _context;

        public CodigosPostalesController(LFbrokersContext context)
        {
            _context = context;
        }

        // GET: CodigosPostales
        public async Task<IActionResult> Index()
        {
            var lFbrokersContext = _context.CodigoPostal.Include(c => c.LocalidadNavigation).Include(c => c.ZonaNavigation);
            return View(await lFbrokersContext.ToListAsync());
        }

        // GET: CodigosPostales/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var codigoPostal = await _context.CodigoPostal
                .Include(c => c.LocalidadNavigation)
                .Include(c => c.ZonaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (codigoPostal == null)
            {
                return NotFound();
            }

            return View(codigoPostal);
        }

        // GET: CodigosPostales/Create
        public IActionResult Create()
        {
            ViewData["Localidad"] = new SelectList(_context.Localidad, "Id", "Localidad1");
            ViewData["Zona"] = new SelectList(_context.Zona, "Id", "Zona1");
            return View();
        }

        // POST: CodigosPostales/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CodigoPostal1,Localidad,Zona")] CodigoPostal codigoPostal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(codigoPostal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Localidad"] = new SelectList(_context.Localidad, "Id", "Localidad1", codigoPostal.Localidad);
            ViewData["Zona"] = new SelectList(_context.Zona, "Id", "Zona1", codigoPostal.Zona);
            return View(codigoPostal);
        }

        // GET: CodigosPostales/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var codigoPostal = await _context.CodigoPostal.FindAsync(id);
            if (codigoPostal == null)
            {
                return NotFound();
            }
            ViewData["Localidad"] = new SelectList(_context.Localidad, "Id", "Localidad1", codigoPostal.Localidad);
            ViewData["Zona"] = new SelectList(_context.Zona, "Id", "Zona1", codigoPostal.Zona);
            return View(codigoPostal);
        }

        // POST: CodigosPostales/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CodigoPostal1,Localidad,Zona")] CodigoPostal codigoPostal)
        {
            if (id != codigoPostal.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(codigoPostal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CodigoPostalExists(codigoPostal.Id))
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
            ViewData["Localidad"] = new SelectList(_context.Localidad, "Id", "Localidad1", codigoPostal.Localidad);
            ViewData["Zona"] = new SelectList(_context.Zona, "Id", "Zona1", codigoPostal.Zona);
            return View(codigoPostal);
        }

        // GET: CodigosPostales/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var codigoPostal = await _context.CodigoPostal
                .Include(c => c.LocalidadNavigation)
                .Include(c => c.ZonaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (codigoPostal == null)
            {
                return NotFound();
            }

            return View(codigoPostal);
        }

        // POST: CodigosPostales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var codigoPostal = await _context.CodigoPostal.FindAsync(id);
            _context.CodigoPostal.Remove(codigoPostal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CodigoPostalExists(int id)
        {
            return _context.CodigoPostal.Any(e => e.Id == id);
        }
    }
}
