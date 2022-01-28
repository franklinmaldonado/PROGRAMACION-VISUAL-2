using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto.Entidades
{
    public class Cliente
    {
        [Key]
        public int cod_Cliente { get; set; }
        public string nom_Clinete { get; set; }
        public string direc_Cliente { get; set; }
        public int cod_Distrito { get; set; }
        public string sexo { get; set; }
        public int DNI { get; set; }
        public int RUC { get; set; }
        public int Telefono { get; set; }
        public string Celular { get; set; }

        public List<Distrito> Distritos { get; set; }
        public List<OrdenPedido> OrdenPedidos { get; set; }
    }
}
