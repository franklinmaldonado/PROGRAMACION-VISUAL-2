using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto.Entidades
{
    public class Categoria
    {
        [Key]
        public int cod_Categoria { get; set; }
        public string nom_Descripcion { get; set; }

        public List<Producto> Productos { get; set; }
    }
}
