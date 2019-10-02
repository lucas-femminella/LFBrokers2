using System;
using System.Collections.Generic;

namespace LFbrokersV2.Models
{
    public partial class Producto
    {
        public Producto()
        {
            ProductoAseguradora = new HashSet<ProductoAseguradora>();
        }

        public int Id { get; set; }
        public string Producto1 { get; set; }
        public string Descripcion { get; set; }
        public int Ramo { get; set; }

        public Ramo RamoNavigation { get; set; }
        public ICollection<ProductoAseguradora> ProductoAseguradora { get; set; }
    }
}
