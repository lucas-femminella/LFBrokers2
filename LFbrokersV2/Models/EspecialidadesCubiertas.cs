using System;
using System.Collections.Generic;

namespace LFbrokersV2.Models
{
    public partial class EspecialidadesCubiertas
    {
        public int Id { get; set; }
        public int Especialidad { get; set; }
        public bool? MayorRiesgo { get; set; }
        public int Poliza { get; set; }

        public Especialidad EspecialidadNavigation { get; set; }
        public Poliza PolizaNavigation { get; set; }
    }
}
