using System;
using System.Text;
using System.Security.Cryptography;

namespace PwEncryptAndAuth
{
    public class Authentication
    {
        public (string, string) Authenticate()
        {
            Console.Write("Enter username: ");
            string u = Console.ReadLine();
            int v = Registration.usernames.FindIndex(a => a.Contains(u));

            Console.Write("Enter password: ");
            string p = Console.ReadLine();

            StringBuilder s = new StringBuilder();
            MD5CryptoServiceProvider crypto = new MD5CryptoServiceProvider();
            byte[] bytes = crypto.ComputeHash(new UTF8Encoding().GetBytes(p));

            for (int i = 0; i < bytes.Length; i++)
            {
                s.Append(bytes[i].ToString("x2"));
            }
            Registration.passwords.Add(p = s.ToString());

            if (Registration.passwords[v] == p)
            {
                Console.WriteLine("Logged in Successfully!");
            }
            else
            {
                Console.WriteLine("Failed to Login");
            }

            Console.WriteLine("[ENTER]");
            Console.ReadLine();
            return (u, p);
        }
    }
}
