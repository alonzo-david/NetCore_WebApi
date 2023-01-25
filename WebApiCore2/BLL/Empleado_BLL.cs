using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiCore2.BE;
using WebApiCore2.DAL;

namespace WebApiCore2.BLL
{
    public class Empleado_BLL : IDisposable
    {
        public void Dispose() { }
        public List<Empleado_BE> ListarEmpleadoID(Empleado_BE item, General_BLL.enum_conection bdd)
        {
            List<Empleado_BE> result;
            using (var model = new Empleado_DAL())
            {
                result = model.ListarEmpleadoID(item, bdd.ToString());
            }
            return result;
        }
    }
}
