using BOSalarie;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALSalarie
{
    public class DALDepartement
    {
        public string Requete { get; set; }
        public Connection cn { get; set; }
        public List<Departement> ListeDepartement { get; set; }

        public DALDepartement()
        {
            cn = new Connection();
        }

        public DataSet GetAllDepartement()
        {
            Requete = "Select * from DEPT";
            SqlCommand objSelectCommand = new SqlCommand(Requete);
            objSelectCommand.Connection = cn.cn;
            DataSet objDataSet = new DataSet();
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(objSelectCommand);
            objDataAdapter.Fill(objDataSet);

            return objDataSet;
        }

        public List<Departement> GetAllDepartement2()
        {
            ListeDepartement = new List<Departement>();
            cn = new Connection();
            Requete = "Select * from DEPT";
            SqlCommand objSelectCommand = new SqlCommand(Requete);
            objSelectCommand.Connection = cn.cn;
            DataTable objDataTable = new DataTable();
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(objSelectCommand);
            objDataAdapter.Fill(objDataTable);
            foreach (DataRow row in objDataTable.Rows)
            {
                Departement dept = new Departement();
                dept.NomDepartement = row["DNAME"].ToString();
                dept.NumeroDepartement = Convert.ToInt32(row["DEPTNO"]);
                dept.Localisation = row["LOC"].ToString();
                ListeDepartement.Add(dept);                
            }
            return ListeDepartement;
        }

    }
}
