using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOSalarie
{
    public class Employe
    {
        public int NumeroEmploye { get; set; }
        public string NomEmploye { get; set; }
        public string Job { get; set; }
        public int Manager { get; set; }
        public DateTime Hiredate { get; set; }
        public decimal Salaire { get; set; }
        public decimal Commission { get; set; }
        public int NumeroDepartement { get; set; }

        public Employe()
        {

        }       
    }
}
