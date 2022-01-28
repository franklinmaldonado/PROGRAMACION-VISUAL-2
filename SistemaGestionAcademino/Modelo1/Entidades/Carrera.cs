using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo1.Entidades
{
    public class Carrera
    {
        public int CarreraId { get; set; }
        public float CostoCredito { get; set; }
        public List<Matricula> Matriculas { get; set; }
        public string Nombre { get; set; }
    }
}
