﻿using BOSalarie;
using DALSalarie;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonneeSalarie
{
    public class Program
    {
        static void Main(string[] args)
        {
            DALDepartement objDALDepartement= new DALDepartement();
            DataSet ds = objDALDepartement.GetAllDepartement();
            Console.WriteLine(ds.GetXml());
            Console.ReadKey();
        }
    }
}
