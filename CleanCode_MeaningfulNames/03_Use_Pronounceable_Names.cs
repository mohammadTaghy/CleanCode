using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanCode_MeaningfulNames
{
    internal class _03_Use_Pronounceable_Names
    {
        
        //genymdhms (generation date, year, month, day, hour, minute, and second)
        class DtaRcrd102
        {
            private Date genymdhms;
            private Date modymdhms;
            private string pszqint = "102";
            /* ... */
        }
        //to
        class Customer
        {
            private Date generationTimestamp;
            private Date modificationTimestamp;
            private string recordId = "102";
            /* ... */
        }
    }
}
