
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOSalarie
{
    public class Departement
    {
        public int NumeroDepartement { get; set; }

        public string NomDepartement { get; set; }

        public string Localisation { get; set; }
        public Departement()
        {

        }
        public Departement(int numeroDepartement, string nomDepartement, string localisation)
        {
            this.NumeroDepartement = numeroDepartement;
            this.NomDepartement = nomDepartement;
            this.Localisation = localisation;
        }
        
        //public void GetAllDepartement()
        //{
        //    DepartementDonnees = new DALDepartement();
        //    DataSet objDataSet = new DataSet();
        //    SqlDataAdapter objDataAdapter = new SqlDataAdapter(DepartementDonnees.GetAllDepartement());
        //    objDataAdapter.Fill(objDataSet);
        //    Console.WriteLine(objDataSet.GetXml());
        //}

    }
}
