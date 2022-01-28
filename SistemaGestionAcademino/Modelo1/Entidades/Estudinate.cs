using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo1.Entidades
{
    public class Estudinate
    {
        public int EstudianteId { get; set; }
        public List<Matricula> Matriculas { get; set; } 
        public string Nombre { get; set; }
    }
}
