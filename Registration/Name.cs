using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Registration
{
    public class Name
    {
        public static string REGEX_NAME = "[A-Z]{1}[a-z]{3}$";
        public bool validateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX_NAME);
        }
    }
}
