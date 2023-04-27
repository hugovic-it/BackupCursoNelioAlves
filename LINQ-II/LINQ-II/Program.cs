using System.Security.Cryptography.X509Certificates;

namespace LINQ_II;

internal class Program{
    static void Main(string[] args){
        // numeros = 1, 2, 4, 8, 16, 32, 64, 128, 256, 512
        var numeros = FonteDados.GetNumeros();

        var resultado1 = numeros.Where(x => x < 10);
        var resultado2 = numeros.Where(x => x>1 && x !=4 && x < 20);

        // 16, 128, 512
        var listaNegra = FonteDados.GetListaNegra();
        var resultado3 = numeros.Where(x => !listaNegra.Contains(x));

        var resultado4 = numeros
            .Where(n => n > 1)
            .Where(n => n != 4)
            .Where(n => n > 20);

        Console.WriteLine(string.Join(" ",resultado4));

        //trabalhando com objetos complexos
        var alunos = FonteDados.GetAlunos();

        var resultado5 = alunos.Where(a=> a.Nome.StartsWith('A') 
                                          && a.Idade < 18);

        foreach(var aluno in resultado5){
            Console.WriteLine(aluno.Nome+ " : " + aluno.Idade);
        }}}