using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto.Entidades
{
    public class DetalleOrdenPedido
    {
        [Key]
        public int num_OrdenPedido { get; set; }
        public int cod_Prodructo { get; set; }
        public string nom_Prod { get; set; }
        public int Catidad { get; set; }
        public decimal precio_venta { get; set; }
        public decimal importe { get; set; }

        public List<Producto> Productos { get; set; }
    }
}
