using System;
namespace RegexDemo
{
    class program
    {
        public static string instr = Console.ReadLine();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registation Problems");
            Pattern program = new Pattern();
            Console.WriteLine("-->Select to Program is Executed<--");
            Console.WriteLine("1.Enter First Name : \n Exit");
            Console.WriteLine("Select Valid Option:->");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine(program.ValidateFirstName(instr));
                    break;
                case 2:
                default:
                    Console.WriteLine("Please Select Correct Option");
                    break;
            }
        }
    }
}