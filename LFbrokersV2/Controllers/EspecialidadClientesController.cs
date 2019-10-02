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
    public class EspecialidadClientesController : Controller
    {
        private readonly LFbrokersContext _context;

        public EspecialidadClientesController(LFbrokersContext context)
        {
            _context = context;
        }

        // GET: EspecialidadClientes
        public async Task<IActionResult> Index()
        {
            var lFbrokersContext = _context.EspecialidadCliente.Include(e => e.EspecialidadNavigation);
            return View(await lFbrokersContext.ToListAsync());
        }

        // GET: EspecialidadClientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var especialidadCliente = await _context.EspecialidadCliente
                .Include(e => e.EspecialidadNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (especialidadCliente == null)
            {
                return NotFound();
            }

            return View(especialidadCliente);
        }

        // GET: EspecialidadClientes/Create
        public IActionResult Create()
        {
            ViewData["Especialidad"] = new SelectList(_context.Especialidad, "Id", "Nombre");
            return View();
        }

        // POST: EspecialidadClientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Especialidad,Cliente,Vigente")] EspecialidadCliente especialidadCliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(especialidadCliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Especialidad"] = new SelectList(_context.Especialidad, "Id", "Nombre", especialidadCliente.Especialidad);
            return View(especialidadCliente);
        }

        // GET: EspecialidadClientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var especialidadCliente = await _context.EspecialidadCliente.FindAsync(id);
            if (especialidadCliente == null)
            {
                return NotFound();
            }
            ViewData["Especialidad"] = new SelectList(_context.Especialidad, "Id", "Nombre", especialidadCliente.Especialidad);
            return View(especialidadCliente);
        }

        // POST: EspecialidadClientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Especialidad,Cliente,Vigente")] EspecialidadCliente especialidadCliente)
        {
            if (id != especialidadCliente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(especialidadCliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EspecialidadClienteExists(especialidadCliente.Id))
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
            ViewData["Especialidad"] = new SelectList(_context.Especialidad, "Id", "Nombre", especialidadCliente.Especialidad);
            return View(especialidadCliente);
        }

        // GET: EspecialidadClientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var especialidadCliente = await _context.EspecialidadCliente
                .Include(e => e.EspecialidadNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (especialidadCliente == null)
            {
                return NotFound();
            }

            return View(especialidadCliente);
        }

        // POST: EspecialidadClientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var especialidadCliente = await _context.EspecialidadCliente.FindAsync(id);
            _context.EspecialidadCliente.Remove(especialidadCliente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EspecialidadClienteExists(int id)
        {
            return _context.EspecialidadCliente.Any(e => e.Id == id);
        }
    }
}
