using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoProject.Database;
using GeoProject.Models;

namespace GeoProject.ManageDB
{
    public class DatabaseCleaner
    {
        public static void Clean()
        {
            using (var db = new MyDBContext(Singleton.Instance.NameServer, Singleton.Instance.NameDatabase))
            {
                // Очистка данных из всех таблиц

                // Удаление всех электродов
                db.ElectrodesCoordinates.RemoveRange(db.ElectrodesCoordinates);

                // Удаление всех профилей
                db.Profiles.RemoveRange(db.Profiles);

                // Удаление всех площадей
                db.Areas.RemoveRange(db.Areas);

                // Удаление всех проектов
                db.Projects.RemoveRange(db.Projects);

                // Сохранение изменений в базе данных
                db.SaveChanges();

            }
        }
    }

}
