using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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

        [NotMapped]
        public int SelectedEspecialidades { get; set; }
        [NotMapped]
        public int[] Especialidades { get; set; }
        [NotMapped]
        public List<SelectListItem> EspecialidadesList { get; set; }
        [NotMapped]
        public List<SelectListItem> TipoDocumentoList
        {
            get
            {
                List<SelectListItem> selectedList = new List<SelectListItem>();
                selectedList.Add(new SelectListItem { Value = "D.N.I", Text = "D.N.I" });
                selectedList.Add(new SelectListItem { Value = "L.E", Text = "L.E" });
                selectedList.Add(new SelectListItem { Value = "L.C.", Text = "L.C." });
                selectedList.Add(new SelectListItem { Value = "Pasaporte", Text = "Pasaporte" });
                return selectedList;
            }
            set {;}
        }

    }
}
