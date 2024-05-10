using System;
using static System.Console;

class BJ1065
{
    public static void Hansu()
    {
        int n = int.Parse(ReadLine());
        int count = 0;
        for(int i = 1; i <= n; i++)
        {
            if(i < 100)
            {
                count++;
            }
            else if(i < 1000)
            {
                if(i/100 - i/10%10 == i/10%10 - i%100%10)
                {count++;}
            }
        }
        WriteLine(count);
        ReadLine();
    }
}

// 2024.04.28(일) 해결
// 크게 어렵지 않았음. 간단
// 어떤 수 n에 대하여 각 자리 숫자가 등차수열을 이루는 숫자를 찾는 문제였다.