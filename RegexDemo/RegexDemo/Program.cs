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
            Console.WriteLine("1.Enter First Name \n2.Enter Last Name \n3.Enter Your Email ID \n4.Enter Your Mobile Number \n5.Enter PassWrd Rule1 \n6.Enter PassWrd Atleast One Upper Case \n7.Enter PassWrd Atleast One Numeric Number \n8.Exit");
            Console.WriteLine("Select Valid Option:->");
            int option = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            while (flag)
                switch (option)
                {
                    case 1:
                        //Validating user entered a valid firstname or not(UC1)
                        Console.Write("\tEnter Your First Name: ");
                        program.CheckFirstName();//Call the Method.
                        break;
                    case 2:
                        //Validating user entered a valid Lastsname or not(UC2)
                        Console.Write("\tEnter Your Last Name: ");
                        program.CheckLastName();//Call the Method.
                        break;
                    case 3:
                        //Validating user entered a valid Email id or not(UC3)
                        Console.Write("\tEnter Your Email Id: ");
                        program.CheckEmail();//Call the Method.
                        break;
                    case 4:
                        //Validating user entered a valid Mobile Numbers or not(UC4)
                        Console.Write("\tEnter Your Mobile Numbers: ");
                        program.CheckMobileNumber();//Call the Method.
                        break;
                    case 5:
                        //Validating user entered a valid Passwrd or not (UC5)
                        Console.WriteLine("\tEnter Your Passwrd: ");
                        program.CheckPasswrd(); //Call the Method.
                        break;
                    case 6:
                        //Passwed for having atleast one uppercase
                        Console.WriteLine("\tEnter Your Passwrd: ");
                        program.CheckPasswrd1(); //Call the Method.
                        break;
                    case 7:
                        //Passwed for having atleast one Numric Number
                        Console.WriteLine("\tEnter Your Passwrd: ");
                        program.CheckPasswrd2(); //Call the Method.
                        break;
                    case 8:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("\tSelect Correct Number");
                        break;
                }
        }
    }
}