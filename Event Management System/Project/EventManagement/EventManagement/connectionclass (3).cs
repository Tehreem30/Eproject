using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement
{
    class connectionclass
    {
        private static string connectionString = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\asp.APTECH\Desktop\me\EventManagement\EventManagement\Admin.mdf;Integrated Security=True");

        public static string ConnectionString
        {
            get
            {
                return connectionString;
            }
        }
    }
}
