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
                db.ElectrodesCoordinates.RemoveRange(db.ElectrodesCoordinates);

                db.Profiles.RemoveRange(db.Profiles);

                db.Areas.RemoveRange(db.Areas);

                db.Projects.RemoveRange(db.Projects);

                db.SaveChanges();
            }
        }
    }

}
