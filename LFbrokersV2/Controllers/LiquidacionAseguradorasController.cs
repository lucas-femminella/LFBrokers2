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
    public class LiquidacionAseguradorasController : Controller
    {
        private readonly LFbrokersContext _context;

        public LiquidacionAseguradorasController(LFbrokersContext context)
        {
            _context = context;
        }

        // GET: LiquidacionAseguradoras
        public async Task<IActionResult> Index()
        {
            var lFbrokersContext = _context.LiquidacionAseguradora.Include(l => l.AseguradoraNavigation);
            return View(await lFbrokersContext.ToListAsync());
        }

        // GET: LiquidacionAseguradoras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var liquidacionAseguradora = await _context.LiquidacionAseguradora
                .Include(l => l.AseguradoraNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (liquidacionAseguradora == null)
            {
                return NotFound();
            }

            return View(liquidacionAseguradora);
        }

        // GET: LiquidacionAseguradoras/Create
        public IActionResult Create()
        {
            ViewData["Aseguradora"] = new SelectList(_context.Aseguradora, "Id", "Nombre");
            return View();
        }

        // POST: LiquidacionAseguradoras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Aseguradora,FechaInicio,FechaFin,Monto")] LiquidacionAseguradora liquidacionAseguradora)
        {
            if (ModelState.IsValid)
            {
                _context.Add(liquidacionAseguradora);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Aseguradora"] = new SelectList(_context.Aseguradora, "Id", "Nombre", liquidacionAseguradora.Aseguradora);
            return View(liquidacionAseguradora);
        }

        // GET: LiquidacionAseguradoras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var liquidacionAseguradora = await _context.LiquidacionAseguradora.FindAsync(id);
            if (liquidacionAseguradora == null)
            {
                return NotFound();
            }
            ViewData["Aseguradora"] = new SelectList(_context.Aseguradora, "Id", "Nombre", liquidacionAseguradora.Aseguradora);
            return View(liquidacionAseguradora);
        }

        // POST: LiquidacionAseguradoras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Aseguradora,FechaInicio,FechaFin,Monto")] LiquidacionAseguradora liquidacionAseguradora)
        {
            if (id != liquidacionAseguradora.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(liquidacionAseguradora);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LiquidacionAseguradoraExists(liquidacionAseguradora.Id))
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
            ViewData["Aseguradora"] = new SelectList(_context.Aseguradora, "Id", "Nombre", liquidacionAseguradora.Aseguradora);
            return View(liquidacionAseguradora);
        }

        // GET: LiquidacionAseguradoras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var liquidacionAseguradora = await _context.LiquidacionAseguradora
                .Include(l => l.AseguradoraNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (liquidacionAseguradora == null)
            {
                return NotFound();
            }

            return View(liquidacionAseguradora);
        }

        // POST: LiquidacionAseguradoras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var liquidacionAseguradora = await _context.LiquidacionAseguradora.FindAsync(id);
            _context.LiquidacionAseguradora.Remove(liquidacionAseguradora);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LiquidacionAseguradoraExists(int id)
        {
            return _context.LiquidacionAseguradora.Any(e => e.Id == id);
        }
    }
}
