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
        }
    }
}