using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Registration
{
    internal class Password3
    {
        public static string Regex_Password = "^[A-Z]{1}[0-9]{1}[a-z]{6}$";
        public bool validatepassword3(string password3)
        {
            return Regex.IsMatch(password3, Regex_Password);

        }
    }
}

