using System.ComponentModel.DataAnnotations;

namespace logicLearn.Models
{
    public class Tema
    {
        [Key]
        public int TemaID { get; set; }
        public int ProfesorID { get; set; }
        public int CursoID { get; set; }
        public int MaterialID { get; set; }
        public Curso Cursos { get; set; }
        public Profesor Profesores { get; set; }
        public Material Materiales { get; set; }
    }
}