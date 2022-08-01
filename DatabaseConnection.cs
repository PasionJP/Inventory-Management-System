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
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\JP\Software\Inventory Management System\Github\Login Form\IMSDatabase.mdf';Integrated Security=True";
            return con;
        }    
    }
}
