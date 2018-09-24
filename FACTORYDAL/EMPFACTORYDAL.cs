using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPES;
using DAL;

namespace FACTORYDAL
{
    public class EMPFACTORYDAL
    {
        public static IEMPLDAL CreateDAL()
        {
            IEMPLDAL objemp = new EMPDAL();
            return objemp;
        }

    }
}
