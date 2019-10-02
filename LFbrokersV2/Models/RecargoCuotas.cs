using System;
using System.Collections.Generic;

namespace LFbrokersV2.Models
{
    public partial class RecargoCuotas
    {
        public int Id { get; set; }
        public int Aseguradora { get; set; }
        public int CantidadCuotas { get; set; }
        public decimal RecargoFinanciero { get; set; }

        public Aseguradora AseguradoraNavigation { get; set; }
    }
}
