using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto.Entidades
{
    public class Producto
    {
        [Key]
        public int cod_Producto { get; set; }
        public string nom_Producto { get; set; }
        public decimal precio_Venta { get; set; }
        public DateTime fecha_Venc { get; set; }
        public int Stock { get; set; }

        


        //public List<Presentacion> Presentacion { get; set; }
        public Presentacion Presentacion { get; set; }
        public int cod_Presentacion { get; set; }
        //public List<Categoria> Categoria { get; set; }
        public Categoria Categoria {get; set;}
        public int cod_Categoria { get; set; }
        public Proveedor Proveedor { get; set; }
        public int cod_Proveedor { get; set; }
        public List<DetalleOrdenPedido> DetalleOrdenPedido { get; set; }
    }
}
