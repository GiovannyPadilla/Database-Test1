using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test1.Models
{
    public class Carrera
    {
        
        [Key]
        public int id { get; set; }
        [MaxLength(100)]
        public String Nombre { get; set; }
        public int facultadId { get; set; }
        [ForeignKey("facultadId")]
        public Facultad facultad { get; set; }
    }
}

