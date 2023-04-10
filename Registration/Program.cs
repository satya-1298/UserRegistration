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
            //Console.WriteLine("Enter LastName:");
            //string l = Console.ReadLine();
            //bool val1 = name.validateLastName(l);
            //if (val1)
            //{
            //    Console.WriteLine("valid");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}
            //Email e= new Email();
            //Console.WriteLine("Enter Email:");
            //string m= Console.ReadLine();
            //bool val2=e.validateEmail(m);
            //if(val2)
            //{
            //    Console.WriteLine("valid");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect Email");
            //}
            Mobileno mobileno= new Mobileno();
            Console.WriteLine("Enter Mobile Number:");
            string n=(Console.ReadLine());
            bool val3 = mobileno.validatePhoneno(n);
            if(val3) 
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("incorrect Number");
            }

        }
    }
}