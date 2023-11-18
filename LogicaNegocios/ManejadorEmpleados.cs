using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD_DigitalHarbor.Interfaces;
using BD_DigitalHarbor.CRUD;
using LogicaNegocios.Entidades;

namespace LogicaNegocios
{
    public class ManejadorEmpleados
    {
        IEmpleado controlador = new CEmpleado();

        public void CreateEmpleado(Empleado item)
        {
            controlador.CreateEmpleado(item.nombre,item.paterno,item.materno,item.email,item.estado);
        }
    }
}
