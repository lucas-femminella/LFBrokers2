using System;
using System.Collections.Generic;

namespace LFbrokersV2.Models
{
    public partial class Localidad
    {
        public Localidad()
        {
            CodigoPostal = new HashSet<CodigoPostal>();
        }

        public int Id { get; set; }
        public string Localidad1 { get; set; }
        public int Provincia { get; set; }

        public Provincia ProvinciaNavigation { get; set; }
        public ICollection<CodigoPostal> CodigoPostal { get; set; }
    }
}
