namespace Registration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Name name = new Name();
            Console.WriteLine("Enter FirstName:");
            string n = Console.ReadLine();
            bool val = name.validateFirstName(n);
            if (val)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.WriteLine("Enter LastName:");
            string l = Console.ReadLine();
            bool val1 = name.validateLastName(l);
            if (val1)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}