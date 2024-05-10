using System;
using System.Runtime.Intrinsics.Arm;
using static System.Console;

class BJ1932
{
    public static void Triangle()
    {
        int n = int.Parse(ReadLine());
        int[][] ia = new int[n][];
        int[][] dp = new int[n][];
        for(int i = 0; i < n; i++)
        {
            ia[i] = Array.ConvertAll(ReadLine().Split(), int.Parse);
            dp[i] = new int[i+1];
        }
        dp[0][0] = ia[0][0];
        for(int i = 1; i < n; i++)
        {
            for(int j = 0; j < ia[i].Length; j++)
            {
                int a = 0;
                int b = 0;
                if(j > 0){a = dp[i-1][j-1];}
                if(j < ia[i].Length-1){b = dp[i-1][j];}
                dp[i][j] = Math.Max(a,b) + ia[i][j];
            }
        }
        WriteLine(dp[n-1].Max());
        ReadLine();
    }
}