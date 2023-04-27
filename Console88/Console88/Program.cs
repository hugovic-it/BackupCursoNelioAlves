using System.Globalization;
using System.Security.Cryptography;

namespace Console88
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z");

            Console.WriteLine(d1);
            Console.WriteLine(d1.Kind);  
            Console.WriteLine(d1.ToLocalTime());   
            Console.WriteLine(d1.ToUniversalTime());

            Console.WriteLine("- - - - - - - - - - - - - -");
            Console.WriteLine(d2);
            Console.WriteLine(d2.Kind);
            Console.WriteLine(d2.ToLocalTime());
            Console.WriteLine(d2.ToUniversalTime());


        }
    }
}