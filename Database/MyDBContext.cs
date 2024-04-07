using GeoProject.Models;
using Microsoft.EntityFrameworkCore;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GeoProject.Database
{
    public class MyDBContext : DbContext
    {
        public string _serverName;
        public string _databaseName;
        public DbSet<AreaModel> Areas { get; set; }
        public DbSet<ElectrodeModel> ElectrodesCoordinates { get; set; }
        public DbSet<GeologicalInformationModel> GeologicalInformation { get; set; }
        public DbSet<MeasurementMetadataModel> MeasurementMetadata { get; set; }
        public DbSet<ProfileModel> Profiles { get; set; }
        public DbSet<ProjectModel> Projects { get; set; }
        public DbSet<UserModel> Users { get; set; }

        public MyDBContext(string serverName, string databaseName)
        {
            _serverName = serverName;
            _databaseName = databaseName;
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Data Source = { _serverName }; Initial Catalog = { _databaseName }; Integrated Security = True; Connect Timeout = 30; Encrypt = True; Trust Server Certificate = True; Application Intent = ReadWrite; Multi Subnet Failover = False");
        }
    }
}
