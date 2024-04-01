using GeoProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoProject.Database
{
    public class database : DbContext
    {
        public DbSet<AreaModel> Areas { get; set; }
        public DbSet<ElectrodeModel> ElectrodesCoordinates { get; set; }
        public DbSet<GeologicalInformationModel> GeologicalInformation { get; set; }
        public DbSet<MeasurementMetadataModel> MeasurementMetadata { get; set; }
        public DbSet<ProfileModel> Profiles { get; set; }
        public DbSet<ProjectModel> Projects { get; set; }
        public DbSet<UserModel> Users { get; set; }

        public database()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-591T9LE;Initial Catalog=Geo3;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

    }
}
