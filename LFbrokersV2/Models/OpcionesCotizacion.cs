using System;
using System.Collections.Generic;

namespace LFbrokersV2.Models
{
    public partial class OpcionesCotizacion
    {
        public int Id { get; set; }
        public int Poliza { get; set; }
        public decimal PrimaBase { get; set; }
        public decimal? SumaAsegurada { get; set; }
        public decimal? RecargoPrima { get; set; }
        public decimal? ComisionPrima { get; set; }
        public decimal? PrimaPoliza { get; set; }
        public decimal? PremioTotal { get; set; }
        public decimal? PremioCuota { get; set; }
        public string Condicion { get; set; }
        public int Aseguradora { get; set; }
        public bool? OpcionElegida { get; set; }

        public Poliza PolizaNavigation { get; set; }
    }
}
