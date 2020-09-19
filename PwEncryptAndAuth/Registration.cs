using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace PwEncryptAndAuth
{
    public static class Registration
    {
        public static List<string> usernames = new List<string>();
        public static List<string> passwords = new List<string>();

        public static (string, string) UserInputs()
        {
            Console.Write("Enter username: ");
            string u = Console.ReadLine();
            usernames.Add(u);

            Console.Write("Enter password: ");
            string p = Console.ReadLine();

            StringBuilder s = new StringBuilder();
            MD5CryptoServiceProvider crypto = new MD5CryptoServiceProvider();
            byte[] bytes = crypto.ComputeHash(new UTF8Encoding().GetBytes(p));

            for (int i = 0; i < bytes.Length; i++)
            {
                s.Append(bytes[i].ToString("x2"));
            }
            passwords.Add(p = s.ToString());

            foreach (string username in usernames)
            {
                Console.WriteLine(username);
            }
            foreach (string password in passwords)
            {
                Console.WriteLine(password);
            }

            Console.WriteLine("[ENTER]");
            Console.ReadLine();
            return (u, p);
        }
    }
}
