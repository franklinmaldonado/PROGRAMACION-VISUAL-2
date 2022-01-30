using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto.Entidades
{
    public class Empleado
    {
        [Key]
        public int cod_Empleado { get; set; }
        public string nom_Empleado { get; set; }
        public string direc_Empleado { get; set; }
        public string Cargo { get; set; }
        public string Edad { get; set; }
        public int Telefono { get; set; }
        public string Celular { get; set; }
        public DateTime Ingreso { get; set; }
        public string Clave { get; set; }

        public Distrito Distrito { get; set; }
        public int cod_Distrito { get; set; }
        public List<Usuario> Usuario { get; set; }
        public List<OrdenPedido> OrdenPedido { get; set; }

    }
}

