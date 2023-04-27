using System.Collections.Generic;

namespace Console76;

internal class Program{
    static void Main(string[] args){

        List<string> list = new List<string>();

        list.Add("Maria");
        list.Add("Alex");
        list.Add("Bob");
        list.Add("Ana");

        list.Insert(2, "Marco"); //(posição , valor)

        foreach (string obj in list) {
            Console.WriteLine(obj);
        }
        Console.WriteLine("List Count: " + list.Count);

        //parametro => condição// 1° caracter de x == A
        //Procurar o primeiro que começa com A
        string s1 = list.Find(x => x[0] == 'A');
        Console.WriteLine("First 'A': " + s1);

        //Procurar o ultimo que começa com A
        string s2 = list.FindLast(x => x[0] == 'A');
        Console.WriteLine("Last 'A': " + s2);

        //Procurar o index do primerio que começa com A
        int pos1 = list.FindIndex(x => x[0] == 'A');
        Console.WriteLine("First position 'A': " + s1);

        //Procurar o index do ultimo que começa com A
        int pos2 = list.FindLastIndex(x => x[0] == 'A'); 
        Console.WriteLine("Last position 'A': " + s2);

        //o findAll cria uma nova lista a partir do predicado
        List<string> list2 = list.FindAll(x => x.Length == 5);
 
        list.Remove("Alex");   //remover Alex

        list.RemoveAll(x => x[0] == 'M');  //remover todos que começam com M

        list.RemoveAt(2); //remover o do index 2

        list.RemoveRange(2,2);  //(a partir da posição 2, remover 2 elementos)

    }
}