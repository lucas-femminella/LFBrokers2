using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LFbrokersV2.Models;
using Newtonsoft.Json;

namespace LFbrokersV2.Controllers
{
    public class PolizasController : Controller
    {
        private readonly LFbrokersContext _context;

        public PolizasController(LFbrokersContext context)
        {
            _context = context;
        }

        // GET: Polizas
        public async Task<IActionResult> Index()
        {
            var lFbrokersContext = _context.Poliza.Include(p => p.ClienteNavigation).Include(p => p.ClienteNavigation.CodigoPostalNavigation.LocalidadNavigation.ProvinciaNavigation);
            return View(await lFbrokersContext.ToListAsync());
        }

        // GET: Polizas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poliza = await _context.Poliza
               // .Include(p => p.AgenteNavigation)
                .Include(p => p.ClienteNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (poliza == null)
            {
                return NotFound();
            }

            return View(poliza);
        }

        // GET: Polizas/Create
        public IActionResult Create()
        {
           // ViewData["Agente"] = new SelectList(_context.Persona, "Id", "Apellidos");
            ViewData["Cliente"] = new SelectList(_context.Persona, "Id", "Apellidos");
            return View();
        }

        // POST: Polizas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Cliente,Estado,CantidadCuotas,ProductoAseguradora,RecargosFinancieros,Impuestos,SumaAsegurada,PrimaBase,RecargoPrima,ComisionPrima,PrimaPoliza,PremioTotal,PremioCuota,VigenciaDesde,VigenciaHasta,Matricula,NumeroPoliza,Agente,MotivoRecotizacion")] Poliza poliza)
        {
            if (ModelState.IsValid)
            {
                _context.Add(poliza);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

          //  ViewData["Agente"] = new SelectList(_context.Persona, "Id", "Apellidos", poliza.Agente);
            ViewData["Cliente"] = new SelectList(_context.Persona, "Id", "Apellidos", poliza.Cliente);
            return View(poliza);
        }

        // GET: Polizas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();            

            var poliza = await _context.Poliza
               // .Include(p => p.AgenteNavigation)
                .Include(p => p.ClienteNavigation).Include(p => p.ClienteNavigation.CodigoPostalNavigation.ZonaNavigation)
                .Include(p => p.ClienteNavigation.CodigoPostalNavigation.LocalidadNavigation.ProvinciaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
       
            if (poliza == null) return NotFound();

            List<Especialidad> listEspecialidades = DataUtils.getEspecialidades(poliza.Cliente);
            ViewData["Especialidades"] = listEspecialidades;

            int aseguradoraId = 1;
            // TODO: Hardcoded Aseguradora
            ViewData["RecargosFinancieros"] = DataUtils.getRecargosFinancieros(aseguradoraId);
            // TODO: Filter by highest Risk
            ViewData["EpecialidaPrimaPorSuma"] = DataUtils.getEspecialidadPrimaPorSuma(aseguradoraId);
            ViewData["ProductoAseguradoras"] = DataUtils.getProductoAseguradoras();

            return View(poliza);
        }
        public class Cotizaciones {
             public string recargaPrima {get; set;}
             public string condicion {get; set;}
             public string id {get; set;}
             public string sumaAsegurada {get; set;}
             public string primaBase {get; set;}
             public string primaPoliza {get; set;}
             public string comisionPrimaPercent {get; set;}
             public string comisionPrima {get; set;}
             public string premioTotal {get; set;}
             public string premioCuota {get; set;}
             public string cantidadCuotas {get; set;}
             public string impuestos {get; set;}
             public string polizaId {get; set;}
             public string clienteId {get; set;}
             public string recargoFinanciero {get; set;}   
        }

        [HttpGet]
        public String saveCotizaciones(String cotizaciones)
        {
            IList<Cotizaciones> cotizacionesList = JsonConvert.DeserializeObject<List<Cotizaciones>>(cotizaciones);
            if (cotizacionesList.Count > 0){
                int polizaId = Convert.ToInt32(cotizacionesList[0].polizaId);
                int clienteId = Convert.ToInt32(cotizacionesList[0].clienteId);
                decimal impuestos = Convert.ToDecimal(cotizacionesList[0].impuestos);
                int cantidadCuotas =  Convert.ToInt32(cotizacionesList[0].cantidadCuotas);
                int aseguradoraId = 1;
                 // TODO: Aseguradora unhardcode

                // 1 - Update Poliza
                    string query = "Update Poliza Set Estado = '" + "Cotizada"
                        + "', CantidadCuotas = " + cantidadCuotas
                        + ", Impuestos = " +  impuestos
                        + " WHERE Id = '" + polizaId + "'";
                    DataUtils.DML(query);
                    // TODO: Agente Id

                // 2 - Insert EspecialidadesCubiertas
                    List<EspecialidadCliente> listEspecialidades = DataUtils.getEspecialidadesCliente(clienteId);
                    for (int i = 0; i < listEspecialidades.Count; i++) {
                         int espCubiertaId = DataUtils.getId("EspecialidadesCubiertas");
                         // TODO: Mayor riesgo
                         DataUtils.DML("Insert into EspecialidadesCubiertas (Id, Especialidad, MayorRiesgo, Poliza) values (" + espCubiertaId + ",'" + listEspecialidades[i].Id + "','" + false + "','" + polizaId + "')");       
                    }

                // 3 - Insert OpcionesCotizacion
                    // TBD: Riesgo financiero?
                     for (int i = 0; i < cotizacionesList.Count; i++) {
                        Cotizaciones cotizacion = cotizacionesList[i];
                        decimal recargo = Math.Round(Convert.ToDecimal(cotizacion.recargaPrima) / 100, 2);
                        decimal comision = Math.Round(Convert.ToDecimal(cotizacion.comisionPrimaPercent) / 100, 2);
                        int opcionCotizacionId = DataUtils.getId("OpcionesCotizacion");
                        DataUtils.DML("Insert into OpcionesCotizacion (Id, Poliza, PrimaBase, SumaAsegurada, [RecargoPrima%], ComisionPrima, PrimaPoliza, PremioTotal, PremioCuota, Condicion, Aseguradora, OpcionElegida) values (" +
                            opcionCotizacionId 
                            + "," + polizaId
                            + "," + Convert.ToDecimal(cotizacion.primaBase) 
                            + "," + Convert.ToDecimal(cotizacion.sumaAsegurada) 
                            + "," + recargo 
                            + "," + comision 
                            + "," + Convert.ToDecimal(cotizacion.primaPoliza)
                            + "," + Convert.ToDecimal(cotizacion.premioTotal) 
                            + "," + Convert.ToDecimal(cotizacion.premioCuota) 
                            + ",'" + cotizacion.condicion + "'," + aseguradoraId + ",'" + false +"')");
                    }
                
                return "Operacion Exitosa";
            }
            else
            {
                return "Error";
            }

            //return View(_context.Poliza);
        } 


        // POST: Polizas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Cliente,Estado,CantidadCuotas,ProductoAseguradora,RecargosFinancieros,Impuestos,SumaAsegurada,PrimaBase,RecargoPrima,ComisionPrima,PrimaPoliza,PremioTotal,PremioCuota,VigenciaDesde,VigenciaHasta,Matricula,NumeroPoliza,Agente,MotivoRecotizacion")] Poliza poliza)
        {
            if (id != poliza.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(poliza);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PolizaExists(poliza.Id))
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
            //ViewData["Agente"] = new SelectList(_context.Persona, "Id", "Apellidos", poliza.Agente);
            //ViewData["Cliente"] = new SelectList(_context.Persona, "Id", "Apellidos", poliza.Cliente);
            return View(poliza);
        }

        // GET: Polizas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poliza = await _context.Poliza
              //  .Include(p => p.AgenteNavigation)
                .Include(p => p.ClienteNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (poliza == null)
            {
                return NotFound();
            }

            return View(poliza);
        }

        // POST: Polizas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var poliza = await _context.Poliza.FindAsync(id);
            _context.Poliza.Remove(poliza);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PolizaExists(int id)
        {
            return _context.Poliza.Any(e => e.Id == id);
        }
    }
}
