using System;

namespace Ex60 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args){
            Conta c;
            Console.WriteLine("Inserir nome do titular:");
            string nome = Console.ReadLine();
            Console.WriteLine("Deseja fazer um saque inicial ?  y/n");
            string saqueInicial = Console.ReadLine();
            if (saqueInicial == "y"){
                Console.WriteLine("Insira o valor do deposito inicial");
                double saldo = double.Parse(Console.ReadLine());
                c = new Conta(1,nome,saldo);
            }
            else {
                c = new Conta(1, nome);
            }
            Console.WriteLine(c);
        }
    }
}