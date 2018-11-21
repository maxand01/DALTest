using BOSalarie;
using DALSalarie;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALSalarie
{
    public class DALEmploye
    {
        public string Requete { get; set; }
        public Connection cn { get; set; }
        public List<Employe> ListeEmploye { get; set; }

        public DALEmploye()
        {
            cn = new Connection();
            ListeEmploye = new List<Employe>();
        }
        public List<Employe> GetAllEmployes()
        {
            
            Requete = "Select * from EMP";
            SqlCommand objSelectCommand = new SqlCommand(Requete);
            objSelectCommand.Connection = cn.cn;
            DataTable objDataTable = new DataTable();
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(objSelectCommand);
            objDataAdapter.Fill(objDataTable);
            foreach (DataRow row in objDataTable.Rows)
            {
                Employe emp = new Employe();
                emp.NumeroEmploye = Convert.ToInt32(row["EMPNO"]);
                emp.NomEmploye = row["ENAME"].ToString();
                emp.Job = row["JOB"].ToString();
                //emp.Manager = Convert.ToInt32(row["MGR"]);
                emp.Hiredate = Convert.ToDateTime(row["HIREDATE"]);
                emp.Salaire = Convert.ToDecimal(row["SAL"]);
                emp.Commission = Convert.ToDecimal(row["SAL"]);
                emp.NumeroDepartement = Convert.ToInt32(row["DEPTNO"]);
                ListeEmploye.Add(emp);
            }
            return ListeEmploye;
        }

        public List<Employe> GetEmployeByDeptno(int value)
        {
            SqlCommand objSelectCommand = new SqlCommand();
            objSelectCommand.Connection = cn.cn;
            objSelectCommand.CommandText = "dbo.GetEmpsByDeptno";
            objSelectCommand.CommandType = CommandType.StoredProcedure;
            objSelectCommand.Parameters.Add("@DEPTNO", SqlDbType.Int).Value = value;
            objSelectCommand.ExecuteNonQuery();
            DataTable objDataTable = new DataTable();
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(objSelectCommand);
            objDataAdapter.Fill(objDataTable);
            foreach (DataRow row in objDataTable.Rows)
            {
                Employe emp = new Employe();
                emp.NumeroEmploye = Convert.ToInt32(row["EMPNO"]);
                emp.NomEmploye = row["ENAME"].ToString();
                emp.Job = row["JOB"].ToString();
                //emp.Manager = Convert.ToInt32(row["MGR"]);
                emp.Hiredate = Convert.ToDateTime(row["HIREDATE"]);
                emp.Salaire = Convert.ToDecimal(row["SAL"]);
                emp.Commission = Convert.ToDecimal(row["SAL"]);
                emp.NumeroDepartement = Convert.ToInt32(row["DEPTNO"]);
                ListeEmploye.Add(emp);
            }
            return ListeEmploye;
        }
    }
}
