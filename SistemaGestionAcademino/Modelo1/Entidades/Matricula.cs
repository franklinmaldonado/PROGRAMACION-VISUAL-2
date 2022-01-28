using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo1.Entidades
{
    public class Matricula
    {
        public Carrera Carrrera { get; set; }
        public int CarerraId { get; set; }
        public string Estado { get; set; }
        public Estudinate Estudinate { get; set; }
        public int EstudianteId { get; set; }
        public DateTime Fecha { get; set; }
        public  List<Matricula> Matriculas { get; set; }
        public int MatriculaId { get; set; }
        public Periodo Periodo { get; set; }
        public int PeriodoId { get; set; }
    }
}
