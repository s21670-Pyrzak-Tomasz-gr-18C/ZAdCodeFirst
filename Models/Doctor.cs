using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationCodeFirst.Models
{
    public class Doctor
    {
        [Key]
        public int IdDoctor { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength (100)]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }

        public virtual ICollection<Prescription> Prescriiptions { get; set; }
    }
}
