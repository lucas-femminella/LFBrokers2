using System;
using System.Collections.Generic;

namespace LFbrokersV2.Models
{
    public partial class Especialidad
    {
        public Especialidad()
        {
            EspecialidadCliente = new HashSet<EspecialidadCliente>();
            EspecialidadPrimaPorSuma = new HashSet<EspecialidadPrimaPorSuma>();
            EspecialidadesCubiertas = new HashSet<EspecialidadesCubiertas>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Observaciones { get; set; }
        public int Producto { get; set; }
        public int Riesgo { get; set; }

        public ICollection<EspecialidadCliente> EspecialidadCliente { get; set; }
        public ICollection<EspecialidadPrimaPorSuma> EspecialidadPrimaPorSuma { get; set; }
        public ICollection<EspecialidadesCubiertas> EspecialidadesCubiertas { get; set; }
    }
}
