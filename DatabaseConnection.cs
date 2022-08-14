using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Login_Form
{
    public class DatabaseConnection
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public string storeName = "JP store";
        public string storeAddress = "Quezon City";
        public string DBConnection() 
        {
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\JP\Software\Inventory Management System\Github\Login Form\IMSDatabase.mdf';Integrated Security=True";
            return con;
        }   
        public double getVal()
        {
            double vat = 0;
            con.ConnectionString = DBConnection();
            con.Open();
            cmd = new SqlCommand("SELECT * FROM vatTbl",con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                vat = Double.Parse(dr["vat"].ToString());
            }
            dr.Close();
            con.Close();
            return vat;
        }

    }
}
