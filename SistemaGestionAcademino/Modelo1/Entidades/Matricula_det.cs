using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo1.Entidades
{
    public class Matricula_det
    {
        public Calificacion Calificacion { get; set; }
        public Curso Curso { get; set; }
        public int CursoId { get; set; }
        public Matricula Matricula { get; set; }
        public int Matricula_detId { get; set; }
        public int MstriculaId { get; set; }
    }
}
