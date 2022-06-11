using Microsoft.EntityFrameworkCore;
using System;

namespace WebApplicationCodeFirst.Models
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions options) : base(options)
        {
        }

        protected MainDbContext()
        {
        }

        public DbSet<Patient> patients { get; set; }
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Prescription> prescriptions { get; set; }
        public DbSet<Prescription_Medicament> prescription_Medicaments { get; set; }
        public DbSet<Medicament> medicaments { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //    optionsBuilder.UseSqlServer("Data Source=db-mssql;Initial Catalog=s21670;Integrated Security=True");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Prescription_Medicament>(p =>
            {
                p.HasKey(p => new { p.IdMedicament, p.IdPrescription });
                p.HasOne(p => p.Medicament).WithMany(p => p.PrescriptionsMedicaments).HasForeignKey(p => p.IdMedicament);
                p.HasOne(p => p.Prescription).WithMany(p => p.prescriptionsmedicamensts).HasForeignKey(p => p.IdPrescription);
                p.Property(p => p.Dose); //moze byc NULL
                p.Property(p => p.Details).IsRequired().HasMaxLength(100);  

                p.HasData(
                    new Prescription_Medicament {IdMedicament =1, IdPrescription = 2, Details = "Opis dodatkowy"  },
                    new Prescription_Medicament {IdMedicament =2, IdPrescription = 2, Details = "Opis dodatkowy2"  } 
                    );
                
            });

            modelBuilder.Entity<Doctor>(p =>
            {
                p.HasData(
                    new Doctor {IdDoctor = 1, FirstName = "Jan", LastName = "Kowalski", Email = "kowalski@wp.pl" },
                    new Doctor {IdDoctor = 2, FirstName = "Antoni", LastName = "Nowak", Email = "nowak@wp.pl"});
            });

            modelBuilder.Entity<Patient>(p =>
            {
                p.HasData(
                    new Patient { IdPatient = 1, FirstName = "Anna", LastName = "Piernik", BithDate = DateTime.Parse("2000-02-15") },
                    new Patient {IdPatient = 2, FirstName = "Magdalena", LastName= "Kalafior", BithDate = DateTime.Parse("2000-02-14")
                    });
            });

            modelBuilder.Entity<Medicament>(p =>
            {
                p.HasData(
                    new Medicament { IdMedicament = 1, Name="Lek1", Description = "Opis 1", Type= "Type 1" },
                    new Medicament { IdMedicament = 2, Name="Lek2", Description = "Opis 2", Type= "Type 2" }
                    );
            });

            modelBuilder.Entity<Prescription>(p =>
            {
                p.HasData(
                   new Prescription { IdPrescription = 1, Date = DateTime.Parse("2022-05-13"), DueDate = DateTime.Parse("2022-06-12"), IdDoctor = 1, IdPatient = 1 },
                   new Prescription { IdPrescription = 2, Date = DateTime.Parse("2022-05-13"), DueDate = DateTime.Parse("2022-06-12"), IdDoctor = 2, IdPatient = 2 }
               );
            });

         
        }

    }
}
