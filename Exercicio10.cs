using System;

class Program10
{
    static void Main()
    {
        int R = 3; // Número de regiões (linhas)
        int C = 3; // Número de cidades (colunas)

        // Gerar e exibir a matriz de tropas
        int[,] matrizTropas = GerarMatriz(R, C);
        Console.WriteLine("Matriz das Tropas (Quantidade de Tropas por Cidade):");
        ExibirMatriz(matrizTropas);

        // Calcular e exibir a força total de cada região
        Console.WriteLine("Força Total das Regiões:");
        CalcularForcaTotal(matrizTropas);
    }

    static int[,] GerarMatriz(int linhas, int colunas)
    {
        Random rand = new Random();
        int[,] matriz = new int[linhas, colunas];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                matriz[i, j] = rand.Next(0, 101); // Gera valores aleatórios entre 0 e 100
            }
        }

        return matriz;
    }

    static void ExibirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            Console.Write("Região " + (i + 1) + ": ");
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void CalcularForcaTotal(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            int soma = 0;
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                soma += matriz[i, j];
            }
            Console.WriteLine($"Região {i + 1}: {soma} tropas");
        }
    }
}
