using System;
using System.Collections.Generic;

namespace LFbrokersV2.Models
{
    public partial class LiquidacionPolizaCuota
    {
        public int Id { get; set; }
        public int Poliza { get; set; }
        public int NroCuota { get; set; }
        public string Estado { get; set; }
        public decimal Monto { get; set; }
        public int LiquidacionAseguradora { get; set; }

        public LiquidacionAseguradora LiquidacionAseguradoraNavigation { get; set; }
        public Poliza PolizaNavigation { get; set; }
    }
}
