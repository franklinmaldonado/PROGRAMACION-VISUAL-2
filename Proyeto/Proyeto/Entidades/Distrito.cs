using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto.Entidades
{
    public class Distrito
    {
    [Key]
        public int cod_Distrito { get; set; }
        public string nom_Distrito { get; set; }

        public List<Proveedor> Proveedor { get; set; }
        public List<Cliente> Cliente { get; set; }
        public List<Empleado> Empleado { get; set; }
    }
}
