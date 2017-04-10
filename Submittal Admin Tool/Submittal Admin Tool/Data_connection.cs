using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submittal_Admin_Tool
{
    class Data_connection
    {
        public string datalocation()
        {
            string dir = @"X:\ELV-Subs";
            return @"Data Source=" + dir + @"\elv-subm;"; //add code that warns that the database was not found
        }

    }
}
