using System.ComponentModel.DataAnnotations;

namespace Database_Entities
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(300)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [StringLength(128)] 
        public string Firstname { get; set; }
        [Required]
        [StringLength(128)]
        public string Lastname { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(128)]
        public string Password { get; set; }
    }
}
