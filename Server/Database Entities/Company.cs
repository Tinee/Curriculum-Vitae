using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Database_Entities
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        [StringLength(128)]
        public string Name { get; set; }
        [StringLength(1000)]
        [DataType(DataType.Url)]
        public string Website { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool Active { get; set; }

    }
}
