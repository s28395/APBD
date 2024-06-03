using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    IdDoctor = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Doctor_pk", x => x.IdDoctor);
                });

            migrationBuilder.CreateTable(
                name: "Medicament",
                columns: table => new
                {
                    IdMedicament = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Medicament_pk", x => x.IdMedicament);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    IdPatient = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("Patient_pk", x => x.IdPatient);
                });

            migrationBuilder.CreateTable(
                name: "Prescription",
                columns: table => new
                {
                    IdPrescription = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    IdPatient = table.Column<int>(type: "int", nullable: false),
                    IdDoctor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Prescription_pk", x => x.IdPrescription);
                    table.ForeignKey(
                        name: "Prescription_Doctor",
                        column: x => x.IdDoctor,
                        principalTable: "Doctor",
                        principalColumn: "IdDoctor",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Prescription_Patient",
                        column: x => x.IdPatient,
                        principalTable: "Patient",
                        principalColumn: "IdPatient",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PrescriptionMedicament",
                columns: table => new
                {
                    IdMedicament = table.Column<int>(type: "int", nullable: false),
                    IdPrescription = table.Column<int>(type: "int", nullable: false),
                    Dose = table.Column<int>(type: "int", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PrescriptionMedicament_pk", x => new { x.IdMedicament, x.IdPrescription });
                    table.ForeignKey(
                        name: "PrescriptionMedicament_Medicament",
                        column: x => x.IdMedicament,
                        principalTable: "Medicament",
                        principalColumn: "IdMedicament",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "PrescriptionMedicament_Prescription",
                        column: x => x.IdPrescription,
                        principalTable: "Prescription",
                        principalColumn: "IdPrescription",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "john.smith@gmail.com", "John", "Smith" },
                    { 2, "emily.johnson@gmail.com", "Emily", "Johnson" },
                    { 3, "michael.williams@gmail.com", "Michael", "Williams" },
                    { 4, "sarah.jones@gmail.com", "Sarah", "Jones" },
                    { 5, "james.brown@gmail.com", "James", "Brown" },
                    { 6, "jennifer.davis@gmail.com", "Jennifer", "Davis" },
                    { 7, "david.miller@gmail.com", "David", "Miller" },
                    { 8, "jessica.wilson@gmail.com", "Jessica", "Wilson" },
                    { 9, "matthew.moore@gmail.com", "Matthew", "Moore" },
                    { 10, "ashley.taylor@gmail.com", "Ashley", "Taylor" },
                    { 11, "christopher.anderson@gmail.com", "Christopher", "Anderson" },
                    { 12, "amanda.thomas@gmail.com", "Amanda", "Thomas" },
                    { 13, "daniel.jackson@gmail.com", "Daniel", "Jackson" },
                    { 14, "brittany.white@gmail.com", "Brittany", "White" },
                    { 15, "kevin.harris@gmail.com", "Kevin", "Harris" }
                });

            migrationBuilder.InsertData(
                table: "Medicament",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Pain reliever", "Aspirin", "Analgesic" },
                    { 2, "Antibiotic", "Amoxicillin", "Antibiotic" },
                    { 3, "Pain reliever", "Ibuprofen", "Analgesic" },
                    { 4, "Pain reliever", "Acetaminophen", "Analgesic" },
                    { 5, "Blood pressure medication", "Lisinopril", "Antihypertensive" },
                    { 6, "Cholesterol-lowering medication", "Atorvastatin", "Statins" },
                    { 7, "Diabetes medication", "Metformin", "Antidiabetic" },
                    { 8, "Acid reducer", "Omeprazole", "Proton pump inhibitor" },
                    { 9, "Anti-inflammatory", "Prednisone", "Corticosteroid" },
                    { 10, "Thyroid hormone replacement", "Levothyroxine", "Thyroid hormone" },
                    { 11, "Cholesterol-lowering medication", "Simvastatin", "Statins" },
                    { 12, "Bronchodilator", "Albuterol", "Bronchodilator" },
                    { 13, "Antidepressant", "Citalopram", "Antidepressant" },
                    { 14, "Blood thinner", "Warfarin", "Anticoagulant" },
                    { 15, "Diuretic", "Furosemide", "Diuretic" }
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "IdPatient", "Birthdate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emma", "Johnson" },
                    { 2, new DateTime(1985, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noah", "Williams" },
                    { 3, new DateTime(1982, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Olivia", "Jones" },
                    { 4, new DateTime(1995, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Liam", "Brown" },
                    { 5, new DateTime(1988, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ava", "Davis" },
                    { 6, new DateTime(1976, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "William", "Miller" },
                    { 7, new DateTime(1992, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isabella", "Wilson" },
                    { 8, new DateTime(1980, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mason", "Moore" },
                    { 9, new DateTime(1987, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sophia", "Taylor" },
                    { 10, new DateTime(1974, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ethan", "Anderson" },
                    { 11, new DateTime(1998, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amelia", "Thomas" },
                    { 12, new DateTime(1983, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexander", "Jackson" },
                    { 13, new DateTime(1991, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charlotte", "White" },
                    { 14, new DateTime(1979, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel", "Harris" },
                    { 15, new DateTime(1989, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Madison", "Clark" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_IdDoctor",
                table: "Prescription",
                column: "IdDoctor");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_IdPatient",
                table: "Prescription",
                column: "IdPatient");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionMedicament_IdPrescription",
                table: "PrescriptionMedicament",
                column: "IdPrescription");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrescriptionMedicament");

            migrationBuilder.DropTable(
                name: "Medicament");

            migrationBuilder.DropTable(
                name: "Prescription");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Patient");
        }
    }
}
