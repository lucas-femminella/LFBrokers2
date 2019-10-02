using System;
using System.Collections.Generic;

namespace LFbrokersV2.Models
{
    public partial class CodigoPostal
    {
        public CodigoPostal()
        {
            Persona = new HashSet<Persona>();
        }

        public int Id { get; set; }
        public string CodigoPostal1 { get; set; }
        public int Localidad { get; set; }
        public int Zona { get; set; }

        public Localidad LocalidadNavigation { get; set; }
        public Zona ZonaNavigation { get; set; }
        public ICollection<Persona> Persona { get; set; }
    }
}
