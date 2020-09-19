using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PwEncryptAndAuth
{
    class Menu
    {
        public void Navigate()
        {
            bool run = false;

            while (!run)
            {
                Console.WriteLine("" +
                    "\n--------------------------------------------------------------------" +
                    "\n                PASSWORD AUTHENTICATION SYSTEM " +
                    "\n" +
                    "\n                Please select one option: " +
                    "\n                1. Establish an account " +
                    "\n                2. Authenticate a user" +
                    "\n                3. Exit the system " +
                    "\n                Enter selection: " +
                    "\n" +
                    "\n--------------------------------------------------------------------");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Registration.UserInputs();
                }
                else if (choice == 2)
                {
                    Authentication a = new Authentication();
                    a.Authenticate();
                }
                else if (choice == 3)
                {
                    run = false;
                    Console.WriteLine("Press [ENTER] to exit the application");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("That's not an option, press [ENTER] to try again");
                    Console.ReadLine();
                }
                Console.Clear();
            }
        }
    }
}
