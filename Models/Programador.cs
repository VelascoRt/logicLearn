using System.ComponentModel.DataAnnotations;

namespace logicLearn.Models
{
    public class Programador
    {
        [Key]
        public int ProgramadoresID { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Tarea { get; set; }
    }
}