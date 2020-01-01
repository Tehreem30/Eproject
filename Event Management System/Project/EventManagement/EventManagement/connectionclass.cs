using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventManagement
{
    class connectionclass
    {
        private static string connectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CZ 3\Desktop\Event Management System\Event Management System\Project\EventManagement\EventManagement\Admin.mdf;Integrated Security=True");

        public static string ConnectionString
        {
            get
            {
                return connectionString;
            }
        }
    }
}
