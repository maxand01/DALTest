using BOSalarie;
using DALSalarie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLSalarie
{
    public class BLLEmploye
    {
        public int Value { get; set; }
        public List<Employe> LoadDataEmploye()
        {
            return new DALEmploye().GetAllEmployes();
        }

        public List<Employe> LoadDataEmployesByDeptno(int value)
        {
            this.Value = value;
            return new DALEmploye().GetEmployeByDeptno(Value); 
        }
    }
}
