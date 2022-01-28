namespace Modelo1.Entidades
{
    public class Calificacion
    {
        public int CalificaionId { get; set; }

        public Matricula_det Matricula_dett { get; set; }
        public int Matricula_detId { get; set; }
        public float Nota1 { get; set; }
        public float Nota2 { get; set; }
        public float Nota3 { get; set; }
    }
}
