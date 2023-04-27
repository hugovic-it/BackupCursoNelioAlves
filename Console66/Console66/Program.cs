using System;

namespace Console66; // Note: actual namespace depends on the project name.


struct Point { 
    public double X, Y;
    public override string ToString()
    {
        return "(" + X + "," + Y + ")";
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Point p;
        Console.WriteLine(p); //erro: variavel nao atribyuida
        p.X = 10;
        p.Y = 20;
        Console.WriteLine(p);
        p = new Point();    
        Console.WriteLine(p);
    }
}
 