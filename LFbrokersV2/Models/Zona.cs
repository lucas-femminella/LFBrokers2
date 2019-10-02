using System;
using System.Collections.Generic;

namespace LFbrokersV2.Models
{
    public partial class Zona
    {
        public Zona()
        {
            CodigoPostal = new HashSet<CodigoPostal>();
        }

        public int Id { get; set; }
        public string Zona1 { get; set; }
        public decimal Impuesto { get; set; }

        public ICollection<CodigoPostal> CodigoPostal { get; set; }
    }
}
