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
    public class RecargoCuotasController : Controller
    {
        private readonly LFbrokersContext _context;

        public RecargoCuotasController(LFbrokersContext context)
        {
            _context = context;
        }

        // GET: RecargoCuotas
        public async Task<IActionResult> Index()
        {
            var lFbrokersContext = _context.RecargoCuotas.Include(r => r.AseguradoraNavigation);
            return View(await lFbrokersContext.ToListAsync());
        }

        // GET: RecargoCuotas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recargoCuotas = await _context.RecargoCuotas
                .Include(r => r.AseguradoraNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recargoCuotas == null)
            {
                return NotFound();
            }

            return View(recargoCuotas);
        }

        // GET: RecargoCuotas/Create
        public IActionResult Create()
        {
            ViewData["Aseguradora"] = new SelectList(_context.Aseguradora, "Id", "Nombre");
            return View();
        }

        // POST: RecargoCuotas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Aseguradora,CantidadCuotas,RecargoFinanciero")] RecargoCuotas recargoCuotas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recargoCuotas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Aseguradora"] = new SelectList(_context.Aseguradora, "Id", "Nombre", recargoCuotas.Aseguradora);
            return View(recargoCuotas);
        }

        // GET: RecargoCuotas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recargoCuotas = await _context.RecargoCuotas.FindAsync(id);
            if (recargoCuotas == null)
            {
                return NotFound();
            }
            ViewData["Aseguradora"] = new SelectList(_context.Aseguradora, "Id", "Nombre", recargoCuotas.Aseguradora);
            return View(recargoCuotas);
        }

        // POST: RecargoCuotas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Aseguradora,CantidadCuotas,RecargoFinanciero")] RecargoCuotas recargoCuotas)
        {
            if (id != recargoCuotas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recargoCuotas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecargoCuotasExists(recargoCuotas.Id))
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
            ViewData["Aseguradora"] = new SelectList(_context.Aseguradora, "Id", "Nombre", recargoCuotas.Aseguradora);
            return View(recargoCuotas);
        }

        // GET: RecargoCuotas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recargoCuotas = await _context.RecargoCuotas
                .Include(r => r.AseguradoraNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recargoCuotas == null)
            {
                return NotFound();
            }

            return View(recargoCuotas);
        }

        // POST: RecargoCuotas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recargoCuotas = await _context.RecargoCuotas.FindAsync(id);
            _context.RecargoCuotas.Remove(recargoCuotas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecargoCuotasExists(int id)
        {
            return _context.RecargoCuotas.Any(e => e.Id == id);
        }
    }
}
