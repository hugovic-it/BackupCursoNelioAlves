using System;

namespace Console71 { 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserir a quantidade de estudantes: ");
            int n = int.Parse(Console.ReadLine());

            Estudante[] Quartos = new Estudante[11];  //limite de quartos: 10   range 0 - 10  //0 null ?

            for (int i = 0; i < n; i++) {

                Console.Write("Inserir o nome do estudante: ");
                string nome = Console.ReadLine();
                
                Console.Write("Inserir o email do estudante: ");
                string email = Console.ReadLine();
                
                Console.Write("Inserir o quarto do estudante: ");
                int quarto = int.Parse(Console.ReadLine());
                
                Quartos[quarto] = new Estudante(nome,email,quarto);

            }
            for (int i = 0; i < 11; i++) {
                
                if (Quartos[i] != null) {
                     Console.WriteLine(Quartos[i]);
                }

            }

        }
    }
}