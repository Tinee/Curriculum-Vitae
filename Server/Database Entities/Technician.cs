using System.ComponentModel.DataAnnotations;
using Enums;

namespace Database_Entities
{
    public class Technician
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Percentage { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public TechnicianType Type { get; set; }
    }
}
