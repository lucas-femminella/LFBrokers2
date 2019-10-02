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
    public class ProductoAseguradorasController : Controller
    {
        private readonly LFbrokersContext _context;

        public ProductoAseguradorasController(LFbrokersContext context)
        {
            _context = context;
        }

        // GET: ProductoAseguradoras
        public async Task<IActionResult> Index()
        {
            var lFbrokersContext = _context.ProductoAseguradora.Include(p => p.AseguradoraNavigation).Include(p => p.ProductoNavigation);
            return View(await lFbrokersContext.ToListAsync());
        }

        // GET: ProductoAseguradoras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productoAseguradora = await _context.ProductoAseguradora
                .Include(p => p.AseguradoraNavigation)
                .Include(p => p.ProductoNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productoAseguradora == null)
            {
                return NotFound();
            }

            return View(productoAseguradora);
        }

        // GET: ProductoAseguradoras/Create
        public IActionResult Create()
        {
            ViewData["Aseguradora"] = new SelectList(_context.Aseguradora, "Id", "Nombre");
            ViewData["Producto"] = new SelectList(_context.Producto, "Id", "Producto1");
            return View();
        }

        // POST: ProductoAseguradoras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Producto,Aseguradora,Activo,ComisionPrimaBase")] ProductoAseguradora productoAseguradora)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productoAseguradora);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Aseguradora"] = new SelectList(_context.Aseguradora, "Id", "Nombre", productoAseguradora.Aseguradora);
            ViewData["Producto"] = new SelectList(_context.Producto, "Id", "Producto1", productoAseguradora.Producto);
            return View(productoAseguradora);
        }

        // GET: ProductoAseguradoras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productoAseguradora = await _context.ProductoAseguradora.FindAsync(id);
            if (productoAseguradora == null)
            {
                return NotFound();
            }
            ViewData["Aseguradora"] = new SelectList(_context.Aseguradora, "Id", "Nombre", productoAseguradora.Aseguradora);
            ViewData["Producto"] = new SelectList(_context.Producto, "Id", "Producto1", productoAseguradora.Producto);
            return View(productoAseguradora);
        }

        // POST: ProductoAseguradoras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Producto,Aseguradora,Activo,ComisionPrimaBase")] ProductoAseguradora productoAseguradora)
        {
            if (id != productoAseguradora.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productoAseguradora);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoAseguradoraExists(productoAseguradora.Id))
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
            ViewData["Aseguradora"] = new SelectList(_context.Aseguradora, "Id", "Nombre", productoAseguradora.Aseguradora);
            ViewData["Producto"] = new SelectList(_context.Producto, "Id", "Producto1", productoAseguradora.Producto);
            return View(productoAseguradora);
        }

        // GET: ProductoAseguradoras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productoAseguradora = await _context.ProductoAseguradora
                .Include(p => p.AseguradoraNavigation)
                .Include(p => p.ProductoNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productoAseguradora == null)
            {
                return NotFound();
            }

            return View(productoAseguradora);
        }

        // POST: ProductoAseguradoras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productoAseguradora = await _context.ProductoAseguradora.FindAsync(id);
            _context.ProductoAseguradora.Remove(productoAseguradora);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductoAseguradoraExists(int id)
        {
            return _context.ProductoAseguradora.Any(e => e.Id == id);
        }
    }
}
