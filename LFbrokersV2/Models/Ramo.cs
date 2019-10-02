using System;
using System.Collections.Generic;

namespace LFbrokersV2.Models
{
    public partial class Ramo
    {
        public Ramo()
        {
            Producto = new HashSet<Producto>();
        }

        public int Id { get; set; }
        public string Ramo1 { get; set; }

        public ICollection<Producto> Producto { get; set; }
    }
}
