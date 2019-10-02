using System;
using System.Collections.Generic;

namespace LFbrokersV2.Models
{
    public partial class ProductoAseguradora
    {
        public ProductoAseguradora()
        {
            EspecialidadPrimaPorSuma = new HashSet<EspecialidadPrimaPorSuma>();
        }

        public int Id { get; set; }
        public int Producto { get; set; }
        public int Aseguradora { get; set; }
        public bool Activo { get; set; }
        public decimal ComisionPrimaBase { get; set; }

        public Aseguradora AseguradoraNavigation { get; set; }
        public Producto ProductoNavigation { get; set; }
        public ICollection<EspecialidadPrimaPorSuma> EspecialidadPrimaPorSuma { get; set; }
    }
}
