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
    public class CActividades: IActividades
    {
        private DIGITAL_HARBOREntitiesV2 contex;
        public void CreateActividad(DateTime fechaIncio, DateTime fechaFin,string descripcion, long idEmpleado)
        {
            contex = new DIGITAL_HARBOREntitiesV2();
            ACTIVIDADES item= new ACTIVIDADES();
            item.FECHA_INICIO = fechaIncio;
            item.FECHA_FIN = fechaFin;
            item.DESCRIPCION = descripcion;
            item.ID_EMPLEADO = idEmpleado;
            contex.ACTIVIDADES.Add(item); 
            contex.SaveChanges();
        }
    }
}
