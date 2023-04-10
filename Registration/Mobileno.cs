using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Registration
{
    internal class Mobileno
    {
        public static string REGEX_MOBILE = "[+]{1}[1-9]{2}[' '][7-9]{1}[0-9]{9}$";
        public bool validatePhoneno(string Mobile)
        {
            return Regex.IsMatch(Mobile, REGEX_MOBILE);
        }
    }
}
