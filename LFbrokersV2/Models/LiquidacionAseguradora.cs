using System;
using System.Collections.Generic;

namespace LFbrokersV2.Models
{
    public partial class LiquidacionAseguradora
    {
        public LiquidacionAseguradora()
        {
            LiquidacionPolizaCuota = new HashSet<LiquidacionPolizaCuota>();
        }

        public int Id { get; set; }
        public int Aseguradora { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal Monto { get; set; }

        public Aseguradora AseguradoraNavigation { get; set; }
        public ICollection<LiquidacionPolizaCuota> LiquidacionPolizaCuota { get; set; }
    }
}
