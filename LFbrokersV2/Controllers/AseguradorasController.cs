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
    public class AseguradorasController : Controller
    {
        private readonly LFbrokersContext _context;

        public AseguradorasController(LFbrokersContext context)
        {
            _context = context;
        }

        // GET: Aseguradoras
        public async Task<IActionResult> Index()
        {
            return View(await _context.Aseguradora.ToListAsync());
        }

        // GET: Aseguradoras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aseguradora = await _context.Aseguradora
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aseguradora == null)
            {
                return NotFound();
            }

            return View(aseguradora);
        }

        // GET: Aseguradoras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Aseguradoras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Codigo")] Aseguradora aseguradora)
        {
            if (ModelState.IsValid)
            {

                _context.Add(aseguradora);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aseguradora);
        }

        // GET: Aseguradoras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aseguradora = await _context.Aseguradora.FindAsync(id);
            if (aseguradora == null)
            {
                return NotFound();
            }
            return View(aseguradora);
        }

        // POST: Aseguradoras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Codigo")] Aseguradora aseguradora)
        {
            if (id != aseguradora.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aseguradora);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AseguradoraExists(aseguradora.Id))
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
            return View(aseguradora);
        }

        // GET: Aseguradoras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aseguradora = await _context.Aseguradora
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aseguradora == null)
            {
                return NotFound();
            }

            return View(aseguradora);
        }

        // POST: Aseguradoras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aseguradora = await _context.Aseguradora.FindAsync(id);
            _context.Aseguradora.Remove(aseguradora);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AseguradoraExists(int id)
        {
            return _context.Aseguradora.Any(e => e.Id == id);
        }
    }
}
