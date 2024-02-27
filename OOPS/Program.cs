using System;
using System.Collections.Generic;

namespace OOPS
{
    public class OOPSHANDLER
    {
        public string Username;
        public string email;
        public string Password;

        public void GetUser(string a, string b, string c)
        {
            this.Username = a;
            this.email = b;
            this.Password = c;
        }

        public void Localdata(OOPSHANDLER user)
        {
            Program.userDatabase[user.email] = user;
        }
    }

    public static class Program
    {
        public static Dictionary<string, OOPSHANDLER> userDatabase = new Dictionary<string, OOPSHANDLER>();

        static void Main(string[] args)
        {
            Console.WriteLine("********************************FOR SIGNUP***********************************************");
            Console.WriteLine("Please Enter Your Name:");
            string UserN = Console.ReadLine();
            Console.WriteLine("Please Enter Your Mail:");
            string UserM = Console.ReadLine();
            Console.WriteLine("Please Enter Your Password");
            string UserP = Console.ReadLine();

            string[] User = { UserN, UserM, UserP };

            OOPSHANDLER myObj = new OOPSHANDLER();
            myObj.GetUser(User[0], User[1], User[2]);
            myObj.Localdata(myObj);

            Console.Write($"{User[0]} {User[1]} {User[2]}");

            Console.WriteLine("********************************FOR SIGNIN***********************************************");

            Console.WriteLine("Please Enter Your Mail:");
            string loginM = Console.ReadLine();

            Console.WriteLine("Please Enter Your Password:");
            string loginP = Console.ReadLine();

            bool userExists = userDatabase.TryGetValue(loginM, out OOPSHANDLER user);

            if (userExists && user.Password == loginP)
            {
                Console.WriteLine("You are successfully Logged in");
            }
            else
            {
                Console.WriteLine("You are not registered, please register yourself and try again");
            }

            Console.ReadLine();
        }
    }
}
