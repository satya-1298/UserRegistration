using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Registration
{
    internal class Password2
    {
        public static string Regex_Password2 = "^[A-Z]{1}[a-z0-9]{7}$";
        public bool validatepassword2(string password)
        {
            return Regex.IsMatch(password, Regex_Password2);

        }
    }
}

