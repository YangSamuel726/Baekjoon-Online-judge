using System;
using static System.Console;
using System.Linq;
using System.Collections.Generic;

class BJ9095
{
    public static void FuckDp()
    {
        int n = int.Parse(ReadLine());
        int[] intArr = new int[n];
        for (int i = 0; i < n; i++)
        {
            intArr[i] = int.Parse(ReadLine());
        }
        int[] dp = new int[11];

        for (int i = 1; i < 11; i++)
        {
            if (i == 1) dp[i] = 1;
            else if (i == 2) dp[i] = 2;
            else if (i == 3) dp[i] = 4;
            else dp[i] = dp[i - 1] + dp[i - 2] + dp[i - 3];
        }

        for (int i = 0; i < intArr.Length; i++)
        {
            WriteLine(dp[intArr[i]]);
        }
        ReadLine(); // 프로그램 종료를 막기 위한 입력
    }
}

// 2024.04.27(토) 해결
// 1, 2, 3의 합으로 나타낼 수 있는 경우의 수를 구하는 문제였다.
// dp[1] = 1, dp[2] = 2, dp[3] = 4로 초기화하고 dp[i] = dp[i-1] + dp[i-2] + dp[i-3]으로 점화식을 세워 해결하였다.