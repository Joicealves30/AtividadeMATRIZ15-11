using System;

class Programa7
{
    static void Main()
    {
        // Definindo o tamanho das matrizes
        int N = 3;
        int M = 3;

        // Gerar duas matrizes aleatórias
        double[,] matriz1 = GerarMatriz(N, M);
        double[,] matriz2 = GerarMatriz(N, M);

        // Menu de opções
        char opcao;
        do
        {
            Console.WriteLine("Menu de Opções:");
            Console.WriteLine("(a) Somar as duas matrizes");
            Console.WriteLine("(b) Subtrair a primeira matriz da segunda");
            Console.WriteLine("(c) Adicionar uma constante às duas matrizes");
            Console.WriteLine("(d) Imprimir as matrizes");
            Console.WriteLine("(e) Sair");
            opcao = char.Parse(Console.ReadLine().ToLower());

            switch (opcao)
            {
                case 'a':
                    double[,] soma = SomarMatrizes(matriz1, matriz2);
                    Console.WriteLine("Resultado da Soma:");
                    ExibirMatriz(soma);
                    break;
                case 'b':
                    double[,] subtracao = SubtrairMatrizes(matriz2, matriz1);
                    Console.WriteLine("Resultado da Subtração:");
                    ExibirMatriz(subtracao);
                    break;
                case 'c':
                    Console.WriteLine("Informe o valor da constante:");
                    double constante = double.Parse(Console.ReadLine());
                    AdicionarConstante(matriz1, constante);
                    AdicionarConstante(matriz2, constante);
                    Console.WriteLine("Constante adicionada às matrizes.");
                    break;
                case 'd':
                    Console.WriteLine("Matriz 1:");
                    ExibirMatriz(matriz1);
                    Console.WriteLine("Matriz 2:");
                    ExibirMatriz(matriz2);
                    break;
                case 'e':
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        } while (opcao != 'e');
    }

    static double[,] GerarMatriz(int linhas, int colunas)
    {
        Random rand = new Random();
        double[,] matriz = new double[linhas, colunas];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                matriz[i, j] = rand.NextDouble() * 100; // Gera valores reais aleatórios entre 0 e 100
            }
        }

        return matriz;
    }

    static void ExibirMatriz(double[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"{matriz[i, j]:F2} ");
            }
            Console.WriteLine();
        }
    }

    static double[,] SomarMatrizes(double[,] matriz1, double[,] matriz2)
    {
        int linhas = matriz1.GetLength(0);
        int colunas = matriz1.GetLength(1);
        double[,] soma = new double[linhas, colunas];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                soma[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        return soma;
    }

    static double[,] SubtrairMatrizes(double[,] matriz1, double[,] matriz2)
    {
        int linhas = matriz1.GetLength(0);
        int colunas = matriz1.GetLength(1);
        double[,] subtracao = new double[linhas, colunas];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                subtracao[i, j] = matriz1[i, j] - matriz2[i, j];
            }
        }

        return subtracao;
    }

    static void AdicionarConstante(double[,] matriz, double constante)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] += constante;
            }
        }
    }
}
