using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console71
{
    internal class Estudante
    {

        public string Nome { get; set; }
        public string Email { get; set; }
        public int NumeroQuarto { get; set; }

        public Estudante(string? nome, string? email, int numeroQuarto)
        {
            Nome = nome;
            Email = email;
            NumeroQuarto = numeroQuarto;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + " \n" +  
                   "Email: " + Email + " \n" +
                   "Quarto: " + NumeroQuarto + " \n";
        }

    }
}
