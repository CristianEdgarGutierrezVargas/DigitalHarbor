using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios.Entidades
{
    public class Empleado
    {
        public string nombre { get; set; }
        public string paterno { get; set; }
        public string materno { get; set; }
        public string email { get; set; }
        public bool estado { get; set; }
    }
}
