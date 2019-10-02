using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LFbrokersV2.Models
{
    public class CotizarModel
    {
        public Persona persona { get; set; }
        public List<EspecialidadCliente> especialidadClientes { get; set; }
        public Poliza poliza { get; set; }

        public int Id { get; set; }

    }
}
