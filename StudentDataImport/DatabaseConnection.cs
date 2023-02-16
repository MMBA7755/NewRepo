using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataImport
{
    internal class DatabaseConnection
    {
        public string GetConnection()
        {
            string conn = "Data Source=LPTIN-2V63BC3;Initial Catalog=Student;Integrated Security=True";
            return conn;
        }

    }
}
