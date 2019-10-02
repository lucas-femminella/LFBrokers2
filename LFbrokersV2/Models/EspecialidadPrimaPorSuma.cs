using System;
using System.Collections.Generic;

namespace LFbrokersV2.Models
{
    public partial class EspecialidadPrimaPorSuma
    {
        public int Id { get; set; }
        public int Especialidad { get; set; }
        public decimal PrimaBase { get; set; }
        public decimal SumaAsegurada { get; set; }
        public int ProductoAseguradora { get; set; }
        public string EspecialidadCodigoExterno { get; set; }
        public DateTime PrimaVigenteDesde { get; set; }

        public Especialidad EspecialidadNavigation { get; set; }
        public ProductoAseguradora ProductoAseguradoraNavigation { get; set; }
    }
}
