using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GeoProject.Models
{
    public class Singleton
    {
        private static Singleton instance;
        private string _nameServer;
        private string _nameDatabase;
        private Singleton() 
        {
            _nameDatabase = string.Empty;
            _nameServer = string.Empty;
        }
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
        public string NameServer
        {
            get { return _nameServer; }
            set { _nameServer = value; }
        }

        public string NameDatabase
        {
            get { return _nameDatabase; }
            set { _nameDatabase = value; }
        }
    }
}
