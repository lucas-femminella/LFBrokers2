using System;
using System.Collections.Generic;

namespace LFbrokersV2.Models
{
    public partial class Poliza
    {
        public Poliza()
        {
            EspecialidadesCubiertas = new HashSet<EspecialidadesCubiertas>();
            LiquidacionPolizaCuota = new HashSet<LiquidacionPolizaCuota>();
            OpcionesCotizacion = new HashSet<OpcionesCotizacion>();
        }

        public int Id { get; set; }
        public int Cliente { get; set; }
        public string Estado { get; set; }
        public int CantidadCuotas { get; set; }
        public int ProductoAseguradora { get; set; }
        public decimal RecargosFinancieros { get; set; }
        public decimal Impuestos { get; set; }
        public decimal SumaAsegurada { get; set; }
        public decimal PrimaBase { get; set; }
        public decimal? RecargoPrima { get; set; }
        public decimal? ComisionPrima { get; set; }
        public decimal? PrimaPoliza { get; set; }
        public decimal? PremioTotal { get; set; }
        public decimal? PremioCuota { get; set; }
        public DateTime? VigenciaDesde { get; set; }
        public DateTime? VigenciaHasta { get; set; }
        public string Matricula { get; set; }
        public string NumeroPoliza { get; set; }
        public int Agente { get; set; }
        public string MotivoRecotizacion { get; set; }

        public Persona AgenteNavigation { get; set; }
        public Persona ClienteNavigation { get; set; }
        public ICollection<EspecialidadesCubiertas> EspecialidadesCubiertas { get; set; }
        public ICollection<LiquidacionPolizaCuota> LiquidacionPolizaCuota { get; set; }
        public ICollection<OpcionesCotizacion> OpcionesCotizacion { get; set; }
    }
}
