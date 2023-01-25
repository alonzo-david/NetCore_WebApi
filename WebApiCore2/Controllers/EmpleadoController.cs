using Microsoft.AspNetCore.Mvc;
using WebApiCore2.BE;
using WebApiCore2.BLL;
using WebApiCore2.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiCore2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        // GET: api/<EmpleadoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmpleadoController>/5
        [HttpGet("{id}")]
        public IEnumerable<Empleado_BE> Get(int id)
        {
            EmpleadoModel model = new EmpleadoModel();
            Empleado_BE item = new Empleado_BE
            {
                id_empleado = id,
            };

            using (var db = new Empleado_BLL())
            {
                model.LEmpleados = db.ListarEmpleadoID(item, (General_BLL.enum_conection)1);
            }

            return model.LEmpleados.ToList();
        }

        // POST api/<EmpleadoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmpleadoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmpleadoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
