using System;
using static System.Console;

class BJ1149
{
    public static void RGB()
    {
        int n = int.Parse(ReadLine());
        //-----------------------------------
        int[] rdp = new int[n];
        int[] gdp = new int[n];
        int[] bdp = new int[n];
        for (int i = 0; i < n; i++)
        {
            int[] color = Array.ConvertAll(ReadLine().Split(), int.Parse);
            if (i == 0) { rdp[i] = color[0]; gdp[i] = color[1]; bdp[i] = color[2]; }
            else
            {
                rdp[i] = Math.Min(gdp[i - 1], bdp[i - 1]) + color[0];
                gdp[i] = Math.Min(rdp[i - 1], bdp[i - 1]) + color[1];
                bdp[i] = Math.Min(gdp[i - 1], rdp[i - 1]) + color[2];
            }
        }
        int Min = new int[] { rdp[n - 1], gdp[n - 1], bdp[n - 1] }.Min();
        WriteLine(Min);
        ReadLine();
    }
}

// 2024.04.29(월) 해결
// 각 집을 어떤 색으로 칠하느냐에 따른 최소비용을 구하는 문제였다.
// 다이나믹 프로그래밍 사용. gpt힌트를 사용했다.