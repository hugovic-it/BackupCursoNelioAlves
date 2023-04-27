using System;
using System.Globalization;

namespace Console69;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira a quantidade de pessoas");
        int n = int.Parse(Console.ReadLine());
        double[] vect = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Inserir altura: ");
            vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        double sum = 0.0;
        for (int i = 0; i < n; i++)
        {
            sum += vect[i];
        }
        double avg = sum / n;
        Console.WriteLine("A media de altura é: " + avg.ToString("F2", CultureInfo.InvariantCulture));
    }
}