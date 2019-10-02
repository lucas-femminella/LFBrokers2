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
    public class RamoesController : Controller
    {
        private readonly LFbrokersContext _context;

        public RamoesController(LFbrokersContext context)
        {
            _context = context;
        }

        // GET: Ramoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ramo.ToListAsync());
        }

        // GET: Ramoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ramo = await _context.Ramo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ramo == null)
            {
                return NotFound();
            }

            return View(ramo);
        }

        // GET: Ramoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ramoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ramo1")] Ramo ramo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ramo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ramo);
        }

        // GET: Ramoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ramo = await _context.Ramo.FindAsync(id);
            if (ramo == null)
            {
                return NotFound();
            }
            return View(ramo);
        }

        // POST: Ramoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ramo1")] Ramo ramo)
        {
            if (id != ramo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ramo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RamoExists(ramo.Id))
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
            return View(ramo);
        }

        // GET: Ramoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ramo = await _context.Ramo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ramo == null)
            {
                return NotFound();
            }

            return View(ramo);
        }

        // POST: Ramoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ramo = await _context.Ramo.FindAsync(id);
            _context.Ramo.Remove(ramo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RamoExists(int id)
        {
            return _context.Ramo.Any(e => e.Id == id);
        }
    }
}
