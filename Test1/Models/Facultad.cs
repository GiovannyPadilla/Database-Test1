using System.ComponentModel.DataAnnotations;

namespace Test1.Models
{
    public class Facultad
    {
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        [MaxLength(100)]
        public String Nombre { get; set; }
    }
}
