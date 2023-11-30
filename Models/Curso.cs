using System.ComponentModel.DataAnnotations;

namespace logicLearn.Models
{
    public class Curso
    {
        [Key]
        public int CursoID { get; set; }
        public string NombreCurso { get; set; }
        public float Precio { get; set; }

        public ICollection<Inscripcion> Inscripciones { get; set; }

        public ICollection<Tema> Temas { get; set; }
    }
}