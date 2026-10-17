using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace AssetsApp.Data
{
    public class AssetsDbContext : DbContext
    {
        public string DbPath { get; }     // Will hold location of database filename

        public AssetsDbContext()
        {
            // set the database filename (inc. full path to the user's Documents folder)
            var folder = Environment.SpecialFolder.MyDocuments;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "assets.db");
        }

        // Specify the database table(s)
        public DbSet<Asset> Assets => Set<Asset>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // Set the database filename (inc. path) for SQLite to use
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // execute the base OnModelCreating method

            // Add test data
            modelBuilder.Entity<Asset>().HasData(
             new Asset(1, "Dell Desktop PC", "Computer Lab 1", DateOnly.Parse("2022-08-15"), true, 780.00),
             new Asset(2, "Dell Desktop PC", "Computer Lab 2", DateOnly.Parse("2022-08-15"), true, 780.00),
             new Asset(3, "Lecture Hall Projector", "Lecture Theatre A", DateOnly.Parse("2021-09-01"), true, 2400.00),
             new Asset(4, "Interactive Whiteboard", "Seminar Room 3", DateOnly.Parse("2022-01-18"), true, 3200.00),
             new Asset(5, "Electron Microscope", "Science Building", DateOnly.Parse("2019-05-20"), true, 185000.00),
             new Asset(6, "3D Printer", "Engineering Workshop", DateOnly.Parse("2022-10-04"), true, 4500.00),
             new Asset(7, "Library Self-Service Kiosk", "Main Library", DateOnly.Parse("2021-03-12"), true, 6800.00),
             new Asset(8, "Server Rack", "Data Centre", DateOnly.Parse("2020-07-30"), true, 15500.00),
             new Asset(9, "Network Switch", "Data Centre", DateOnly.Parse("2021-11-09"), true, 1900.00),
             new Asset(10, "Laser Cutter", "Design Studio", DateOnly.Parse("2021-06-22"), true, 12500.00),
             new Asset(11, "Spectrometer", "Chemistry Lab", DateOnly.Parse("2020-02-14"), true, 42000.00),
             new Asset(12, "Lecture Capture Camera", "Lecture Theatre B", DateOnly.Parse("2022-09-05"), true, 1800.00),
             new Asset(13, "Staff Laptop", "Admissions Office", DateOnly.Parse("2023-01-16"), true, 1150.00),
             new Asset(14, "Photocopier", "Student Services", DateOnly.Parse("2018-04-25"), false, 5400.00),
             new Asset(15, "Minibus", "Campus Garage", DateOnly.Parse("2017-08-11"), true, 38000.00),
             new Asset(16, "Oscilloscope", "Electronics Lab", DateOnly.Parse("2019-10-03"), true, 3600.00),
             new Asset(17, "VR Headset Set", "Games Lab", DateOnly.Parse("2022-11-21"), true, 2900.00),
             new Asset(18, "Lab Bench", "Physics Lab", DateOnly.Parse("2016-09-08"), false, 1250.00),
             new Asset(19, "Student Desk Set", "Seminar Room 1", DateOnly.Parse("2020-08-17"), true, 2100.00),
             new Asset(20, "Sports Hall Scoreboard", "Sports Centre", DateOnly.Parse("2019-03-29"), true, 7400.00)
 );
        }

    }
}
