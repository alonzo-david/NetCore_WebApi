using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiCore2.BE
{
    public class Empleado_BE
    {
        [Key]
        public int id_empleado { get; set; }
        public string? nombres { get; set; }
        public string? apellidos { get; set; }
        public string? dpi { get; set; }
    }
}
