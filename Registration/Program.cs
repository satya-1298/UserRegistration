namespace Registration
{
    class Program
    {
        public static void Main(string[] args)
        {
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
            Password password = new Password();
            Console.WriteLine("Enter password");
            string n2= (Console.ReadLine());
            bool val1=password.validatepassword(n2);
            if (val1)
            {
                Console.WriteLine("Valid");
            }
            else
            { Console.WriteLine("In Valid"); }
        }
    }
}