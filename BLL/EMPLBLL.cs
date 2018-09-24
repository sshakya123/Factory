using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPES;
using FACTORYDAL;

namespace BLL
{
    public class EMPLBLL: IEMPLBLL
    {
        public int CheckEmp(IEMPLBO obj)
        {
            IEMPLDAL obj1 = EMPFACTORYDAL.CreateDAL();
            return (obj1.CheckEmployees(obj));
        }
    }
}
