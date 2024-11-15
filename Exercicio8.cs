using System;
using System.Collections.Generic;

class Program8
{
    static int VerificaRaios(int n, List<(int, int)> raios)
    {
        HashSet<(int, int)> quadrantes = new HashSet<(int, int)>();

        foreach (var raio in raios)
        {
            if (quadrantes.Contains(raio))
            {
                return 1; // Raio caiu no mesmo lugar novamente
            }
            quadrantes.Add(raio);
        }

        return 0; // Nenhum raio caiu no mesmo lugar
    }

    static void Main()
    {
        // Lê o número de registros de raios
        int n = int.Parse(Console.ReadLine());

        // Lê as coordenadas dos raios e armazena na lista
        List<(int, int)> raios = new List<(int, int)>();
        for (int i = 0; i < n; i++)
        {
            string[] entrada = Console.ReadLine().Split();
            int x = int.Parse(entrada[0]);
            int y = int.Parse(entrada[1]);
            raios.Add((x, y));
        }

        // Imprime o resultado
        Console.WriteLine(VerificaRaios(n, raios));
    }
}