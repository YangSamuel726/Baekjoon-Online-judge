using System;
using static System.Console;

class BJ11726
{
    public static void Tiling()
    {
        int n = int.Parse(ReadLine());
        int[] dp = new int[Math.Max(n, 2)];

        dp[0] = 1;
        dp[1] = 2;
        for (int i = 2; i < n; i++)
        {
            dp[i] = (dp[i - 1] + dp[i - 2]) % 10007;
        }
        WriteLine(dp[n - 1]);
        ReadLine();
    }
}

// 2024.04.30(화) 해결
// GPT힌트 사용. 다이나믹 프로그래밍 기법.