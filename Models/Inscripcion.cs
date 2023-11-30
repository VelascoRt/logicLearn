using System.ComponentModel.DataAnnotations;

namespace logicLearn.Models
{
    public class Inscripcion
    {
        [Key]
        public int InscripcionID { get; set; }
        public int CursoID { get; set; }
        public int ClienteID { get; set; }
        public int PagoID { get; set; }
        public Curso Cursos { get; set; }
        public Cliente Clientes { get; set; }
        public Plan PlanDePago { get; set; }
    }
}