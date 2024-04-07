using GeoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoProject.Database;

namespace GeoProject.ManageDB
{
    public class DatabaseSeeder
    {
        private static Random random = new Random();
        public static void Seed()
        {
            
            using (var db = new MyDBContext(Singleton.Instance.NameServer, Singleton.Instance.NameDatabase))
            {
                for (int i = 1; i <= 5; i++)
                {
                    var project = new ProjectModel
                    {
                        ProjectName = $"Project {i}",
                        Description = $"Description for Project {i}"
                    };
                    db.Projects.Add(project);

                    for (int j = 1; j <= 10; j++)
                    {
                        var area = new AreaModel
                        {
                            AreaType = $"Area {j} for Project {i}",
                            Coordinates = GenerateRandomCoordinates(),
                            Project = project
                        };
                        db.Areas.Add(area);

                        for (int k = 1; k <= 15; k++)
                        {
                            var profile = new ProfileModel
                            {
                                Coordinates = GenerateRandomCoordinates1(),
                                Area = area
                            };
                            db.Profiles.Add(profile);

                            for (int l = 1; l <= 20; l++)
                            {
                                var electrode = new ElectrodeModel
                                {
                                    Coordinates = GenerateRandomCoordinates1(),
                                    ElectrodeType = $"Type {random.Next(1, 6)}",
                                    Value = Math.Round(random.NextDouble() * (15 - 5) + 5, 2),
                                    DateTime = GenerateRandomDateTime(),
                                    Profile = profile
                                };
                                db.ElectrodesCoordinates.Add(electrode);
                            }
                        }
                    }
                }

                db.SaveChanges();
            }

        }
        private static string GenerateRandomCoordinates()
        {

            double latitude = Math.Round((random.NextDouble() * 200) - 100, 1);
            double longitude = Math.Round((random.NextDouble() * 200) - 100, 1);

            return $"{latitude} {longitude}";
        }
        private static string GenerateRandomCoordinates1()
        {
            double latitude = Math.Round((random.NextDouble() * 150) - 75, 1);
            double longitude = Math.Round((random.NextDouble() * 150) - 75, 1);

            return $"{latitude} {longitude}";
        }
        private static DateTime GenerateRandomDateTime()
        {
            DateTime startDate = new DateTime(2023, 1, 1);
            DateTime endDate = new DateTime(2023, 12, 31);

            DateTime randomDate = startDate.AddDays(random.NextDouble() * (endDate - startDate).TotalDays);

            TimeSpan randomTimeSpan = TimeSpan.FromHours(random.Next(0, 24)) + TimeSpan.FromMinutes(random.Next(0, 60)) + TimeSpan.FromSeconds(random.Next(0, 60));

            return randomDate.Date + randomTimeSpan;
        }


    }
}
