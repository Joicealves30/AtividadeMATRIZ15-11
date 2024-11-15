using System;

 public class Programa
{
    static void Main()
    {
        int linhas = 3; // Número de linhas da matriz
        int colunas = 3; // Número de colunas da matriz

        // Gerar duas matrizes aleatórias
        int[,] matriz1 = GerarMatriz(linhas, colunas);
        int[,] matriz2 = GerarMatriz(linhas, colunas);

        // Exibir as matrizes geradas
        Console.WriteLine("Matriz 1:");
        ExibirMatriz(matriz1);

        Console.WriteLine("Matriz 2:");
        ExibirMatriz(matriz2);

        // Chama a função para somar as matrizes
        int[,] matrizSoma = SomarMatrizes(matriz1, matriz2);

        if (matrizSoma != null)
        {
            // Exibe a matriz resultante
            Console.WriteLine("Matriz Soma:");
            ExibirMatriz(matrizSoma);
        }
        else
        {
            Console.WriteLine("As matrizes não são de mesma ordem.");
        }
    }

    static int[,] GerarMatriz(int linhas, int colunas)
    {
        Random rand = new Random();
        int[,] matriz = new int[linhas, colunas];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                matriz[i, j] = rand.Next(0, 10); // Gera números aleatórios entre 0 e 9
            }
        }

        return matriz;
    }

    static void ExibirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int[,] SomarMatrizes(int[,] matriz1, int[,] matriz2)
    {
        // Verifica se as matrizes são de mesma ordem
        if (matriz1.GetLength(0) != matriz2.GetLength(0) || matriz1.GetLength(1) != matriz2.GetLength(1))
        {
            return null;
        }

        int linhas = matriz1.GetLength(0);
        int colunas = matriz1.GetLength(1);
        int[,] soma = new int[linhas, colunas];

        // Calcula a soma das matrizes
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                soma[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        return soma;
    }
}
