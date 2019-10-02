using System;
using System.Collections.Generic;

namespace LFbrokersV2.Models
{
    public partial class Aseguradora
    {
        public Aseguradora()
        {
            LiquidacionAseguradora = new HashSet<LiquidacionAseguradora>();
            ProductoAseguradora = new HashSet<ProductoAseguradora>();
            RecargoCuotas = new HashSet<RecargoCuotas>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set; }

        public ICollection<LiquidacionAseguradora> LiquidacionAseguradora { get; set; }
        public ICollection<ProductoAseguradora> ProductoAseguradora { get; set; }
        public ICollection<RecargoCuotas> RecargoCuotas { get; set; }
    }
}
