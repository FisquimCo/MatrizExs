using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para linha e coluna: ");
            Console.WriteLine("Ex.: 3 4 - 3 linhas 4 colunas");

            string[] rc = Console.ReadLine().Split(' ');

            int r = int.Parse(rc[0]);
            int c = int.Parse(rc[1]);

            int[,] mat = new int[r, c];

            for (int i = 0; i < r; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < c; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine();
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine($"Posição - [ linha : {i} coluna : {j} ] ");

                        if (j > 0) { Console.WriteLine($"Esquerda: {mat[i, j - 1]}"); }

                        if (i > 0) { Console.WriteLine($"Acima: {mat[i - 1, j]}"); }

                        if (j < c - 1) { Console.WriteLine($"Direita: {mat[i, j + 1]}"); }

                        if (i < r - 1) { Console.WriteLine($"Abaixo: {mat[i + 1, j]}"); }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
