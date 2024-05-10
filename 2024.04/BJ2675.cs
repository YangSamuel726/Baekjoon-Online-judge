using System;
using static System.Console;

class BJ2675
{
    public static void RptString()
    {
        int n = int.Parse(ReadLine());

        for(int j = 0; j < n; j++)
        {
            string[] s = ReadLine().Split();
            int a = int.Parse(s[0]);
            foreach(char c in s[1])
            {
                for(int k = 0; k < a; k++) {Write(c);}
            }
            WriteLine();
        }
        ReadLine();
    }
}

// 2024.04.30(화)
// 주어진 문자열을 일정 횟수만큼 반복 출력하는 문제였다.
// 좀 무식하게 3중 반복문으로 풀었다.