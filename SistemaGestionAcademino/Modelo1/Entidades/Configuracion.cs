using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo1.Entidades
{
    public class Configuracion
    {
        public int CreditoMaximo { get; set; }
        public string EsculaNombre { get; set; }
        public float NotaMinima { get; set; }
        public float PesoNota1 { get; set; }
        public float PesoNota2 { get; set; }
        public float PesoNota3 { get; set; }
        //relacion de periodos 

        public Periodo PeriodoVigente{ get; set; }
        public int PeriodoId { get; set; }
        


    }
}
