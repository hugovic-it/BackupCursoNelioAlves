using System;
namespace Console68; 



internal class Program
{
    static void Main(string[] args)
    {


        double? x = null;
        double? y = 10;

        double a = x ?? 5;   //a recebe x, mas se x for nulo, atribua o valor 5 
        double b = y ?? 5;  

        Console.WriteLine(a); //5
        Console.WriteLine(b); //10

    }
}