using System.Globalization;

namespace Console79
{
    internal class Program
    {
        static void Main(string[] args){
            Console.Write("Inserir o tamanho da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) {

                Console.WriteLine("Inserir os elementos separados por espaço");
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++){
                    mat[i, j] = int.Parse(values[j]);
                }

            }

            //
            Console.WriteLine("Main diagonal");
            for (int i = 0; i < n; i++) {
                Console.WriteLine(mat[i,i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i<n; i++)
            {
                for (int j = 0; j < n; j++) {
                    if (mat[i,j]<0) {
                        count++;
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine("Negative numer: " + count);
        }
    }
}