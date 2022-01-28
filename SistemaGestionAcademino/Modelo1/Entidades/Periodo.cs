using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo1.Entidades
{
    public class Periodo
    {
        public List<Curso> Cursos { get; set; }
        public string Estado { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaInicio { get; set; }
        public List<Matricula> Matriculas { get; set; }
        public int PeriodoId { get; set; }
    }
}
