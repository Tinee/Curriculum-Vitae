using System;
using System.ComponentModel.DataAnnotations;

namespace Database_Entities
{
    public class PersonalLetter
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(Int32.MaxValue)]
        public string Description { get; set; }
        [Required]
        public virtual Company Company { get; set; }
        [Required]
        public int LoginCount { get; set; }
        [Required]
        public bool Active { get; set; }
    }
}
