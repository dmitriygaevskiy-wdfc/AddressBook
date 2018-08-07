using NUnit.Framework;
using System.Collections;

namespace AddressBook_v4
{
    public class LoginTestData
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("admin", "secret");
                yield return new TestCaseData("", "secret");
                yield return new TestCaseData("admin", "");
                yield return new TestCaseData("", "");
            }
        }
    }
}
