namespace Registration
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Email e = new Email();
            string[] email = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.net", "abc-100@abc.net", "abc.100@abc.com.au","abc+100@gmail.com", };
            //bool val = e.validateEmail(e);
            foreach (string v in email)
            {
                bool s=e.validateEmail(v);
                Console.WriteLine(v+" "+s);
                
            }
            Email em = new Email();
            Console.WriteLine("Enter Email:");
            string n = Console.ReadLine();
            bool val = em.validateEmail(n);
            if (val)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            //Name name = new Name();
            //Console.WriteLine("Enter FirstName:");
            //string n = Console.ReadLine();
            //bool val = name.validateFirstName(n);
            //if (val)
            //{
            //    Console.WriteLine("valid");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}
            //Mobileno mobileno = new Mobileno();
            //Console.WriteLine("Enter Mobile Number:");
            //string n1 = (Console.ReadLine());
            //bool val3 = mobileno.validatePhoneno(n1);
            //if (val3)
            //{
            //    Console.WriteLine("valid");
            //}
            //else
            //{
            //    Console.WriteLine("incorrect Number");
            //}
            //Password4 password = new Password4();
            //Console.WriteLine("Enter password Rule4");
            //string n2= (Console.ReadLine());
            //bool val1=password.ValidatePassword(n2);
            //if (val1)
            //{
            //    Console.WriteLine("Valid");
            //}
            //else
            //{ Console.WriteLine("In Valid"); }
        }
    }
}