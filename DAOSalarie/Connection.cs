using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALSalarie
{
     public class Connection
    {
        public SqlConnection cn { get; set; }
        public Connection()
        {
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=176.31.248.137;Initial Catalog=user08;Persist Security Info=True;User ID=user08;Password=852user08";
            cn.Open();
        }       
    }
}
