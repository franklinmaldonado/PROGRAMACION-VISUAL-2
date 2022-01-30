using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Proyecto.Entidades
{
    public class Presentacion
    {
        [Key]
        public int cod_Presentacion { get; set; }
        public string nom_Presentacion { get; set; }

        public List<Producto> Producto { get; set; }
        
    }
}
