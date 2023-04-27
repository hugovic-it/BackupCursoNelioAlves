namespace LINQ_I;
internal class Program
{
    static void Main(string[] args)
    {

        //DATA SOURCE
        IList<string> frutas = new List<string>() { "Banana", "Maça", "Pera", "Laranja", "Uva" };

        //Query Syntax
        var resultado = from f in frutas
                        where f.Contains('r')
                        select f;
        Console.WriteLine(string.Join(" ", resultado));

        //Method Syntax
        var resultado2 = frutas.Where(f => f.Contains('r'));
        Console.WriteLine(string.Join(" ", resultado2));
    }
}