using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_v4
{
    public class GroupTestData
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("new_name", "new_header", "new_footer", 2);          
            }
        }
    }
}
