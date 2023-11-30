using System.ComponentModel.DataAnnotations;

namespace logicLearn.Models
{
    public class Profesor
    {
        [Key]
        public int ProfesorID { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public ICollection<Tema> Temas { get; set; }
    }
}