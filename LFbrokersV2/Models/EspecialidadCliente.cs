using System;
using System.Collections.Generic;

namespace LFbrokersV2.Models
{
    public partial class EspecialidadCliente
    {
        public int Id { get; set; }
        public int Especialidad { get; set; }
        public int Cliente { get; set; }
        public bool? Vigente { get; set; }

        public Especialidad EspecialidadNavigation { get; set; }
    }
}
