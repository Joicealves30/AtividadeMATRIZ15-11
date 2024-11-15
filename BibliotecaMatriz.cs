using System;
using System.IO;



namespace BibliotecaMatriz
{
    public class Matriz
    {
        public static void leia(int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int colunas = mat.GetLength(1);
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"Digite para [{i}, {j}]:");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }//fim do for do j
            }//fim do for i


        } //Fim do for 
        //fim de leia 

        public static void mostra(int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int colunas = mat.GetLength(1);
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"{mat[i, j],3}|");
                }   //fim do for j
                Console.WriteLine();
            }// fim doa for i

        }// fim do for 



        public static void gera(int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int colunas = mat.GetLength(1);
            Random random = new Random();
            for (int i = 0; i < mat.GetLength(0); i++)

                for (int j = 0; j < mat.GetLength(1); j++)


                    mat[i, j] = random.Next(0, 100);

        }// fim do for 
    }
}

