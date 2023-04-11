using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Registration
{
    public class Email
    {
        public static string REGEX_EMAIL = "[0-9A-Za-z]+[.+-_]{0,1}[0-9A-Za-z]+[@][]A-Za-z]+[.][a-z]{2,3}([.][a-z]{2,3}){0,1}$";
        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
    }
}
