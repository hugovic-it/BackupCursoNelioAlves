
namespace Teste01;
public class Program
{
    static void Main(string[] args)
    {
        List<string> pessoas = new List<string>();
         
        pessoas.Add("Hugo");
        pessoas.Add("Victor");
        pessoas.Add("Da");
        pessoas.Add("Silva");
        pessoas.Add("Pessoa");
        pessoas.Add("Jose");
        pessoas.Add("Weverton");

        IEnumerable<string> resultado = pessoas.Where(x => x.Contains('a')) ;

        foreach(string obj in resultado)
        {
            Console.WriteLine(obj);
        }
    }
}