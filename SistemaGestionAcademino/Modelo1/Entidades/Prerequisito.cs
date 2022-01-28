using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo1.Entidades
{
    public class Prerequisito
    {
        public Malla Malla { get; set; }
        public int MallaId { get; set; }
        public Materia Materia { get; set; }
        public int MateriaId { get; set; }
    }
}
