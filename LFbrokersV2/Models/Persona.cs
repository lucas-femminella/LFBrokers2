using System;
using System.Collections.Generic;

namespace LFbrokersV2.Models
{
    public partial class Persona
    {
        public Persona()
        {
            PolizaAgenteNavigation = new HashSet<Poliza>();
            PolizaClienteNavigation = new HashSet<Poliza>();
        }

        public int Id { get; set; }
        public string TipoDocumento { get; set; }
        public string NroDocumento { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public int? Piso { get; set; }
        public string Departamento { get; set; }
        public string Obervaciones { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int CodigoPostal { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Tipo { get; set; }

        public CodigoPostal CodigoPostalNavigation { get; set; }
        public ICollection<Poliza> PolizaAgenteNavigation { get; set; }
        public ICollection<Poliza> PolizaClienteNavigation { get; set; }
    }
}
