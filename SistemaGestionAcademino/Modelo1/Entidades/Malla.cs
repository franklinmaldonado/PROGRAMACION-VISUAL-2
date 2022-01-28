using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo1.Entidades
{
    public class Malla
    {
        public Carrera Carrera { get; set; }
        public int CarreraId { get; set; }
        public int MallaId { get; set; }
        public Materia Materia { get; set; }
        public int MateriaId { get; set; }
        public string Nivel { get; set; }
        public List<Prerequisito> Prerequisitos { get; set; }
    }
}
