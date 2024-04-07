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
                // Заполнение базы данных синтетическими данными

                // Создание 5 проектов
                for (int i = 1; i <= 5; i++)
                {
                    var project = new ProjectModel
                    {
                        ProjectName = $"Project {i}",
                        Description = $"Description for Project {i}"
                    };
                    db.Projects.Add(project);

                    // Создание 10 площадей для каждого проекта
                    for (int j = 1; j <= 10; j++)
                    {
                        var area = new AreaModel
                        {
                            AreaType = $"Area {j} for Project {i}",
                            Coordinates = GenerateRandomCoordinates(),
                            Project = project
                        };
                        db.Areas.Add(area);

                        // Создание 15 профилей для каждой площади
                        for (int k = 1; k <= 15; k++)
                        {
                            var profile = new ProfileModel
                            {
                                Coordinates = GenerateRandomCoordinates1(),
                                // Другие свойства профиля
                                Area = area
                            };
                            db.Profiles.Add(profile);

                            // Создание 20 электродов для каждого профиля
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

                // Сохранение изменений в базе данных
                db.SaveChanges();
            }

        }
        private static string GenerateRandomCoordinates()
        {

            double latitude = Math.Round((random.NextDouble() * 200) - 100, 1); // От -100 до 100
            double longitude = Math.Round((random.NextDouble() * 200) - 100, 1); // От -100 до 100

            return $"{latitude} {longitude}";
        }
        private static string GenerateRandomCoordinates1()
        {
            double latitude = Math.Round((random.NextDouble() * 150) - 75, 1); // От -75 до 75
            double longitude = Math.Round((random.NextDouble() * 150) - 75, 1); // От -75 до 75

            return $"{latitude} {longitude}";
        }
        private static DateTime GenerateRandomDateTime()
        {
            DateTime startDate = new DateTime(2023, 1, 1); // Начальная дата для генерации
            DateTime endDate = new DateTime(2023, 12, 31); // Конечная дата для генерации

            // Генерируем случайную дату в заданном диапазоне
            DateTime randomDate = startDate.AddDays(random.NextDouble() * (endDate - startDate).TotalDays);

            // Генерируем случайное время в пределах суток
            TimeSpan randomTimeSpan = TimeSpan.FromHours(random.Next(0, 24)) + TimeSpan.FromMinutes(random.Next(0, 60)) + TimeSpan.FromSeconds(random.Next(0, 60));

            // Объединяем дату и время
            return randomDate.Date + randomTimeSpan;
        }


    }
}
