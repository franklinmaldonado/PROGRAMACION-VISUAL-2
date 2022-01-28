using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo1.Entidades
{
    public class Curso
    {
        public int CursoId { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaInicio { get; set; }
        public string Jornada { get; set; }
        public Materia Materia { get; set; }
        public int MateriaId { get; set; }
        public List<Matricula_det> Matricula_Dets { get; set; }
        public string Nombre { get; set; }
        public Periodo Periodo { get; set; }
        public int PeriodoId { get; set; }

    }
}
