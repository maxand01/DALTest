using BOSalarie;
using DALSalarie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLSalarie
{
    public class BLLDepartement
    {
        public List<Departement> LoadDataDepartement()
        {
            return new DALDepartement().GetAllDepartement2();
        }
    }
}
