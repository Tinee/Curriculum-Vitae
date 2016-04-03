using System.ComponentModel.DataAnnotations;

namespace Database_Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [StringLength(128)]
        public string Firstname { get; set; }
        [StringLength(128)]
        public string Lastname { get; set; }
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public virtual Company Company { get; set; }
    }
}
