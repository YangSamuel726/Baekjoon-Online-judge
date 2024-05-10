using System;
using static System.Console;

class BJ2193
{
    public static void LEE_CHINSU()
    {
        int n = int.Parse(ReadLine());
        long[] dp = new long[n + 1];
        dp[1] = 1;
        if (n > 1) { dp[2] = 1; }

        for (int i = 3; i < n + 1; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
        }
        WriteLine(dp[n]);
        ReadLine();
    }
}

// 2024.04.30(화) 해결
// 다이나믹 프로그래밍 사용.