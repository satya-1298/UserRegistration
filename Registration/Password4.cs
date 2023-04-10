using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Registration
{
    public class Password4
    {
        public static string Regex_Password = "^(?=[a-zA-Z0-9#@$?-_]{8,}$)(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9]).*$";
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, Regex_Password);
        }
    }
}
