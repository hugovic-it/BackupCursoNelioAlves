using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Console235;

internal class Program
{
    static void Main(string[] args)
    {
        //Specify the data source
        int[] numbers = new int[] {2,3,4,5};

        //Define the query expression
        IEnumerable<int> result = numbers
            .Where(x => x % 2 == 0)
            .Select(x => x * 10);
        

        foreach(int x in result)
        {
            Console.WriteLine(x);
        }
    }
}