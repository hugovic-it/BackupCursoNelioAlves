using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_III
{
    public class FonteDados
    {
        public static List<Aluno> GetAlunos()
        {
            List<Aluno> alunos = new()
            {
                
                new Aluno(){ Nome = "Maria", Idade = 22 , Nota = 7,  },
                new Aluno(){ Nome = "Manoel", Idade = 24, Nota = 6, },
                new Aluno(){ Nome = "Amanda", Idade = 21, Nota = 5,},
                new Aluno(){ Nome = "Carlos", Idade = 18, Nota = 9, },
                new Aluno(){ Nome = "Alicia", Idade = 17, Nota = 4,}
            };
            return alunos;
        } 
    }
}
