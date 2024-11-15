using System;
using BibliotecaMatriz;

class Exercicio_4_e_5
{
    static void diagonalPrincipal(int[,] mat)
    {
        int linhas = mat.GetLength(0);
        for (int i = 0; i < linhas; i++)
            Console.Write($"{mat[i, i]}|");
    }
    static void diagonalSecundaria(int[,] mat)
    {
        int linhas = mat.GetLength(0);
        int colunas = mat.GetLength(1);
        int j = colunas - 1;
        for (int i = 0; i < linhas; i++, j--)

            Console.Write($"{mat[i, j]}|");

    }


    static void Main()
    {
        int linhas, cols;
        Console.WriteLine("Quantidade de linhas e colunas:");
        linhas = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());
        if (linhas == cols)
        {
            int[,] matrix = new int[linhas, cols];// criando a matriz
            Matriz.gera(matrix);
            Console.WriteLine("Matriz Gerada");
            Matriz.mostra(matrix);
            Console.WriteLine("Diaginal principal:");
            diagonalPrincipal(matrix);
        }
        else
        {
            Console.WriteLine("Não é possível apresentar dados para esta dimensao");
        }
        Console.ReadKey();

    }
}