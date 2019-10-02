using System;
using System.Collections.Generic;

namespace LFbrokersV2.Models
{
    public partial class Provincia
    {
        public Provincia()
        {
            Localidad = new HashSet<Localidad>();
        }

        public int Id { get; set; }
        public string Provincia1 { get; set; }

        public ICollection<Localidad> Localidad { get; set; }
    }
}
