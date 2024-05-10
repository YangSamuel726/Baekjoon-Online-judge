using System;
using static System.Console;

class BJ2747
{
    public static void Fibonacci()
    {
        int n = int.Parse(ReadLine());
        int[] fibo = new int[n + 1];
        fibo[0] = 0;
        fibo[1] = 1;
        for (int i = 2; i < fibo.Length; i++)
        {
            fibo[i] = fibo[i - 1] + fibo[i - 2];
        }
        WriteLine(fibo[n]);
        ReadLine();
    }
}

// 2024.04.30(화) 해결
// n번째 피보나치 수를 구하는 문제였다. 기본적인 동작법은 다이나믹 프로그래밍으로 해결.