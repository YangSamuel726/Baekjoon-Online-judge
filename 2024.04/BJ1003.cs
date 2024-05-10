using System;
using System.Globalization;
using static System.Console;

class BJ1003
{
    public static void Fibonacci()
    {
        int n = int.Parse(ReadLine());
        int[] fa = new int[n];
        for(int i = 0; i < n; i++)
        {
            fa[i] = int.Parse(ReadLine());
        }
        //---------------------------------
        int[] zc = new int[41];
        int[] oc = new int[41];
        zc[0] = 1;
        zc[1] = 0;
        oc[0] = 0;
        oc[1] = 1;

        for(int j = 2; j <= 40; j++)
        {
            oc[j] = oc[j-1] + oc[j-2];
            zc[j] = zc[j-1] + zc[j-2];
        }
        for(int f = 0; f < fa.Length; f++)
        {
            WriteLine($"{zc[fa[f]]} {oc[fa[f]]}");
        }
        ReadLine();
    }
}

// 2024.04.29(월) 해결
// 따로따로 세지 말고 2차원 배열을 사용해보는 것도 추천함