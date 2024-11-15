using System;
using BibliotecaMatriz;

namespace matriz
{
    internal class Program
    {
        static int maiorValorMatriz(int[,] mat)
        {
            int linhas = mat.GetLength(0); // pega linhas
            int cols = mat.GetLength(1);
            int maior = mat[0, 0];
            for (int i = 0; i < linhas; i++)
                for (int j = 0; j < cols; j++)
                    if (mat[i, j] > maior)
                        maior = mat[i, j];
            // terminou percorrer funcao
            return maior;
        }
        static int menorValorMatriz(int[,] mat)
        {
            int linhas = mat.GetLength(0); // pega linhas
            int cols = mat.GetLength(1);
            int menor = mat[0, 0];
            for (int i = 0; i < linhas; i++)
                for (int j = 0; j < cols; j++)
                    if (mat[i, j] < menor)
                        menor = mat[i, j];
            // terminou percorrer funcao
            return menor;
        }

        static void Main()

        {
            int linhas, colunas;
            Console.WriteLine("*** Matrizes ***");
            Console.WriteLine("quantidade de linhas e colunas:");
            linhas = int.Parse(Console.ReadLine());
            colunas = int.Parse(Console.ReadLine());
            int[,] matrix = new int[linhas, colunas];//criando a matriz
            Console.WriteLine(" Entre com dados para matriz:");
            Matriz.mostra(matrix);
            Matriz.gera(matrix);
            Console.WriteLine("Matriz gerada:");
            Matriz.mostra(matrix);
            Console.ReadKey();


        }

    }

}


