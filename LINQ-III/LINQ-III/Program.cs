using System.Collections.Generic;

namespace LINQ_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sintaxe de método
            IEnumerable<string> nomes = FonteDados.GetAlunos().Select(n=> n.Nome);

            Console.WriteLine("Alunos notas \n");
            foreach(var nome in nomes) { 
                Console.WriteLine($"{nome}");
            }
        }
    }
}