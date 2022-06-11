using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationCodeFirst.Models
{
    public class Prescription
    {
        [Key]
        public int IdPrescription { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        [Required]
        [ForeignKey("IdDoctor")]
        public int IdPatient { get; set; }
        [Required]
        [ForeignKey("IdPatient")]
        public int IdDoctor { get; set; }
        
        public virtual Patient Patient { get; set; }
        
        public virtual Doctor Doctor { get; set; }

        public virtual ICollection<Prescription_Medicament> prescriptionsmedicamensts { get; set; }

    }
}
