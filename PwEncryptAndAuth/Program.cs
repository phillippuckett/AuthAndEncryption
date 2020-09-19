using System;

namespace PwEncryptAndAuth
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Menu o = new Menu(); o.Navigate();
            }
            catch (FormatException InputError) { Console.WriteLine(InputError); }
            catch (OverflowException InputError) { Console.WriteLine(InputError); }
            finally { }
        }
    }
}


