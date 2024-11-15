using System;
using System.Collections.Generic;

class Program9
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        List<(int Xi, int Xf, int Yi, int Yf)> redes = new List<(int, int, int, int)>();

        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            int Xi = int.Parse(input[0]);
            int Xf = int.Parse(input[1]);
            int Yi = int.Parse(input[2]);
            int Yf = int.Parse(input[3]);
            redes.Add((Xi, Xf, Yi, Yf));
        }

        int area = CalcularAreaCoberta(redes);
        Console.WriteLine(area);
    }

    static int CalcularAreaCoberta(List<(int Xi, int Xf, int Yi, int Yf)> redes)
    {
        const int MAX = 1001;
        bool[,] mar = new bool[MAX, MAX];
        int area = 0;

        foreach (var (Xi, Xf, Yi, Yf) in redes)
        {
            for (int x = Xi; x <= Xf; x++)
            {
                for (int y = Yi; y <= Yf; y++)
                {
                    if (!mar[x, y])
                    {
                        mar[x, y] = true;
                        area++;
                    }
                }
            }
        }

        return area;
    }
}
