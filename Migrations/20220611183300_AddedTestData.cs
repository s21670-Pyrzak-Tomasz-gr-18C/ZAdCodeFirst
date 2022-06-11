using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationCodeFirst.Migrations
{
    public partial class AddedTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prescriptions_doctors_IdDoctor",
                table: "prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_prescriptions_patients_IdPatient",
                table: "prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_prescriptions_IdDoctor",
                table: "prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_prescriptions_IdPatient",
                table: "prescriptions");

            migrationBuilder.AddColumn<int>(
                name: "DoctorIdDoctor",
                table: "prescriptions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientIdPatient",
                table: "prescriptions",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "doctors",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "kowalski@wp.pl", "Jan", "Kowalski" },
                    { 2, "nowak@wp.pl", "Antoni", "Nowak" }
                });

            migrationBuilder.InsertData(
                table: "medicaments",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Opis 1", "Lek1", "Type 1" },
                    { 2, "Opis 2", "Lek2", "Type 2" }
                });

            migrationBuilder.InsertData(
                table: "patients",
                columns: new[] { "IdPatient", "BithDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna", "Piernik" },
                    { 2, new DateTime(2000, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magdalena", "Kalafior" }
                });

            migrationBuilder.InsertData(
                table: "prescriptions",
                columns: new[] { "IdPrescription", "Date", "DoctorIdDoctor", "DueDate", "IdDoctor", "IdPatient", "PatientIdPatient" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, null },
                    { 2, new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, null }
                });

            migrationBuilder.InsertData(
                table: "prescription_Medicaments",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[] { 1, 2, "Opis dodatkowy", 0 });

            migrationBuilder.InsertData(
                table: "prescription_Medicaments",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[] { 2, 2, "Opis dodatkowy2", 0 });

            migrationBuilder.CreateIndex(
                name: "IX_prescriptions_DoctorIdDoctor",
                table: "prescriptions",
                column: "DoctorIdDoctor");

            migrationBuilder.CreateIndex(
                name: "IX_prescriptions_PatientIdPatient",
                table: "prescriptions",
                column: "PatientIdPatient");

            migrationBuilder.AddForeignKey(
                name: "FK_prescriptions_doctors_DoctorIdDoctor",
                table: "prescriptions",
                column: "DoctorIdDoctor",
                principalTable: "doctors",
                principalColumn: "IdDoctor",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_prescriptions_patients_PatientIdPatient",
                table: "prescriptions",
                column: "PatientIdPatient",
                principalTable: "patients",
                principalColumn: "IdPatient",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prescriptions_doctors_DoctorIdDoctor",
                table: "prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_prescriptions_patients_PatientIdPatient",
                table: "prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_prescriptions_DoctorIdDoctor",
                table: "prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_prescriptions_PatientIdPatient",
                table: "prescriptions");

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "IdDoctor",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "IdDoctor",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "IdPatient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "IdPatient",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "medicaments",
                keyColumn: "IdMedicament",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "medicaments",
                keyColumn: "IdMedicament",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "DoctorIdDoctor",
                table: "prescriptions");

            migrationBuilder.DropColumn(
                name: "PatientIdPatient",
                table: "prescriptions");

            migrationBuilder.CreateIndex(
                name: "IX_prescriptions_IdDoctor",
                table: "prescriptions",
                column: "IdDoctor");

            migrationBuilder.CreateIndex(
                name: "IX_prescriptions_IdPatient",
                table: "prescriptions",
                column: "IdPatient");

            migrationBuilder.AddForeignKey(
                name: "FK_prescriptions_doctors_IdDoctor",
                table: "prescriptions",
                column: "IdDoctor",
                principalTable: "doctors",
                principalColumn: "IdDoctor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_prescriptions_patients_IdPatient",
                table: "prescriptions",
                column: "IdPatient",
                principalTable: "patients",
                principalColumn: "IdPatient",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
