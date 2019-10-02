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
    public class LiquidacionPolizaCuotaController : Controller
    {
        private readonly LFbrokersContext _context;

        public LiquidacionPolizaCuotaController(LFbrokersContext context)
        {
            _context = context;
        }

        // GET: LiquidacionPolizaCuota
        public async Task<IActionResult> Index()
        {
            var lFbrokersContext = _context.LiquidacionPolizaCuota.Include(l => l.LiquidacionAseguradoraNavigation).Include(l => l.PolizaNavigation);
            return View(await lFbrokersContext.ToListAsync());
        }

        // GET: LiquidacionPolizaCuota/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var liquidacionPolizaCuota = await _context.LiquidacionPolizaCuota
                .Include(l => l.LiquidacionAseguradoraNavigation)
                .Include(l => l.PolizaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (liquidacionPolizaCuota == null)
            {
                return NotFound();
            }

            return View(liquidacionPolizaCuota);
        }

        // GET: LiquidacionPolizaCuota/Create
        public IActionResult Create()
        {
            ViewData["LiquidacionAseguradora"] = new SelectList(_context.LiquidacionAseguradora, "Id", "Id");
            ViewData["Poliza"] = new SelectList(_context.Poliza, "Id", "Estado");
            return View();
        }

        // POST: LiquidacionPolizaCuota/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Poliza,NroCuota,Estado,Monto,LiquidacionAseguradora")] LiquidacionPolizaCuota liquidacionPolizaCuota)
        {
            if (ModelState.IsValid)
            {
                _context.Add(liquidacionPolizaCuota);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LiquidacionAseguradora"] = new SelectList(_context.LiquidacionAseguradora, "Id", "Id", liquidacionPolizaCuota.LiquidacionAseguradora);
            ViewData["Poliza"] = new SelectList(_context.Poliza, "Id", "Estado", liquidacionPolizaCuota.Poliza);
            return View(liquidacionPolizaCuota);
        }

        // GET: LiquidacionPolizaCuota/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var liquidacionPolizaCuota = await _context.LiquidacionPolizaCuota.FindAsync(id);
            if (liquidacionPolizaCuota == null)
            {
                return NotFound();
            }
            ViewData["LiquidacionAseguradora"] = new SelectList(_context.LiquidacionAseguradora, "Id", "Id", liquidacionPolizaCuota.LiquidacionAseguradora);
            ViewData["Poliza"] = new SelectList(_context.Poliza, "Id", "Estado", liquidacionPolizaCuota.Poliza);
            return View(liquidacionPolizaCuota);
        }

        // POST: LiquidacionPolizaCuota/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Poliza,NroCuota,Estado,Monto,LiquidacionAseguradora")] LiquidacionPolizaCuota liquidacionPolizaCuota)
        {
            if (id != liquidacionPolizaCuota.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(liquidacionPolizaCuota);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LiquidacionPolizaCuotaExists(liquidacionPolizaCuota.Id))
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
            ViewData["LiquidacionAseguradora"] = new SelectList(_context.LiquidacionAseguradora, "Id", "Id", liquidacionPolizaCuota.LiquidacionAseguradora);
            ViewData["Poliza"] = new SelectList(_context.Poliza, "Id", "Estado", liquidacionPolizaCuota.Poliza);
            return View(liquidacionPolizaCuota);
        }

        // GET: LiquidacionPolizaCuota/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var liquidacionPolizaCuota = await _context.LiquidacionPolizaCuota
                .Include(l => l.LiquidacionAseguradoraNavigation)
                .Include(l => l.PolizaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (liquidacionPolizaCuota == null)
            {
                return NotFound();
            }

            return View(liquidacionPolizaCuota);
        }

        // POST: LiquidacionPolizaCuota/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var liquidacionPolizaCuota = await _context.LiquidacionPolizaCuota.FindAsync(id);
            _context.LiquidacionPolizaCuota.Remove(liquidacionPolizaCuota);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LiquidacionPolizaCuotaExists(int id)
        {
            return _context.LiquidacionPolizaCuota.Any(e => e.Id == id);
        }
    }
}
