namespace Console72;

internal class Program
{
    static void Main(string[] args){


        int[] temperatura = new int[] { 51, 2, 3, 45, 6 };
        double media = 0;
 
        foreach(int tmp in temperatura){
            Console.WriteLine(tmp);
            media += tmp;
        }

        Console.WriteLine("Resultado: "+ media);
    }
}