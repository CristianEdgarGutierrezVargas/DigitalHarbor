using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD_DigitalHarbor;
using BD_DigitalHarbor.Model;
using BD_DigitalHarbor.Interfaces;

namespace BD_DigitalHarbor.CRUD
{
    public class CEmpleado: IEmpleado
    {
        private DIGITAL_HARBOREntitiesV2 contex;
        public void CreateEmpleado(string nombre, string paterno, string materno, string email, bool estado)
        {
            contex = new DIGITAL_HARBOREntitiesV2();
            EMPLEADO item= new EMPLEADO();
            item.NOMBRE=nombre;
            item.PATERNO=paterno;
            item.MATERNO=materno;
            item.EMAIL=email;   
            item.ESTADO=estado; 
            contex.EMPLEADO.Add(item); 
            contex.SaveChanges();
        }
    }
}
