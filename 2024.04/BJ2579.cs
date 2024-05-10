using System;
using static System.Console;
using System.Linq;
using System.Text;

class BJ2579
{
    public static void Stair()
    {
        int n = int.Parse(ReadLine());
        int[] stairs = new int[n + 1];
        stairs[0] = 0;
        for (int i = 1; i <= n; i++)
        {
            stairs[i] = int.Parse(ReadLine());
        }
        int[] dp = new int[n + 1];
        dp[0] = 0;
        dp[1] = stairs[1];
        if(n>=2)
        {
            dp[2] = stairs[1] + stairs[2];
        }
        for (int i = 3; i <= n; i++)
        {
            dp[i] = Math.Max(dp[i-3] + stairs[i-1] + stairs[i], dp[i-2] + stairs[i]);
        }
        WriteLine(dp[n]);
        ReadLine();
    }
}

// 2024.04.28(일) 해결
// 처음에는 각 계단의 값만 더하는 식으로 오답을 내었음
// 이후 gpt의 도움을 받아 누적된 전 계단값에 각 계단 값을 더해 누적시킴으로 해결함