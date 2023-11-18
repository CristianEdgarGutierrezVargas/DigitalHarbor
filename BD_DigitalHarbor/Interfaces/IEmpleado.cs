using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_DigitalHarbor.Interfaces
{
    public interface IEmpleado
    {
        void CreateEmpleado(string nombre, string paterno, string materno,string email,bool estado);

    }
}
