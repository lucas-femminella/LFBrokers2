using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LFbrokersV2.Models;
using System.Data;
using System.Data.SqlClient;

namespace LFbrokersV2.Controllers
{
    public class CotizacionesController : Controller
    {
        private readonly LFbrokersContext _context;

        public CotizacionesController(LFbrokersContext context)
        {
            _context = context;
        }


        // GET: Cotizaciones
        public async Task<IActionResult> Index()
        {
            var lFbrokersContext = _context.Persona.Include(p => p.CodigoPostalNavigation);

            return View(await lFbrokersContext.ToListAsync());
        }

        // GET: Cotizaciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _context.Persona
                .Include(p => p.CodigoPostalNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }

        // GET: Cotizaciones/Create
        public IActionResult Create()
        {
            var vm = new Persona();
            vm.EspecialidadesList = DataUtils.getSelectListItems("Especialidad", "ID", "Nombre");

            ViewData["CodigoPostal"] = new SelectList(_context.CodigoPostal, "Id", "CodigoPostal1");
            ViewData["Localidad"] = "Localidad";
            ViewData["Provincia"] = "Provincia";

            return View(vm);
        }


        [HttpGet]
        public String getLocation(string id)
        {
            Dictionary<String, String> localidadMap = DataUtils.querySingleRecord("CodigoPostal", new string[] { "Localidad" }, " ID = '" + id + "'");

            String localidadId = localidadMap["Localidad"];

            Dictionary<String, String> provinciaMap = DataUtils.querySingleRecord("Localidad", new string[] { "Localidad", "Provincia" }, " ID = '" + localidadId + "'");
            String response = provinciaMap["Localidad"] + ",";
            String pronvinciaId = provinciaMap["Provincia"];
            provinciaMap = DataUtils.querySingleRecord("Provincia", new string[] { "Provincia" }, " ID = '" + pronvinciaId + "'");
            response += provinciaMap["Provincia"] ;

            return response;
        } 


        // POST: Cotizaciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TipoDocumento,NroDocumento,Nombres,Apellidos,Calle,Altura,Piso,Departamento,Obervaciones,FechaNacimiento,CodigoPostal,Telefono,Celular,Email,Tipo")] Persona persona)
        {
            ViewBag.Message = null;

            if (ModelState.IsValid)
                {
                    int personaId = DataUtils.getId("Persona");

                    persona.Id = personaId;
                    persona.Tipo = "Cliente Potencial";


                    _context.Add(persona);
                    await _context.SaveChangesAsync();

                    // Insert Poliza
                    int polizaId = DataUtils.getId("Poliza");
                    String polizaEstado = "A Cotizar";
                
                    // TODO: Get Agente
                    DataUtils.DML("Insert into Poliza (Id, Cliente, Estado, CantidadCuotas, ProductoAseguradora, RecargosFinancieros, Impuestos, SumaAsegurada, PrimaBase, Agente) values (" + polizaId + "," + personaId + ",'" + polizaEstado + "'," + 0 + "," + 0 + "," + 0 + "," + 0 + "," + 0 + "," + 0 +",'"+ personaId + "')");

                    // Insert Especialidades
                    String[] especialidadesIds = Request.Form["SelectedEspecialidades"];
                        int especialidadClienteId = DataUtils.getId("EspecialidadCliente");
                        if (especialidadesIds.Length > 0)
                        {
                            foreach (String especialidadId in especialidadesIds)
                            {
                                // TODO Work with Arrays
                                DataUtils.DML("Insert into EspecialidadCliente (Id, Especialidad, Cliente, Vigente) values (" + especialidadClienteId + ",'" + especialidadId + "'," + persona.Id + ",'" + true + "')");
                            }
                        }

                    //return RedirectToAction(nameof(Index));
                }
                ViewData["CodigoPostal"] = new SelectList(_context.CodigoPostal, "Id", "CodigoPostal1", persona.CodigoPostal);

            ViewBag.Message = "Success";
            return View(persona);
        }

        // GET: Cotizaciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _context.Persona.FindAsync(id);
            if (persona == null)
            {
                return NotFound();
            }
            ViewData["CodigoPostal"] = new SelectList(_context.CodigoPostal, "Id", "CodigoPostal1", persona.CodigoPostal);
            return View(persona);
        }

        // POST: Cotizaciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TipoDocumento,NroDocumento,Nombres,Apellidos,Calle,Altura,Piso,Departamento,Obervaciones,FechaNacimiento,CodigoPostal,Telefono,Celular,Email,Tipo")] Persona persona)
        {
            if (id != persona.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(persona);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonaExists(persona.Id))
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
            ViewData["CodigoPostal"] = new SelectList(_context.CodigoPostal, "Id", "CodigoPostal1", persona.CodigoPostal);
            return View(persona);
        }

        // GET: Cotizaciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _context.Persona
                .Include(p => p.CodigoPostalNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }

        // POST: Cotizaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var persona = await _context.Persona.FindAsync(id);
            _context.Persona.Remove(persona);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonaExists(int id)
        {
            return _context.Persona.Any(e => e.Id == id);
        }
    }
}
