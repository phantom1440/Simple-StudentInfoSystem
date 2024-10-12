using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentsMS_Tano
{
    public class Connection
    {

        public SqlConnection con = new SqlConnection("Data Source=DESKTOP-FDL70D0\\SQLEXPRESS;Initial Catalog=DBStudentMS_Tano;Integrated Security=True;Encrypt=True; TrustServerCertificate=True");
        public string parameter = "";

        //To Open the Connection
        public void Open()
        {
            con.Open();
        }

        //To Close the Connection
        public void Close()
        {
            con.Close();
        }

        public string conn<T>(T param)
        {
            parameter = param.ToString();
            return parameter;
        }
        
    }
}
