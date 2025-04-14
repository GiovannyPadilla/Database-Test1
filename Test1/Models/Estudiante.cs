using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Test1.Models
{
    public class Estudiante
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(50)]
        public String nombre { get; set; }
        [Required]
        [MaxLength(50)]
        public String apellido { get; set; }

        public DateOnly fechaNacimiento { get; set; }
        [AllowNull]
        public Boolean tieneBeca { get; set; }
        public int carreraId { get; set; }
        [ForeignKey("carreraId")]
        public Carrera Carrera { get; set; }

    }
}
