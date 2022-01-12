using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Form
{
    class DatabaseConnection
    {
        public string DBConnection() 
        {
            string con = @"Data Source=LAPTOP-EVOGUQ1J\SQLEXPRESS;Initial Catalog=Products;Integrated Security=True";
            return con;
        }    
    }
}
