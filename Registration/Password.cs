using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Registration
{
    public class Password
    {
        public static string REGEX_PASSWORD = "^[a-zA-Z0-9]{8, }$";
        public bool validatepassword(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
    }
}
