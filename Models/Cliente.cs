using System.ComponentModel.DataAnnotations;

namespace logicLearn.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteID { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public ICollection<Inscripcion> Inscripciones { get; set; }
    }
}