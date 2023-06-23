using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorParqueo
{
    public class ClienteModel
    {
        public string nombre { get; set; }
        public string cedula { get; set; }
        public string local { get; set; }
        public string tipoVehiculo { get; set; }
        public string fechaLlegad { get; set; }
        public string horaLlegada { get; set; }
        public string fechaSalida { get; set; }
        public string horaSalida { get; set; }
        public string estado { get; set; }

    }
}
