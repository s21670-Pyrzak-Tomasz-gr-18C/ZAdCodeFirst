using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationCodeFirst.Models
{
    public class Patient
    {
        [Key]
        public int IdPatient { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        [Required]
        public DateTime BithDate { get; set; }  
        
        public virtual ICollection<Prescription> Prescriiptions { get; set; }
    }
}
