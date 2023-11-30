using System.ComponentModel.DataAnnotations;

namespace logicLearn.Models
{
    public class Material
    {
        [Key]
        public int MaterialID { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public string Contenido { get; set; }
        public ICollection<Tema> Temas { get; set; }
    }
}