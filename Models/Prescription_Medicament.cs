﻿using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationCodeFirst.Models
{
    public class Prescription_Medicament
    {
        
       
        public int IdMedicament { get; set; }
       
        public int IdPrescription { get; set; }
        public int Dose { get; set; }
       
        public string Details { get; set; }

        public Prescription Prescription { get; set; }
        public Medicament Medicament { get; set; }

    }
}
