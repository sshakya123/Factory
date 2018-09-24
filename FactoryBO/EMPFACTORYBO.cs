using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using TYPES;

namespace FactoryBO
{
    public class EMPFACTORYBO
    {
        public static IEMPLBO CheckEmployees(string Uname, string Pwrd)
        {
            IEMPLBO empBo = new EMPBO(Uname, Pwrd);
            return empBo;
        }
    }
}
