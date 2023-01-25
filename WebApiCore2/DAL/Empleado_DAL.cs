using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiCore2.BE;

namespace WebApiCore2.DAL
{
    public class Empleado_DAL : IDisposable
    {
        public void Dispose() { }

        public List<Empleado_BE> ListarEmpleadoID(Empleado_BE item, string db)
        {
            List<Empleado_BE> result = new List<Empleado_BE>();

            using (var model = new Conector_SQL(db, "SP_EMPLEADO"))
            {
                model.Command.Parameters.AddWithValue("@id_empleado", item.id_empleado);

                result = model.GetData<Empleado_BE>();
            }

            return result;
        }
    }
}
