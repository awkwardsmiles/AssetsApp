using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AssetsApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    DateAcquired = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    InUse = table.Column<bool>(type: "INTEGER", nullable: false),
                    PurchasePrice = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "ID", "DateAcquired", "InUse", "Location", "Name", "PurchasePrice" },
                values: new object[,]
                {
                    { 1, new DateOnly(2022, 8, 15), true, "Computer Lab 1", "Dell Desktop PC", 780.0 },
                    { 2, new DateOnly(2022, 8, 15), true, "Computer Lab 2", "Dell Desktop PC", 780.0 },
                    { 3, new DateOnly(2021, 9, 1), true, "Lecture Theatre A", "Lecture Hall Projector", 2400.0 },
                    { 4, new DateOnly(2022, 1, 18), true, "Seminar Room 3", "Interactive Whiteboard", 3200.0 },
                    { 5, new DateOnly(2019, 5, 20), true, "Science Building", "Electron Microscope", 185000.0 },
                    { 6, new DateOnly(2022, 10, 4), true, "Engineering Workshop", "3D Printer", 4500.0 },
                    { 7, new DateOnly(2021, 3, 12), true, "Main Library", "Library Self-Service Kiosk", 6800.0 },
                    { 8, new DateOnly(2020, 7, 30), true, "Data Centre", "Server Rack", 15500.0 },
                    { 9, new DateOnly(2021, 11, 9), true, "Data Centre", "Network Switch", 1900.0 },
                    { 10, new DateOnly(2021, 6, 22), true, "Design Studio", "Laser Cutter", 12500.0 },
                    { 11, new DateOnly(2020, 2, 14), true, "Chemistry Lab", "Spectrometer", 42000.0 },
                    { 12, new DateOnly(2022, 9, 5), true, "Lecture Theatre B", "Lecture Capture Camera", 1800.0 },
                    { 13, new DateOnly(2023, 1, 16), true, "Admissions Office", "Staff Laptop", 1150.0 },
                    { 14, new DateOnly(2018, 4, 25), false, "Student Services", "Photocopier", 5400.0 },
                    { 15, new DateOnly(2017, 8, 11), true, "Campus Garage", "Minibus", 38000.0 },
                    { 16, new DateOnly(2019, 10, 3), true, "Electronics Lab", "Oscilloscope", 3600.0 },
                    { 17, new DateOnly(2022, 11, 21), true, "Games Lab", "VR Headset Set", 2900.0 },
                    { 18, new DateOnly(2016, 9, 8), false, "Physics Lab", "Lab Bench", 1250.0 },
                    { 19, new DateOnly(2020, 8, 17), true, "Seminar Room 1", "Student Desk Set", 2100.0 },
                    { 20, new DateOnly(2019, 3, 29), true, "Sports Centre", "Sports Hall Scoreboard", 7400.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assets");
        }
    }
}
