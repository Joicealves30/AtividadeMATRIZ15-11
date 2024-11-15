
using System;
using System.Globalization;
using BibliotecaMatriz;

class Program
{
    static void Main()
    {
        
        int N ;
        int M ;

        // Inicializando a matriz com alguns valores
        int[,] matriz = { };

        // Solicita ao usuário para informar o valor de X
        Console.WriteLine("Informe o valor de X:");
        int X = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Chama a função para contar as ocorrências de X na matriz
        int ocorrencias = ContarOcorrencias(matriz, N, M, X);

        // Exibe o resultado
        Console.WriteLine($"O número {X} aparece {ocorrencias} vezes na matriz.");
    }

    static int ContarOcorrencias(int[,] matriz, int N, int M, int X)
    {
        int count = 0;

        // Percorre a matriz e conta as ocorrências de X
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                if (matriz[i, j] == X)
                {
                    count++;
                }
            }
        }

        return count;

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
