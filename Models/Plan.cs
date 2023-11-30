using System.ComponentModel.DataAnnotations;

namespace logicLearn.Models
{
    public class Plan
    {
        [Key]
        public int PagoID { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public ICollection<Inscripcion> Inscripciones { get; set; }
    }
}