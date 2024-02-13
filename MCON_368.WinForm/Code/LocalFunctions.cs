using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCON_368.WinForm.Code
{
    internal class LocalFunctions
    {
        public static bool IsNumeric(string theValue)
        {
            float output;
            return float.TryParse(theValue, out output);
        }


    }
}
