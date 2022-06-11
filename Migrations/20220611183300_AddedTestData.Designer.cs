﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplicationCodeFirst.Models;

namespace WebApplicationCodeFirst.Migrations
{
    [DbContext(typeof(MainDbContext))]
    [Migration("20220611183300_AddedTestData")]
    partial class AddedTestData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplicationCodeFirst.Models.Doctor", b =>
                {
                    b.Property<int>("IdDoctor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdDoctor");

                    b.ToTable("doctors");

                    b.HasData(
                        new
                        {
                            IdDoctor = 1,
                            Email = "kowalski@wp.pl",
                            FirstName = "Jan",
                            LastName = "Kowalski"
                        },
                        new
                        {
                            IdDoctor = 2,
                            Email = "nowak@wp.pl",
                            FirstName = "Antoni",
                            LastName = "Nowak"
                        });
                });

            modelBuilder.Entity("WebApplicationCodeFirst.Models.Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdMedicament");

                    b.ToTable("medicaments");

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            Description = "Opis 1",
                            Name = "Lek1",
                            Type = "Type 1"
                        },
                        new
                        {
                            IdMedicament = 2,
                            Description = "Opis 2",
                            Name = "Lek2",
                            Type = "Type 2"
                        });
                });

            modelBuilder.Entity("WebApplicationCodeFirst.Models.Patient", b =>
                {
                    b.Property<int>("IdPatient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BithDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdPatient");

                    b.ToTable("patients");

                    b.HasData(
                        new
                        {
                            IdPatient = 1,
                            BithDate = new DateTime(2000, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Anna",
                            LastName = "Piernik"
                        },
                        new
                        {
                            IdPatient = 2,
                            BithDate = new DateTime(2000, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Magdalena",
                            LastName = "Kalafior"
                        });
                });

            modelBuilder.Entity("WebApplicationCodeFirst.Models.Prescription", b =>
                {
                    b.Property<int>("IdPrescription")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DoctorIdDoctor")
                        .HasColumnType("int");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDoctor")
                        .HasColumnType("int");

                    b.Property<int>("IdPatient")
                        .HasColumnType("int");

                    b.Property<int?>("PatientIdPatient")
                        .HasColumnType("int");

                    b.HasKey("IdPrescription");

                    b.HasIndex("DoctorIdDoctor");

                    b.HasIndex("PatientIdPatient");

                    b.ToTable("prescriptions");

                    b.HasData(
                        new
                        {
                            IdPrescription = 1,
                            Date = new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2022, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdDoctor = 1,
                            IdPatient = 1
                        },
                        new
                        {
                            IdPrescription = 2,
                            Date = new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2022, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdDoctor = 2,
                            IdPatient = 2
                        });
                });

            modelBuilder.Entity("WebApplicationCodeFirst.Models.Prescription_Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .HasColumnType("int");

                    b.Property<int>("IdPrescription")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Dose")
                        .HasColumnType("int");

                    b.HasKey("IdMedicament", "IdPrescription");

                    b.HasIndex("IdPrescription");

                    b.ToTable("prescription_Medicaments");

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            IdPrescription = 2,
                            Details = "Opis dodatkowy",
                            Dose = 0
                        },
                        new
                        {
                            IdMedicament = 2,
                            IdPrescription = 2,
                            Details = "Opis dodatkowy2",
                            Dose = 0
                        });
                });

            modelBuilder.Entity("WebApplicationCodeFirst.Models.Prescription", b =>
                {
                    b.HasOne("WebApplicationCodeFirst.Models.Doctor", "Doctor")
                        .WithMany("Prescriiptions")
                        .HasForeignKey("DoctorIdDoctor");

                    b.HasOne("WebApplicationCodeFirst.Models.Patient", "Patient")
                        .WithMany("Prescriiptions")
                        .HasForeignKey("PatientIdPatient");

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("WebApplicationCodeFirst.Models.Prescription_Medicament", b =>
                {
                    b.HasOne("WebApplicationCodeFirst.Models.Medicament", "Medicament")
                        .WithMany("PrescriptionsMedicaments")
                        .HasForeignKey("IdMedicament")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplicationCodeFirst.Models.Prescription", "Prescription")
                        .WithMany("prescriptionsmedicamensts")
                        .HasForeignKey("IdPrescription")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicament");

                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("WebApplicationCodeFirst.Models.Doctor", b =>
                {
                    b.Navigation("Prescriiptions");
                });

            modelBuilder.Entity("WebApplicationCodeFirst.Models.Medicament", b =>
                {
                    b.Navigation("PrescriptionsMedicaments");
                });

            modelBuilder.Entity("WebApplicationCodeFirst.Models.Patient", b =>
                {
                    b.Navigation("Prescriiptions");
                });

            modelBuilder.Entity("WebApplicationCodeFirst.Models.Prescription", b =>
                {
                    b.Navigation("prescriptionsmedicamensts");
                });
#pragma warning restore 612, 618
        }
    }
}