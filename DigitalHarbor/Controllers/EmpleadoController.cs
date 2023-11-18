using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using LogicaNegocios;
using LogicaNegocios.Entidades;
using Newtonsoft.Json;

namespace DigitalHarbor.Controllers
{
    public class EmpleadoController : ApiController
    {
        ManejadorEmpleados manejador = new ManejadorEmpleados();
        //// POST api/values
        public void Post([FromBody] string value)
        {
            Empleado item=JsonConvert.DeserializeObject<Empleado>(value);
            manejador.CreateEmpleado(item);
        }
     
    }
}
