using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_DigitalHarbor.Interfaces
{
    public interface IActividades
    {
        void CreateActividad(DateTime fechaIncio, DateTime fechaFin, string descripcion, long idEmpleado);

    }
}
