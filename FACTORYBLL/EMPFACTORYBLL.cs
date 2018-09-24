using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPES;
using BLL;

namespace FACTORYBLL
{
    public class EMPFACTORYBLL
    {
        public static IEMPLBLL Createnew()
        {
            IEMPLBLL objempbl1 = new EMPLBLL();
            return objempbl1;
        }
    }
}
