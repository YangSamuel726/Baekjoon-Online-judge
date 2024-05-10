using System;
using static System.Console;
using System.Text;


class BJ4673
{
    public static void SelfNumber()
    {
        bool[] check = new bool[10000];
        check[1] = false;
        StringBuilder sb = new StringBuilder();
        for (int i = 1; i < 10000; i++)
        {
            int n = Calculate(i);
            if (n < 10000)
            {
                check[n] = true;
            }
        }
        for (int i = 1; i < 10000; i++)
        {
            if (!check[i])
            {
                sb.AppendLine(i.ToString());
            }
        }
        WriteLine(sb.ToString().Trim());
        ReadLine();
    }

    static int Calculate(int n)
    {
        int sum = 0;
        if(n <10)
        {
            sum = n + n;
        }
        else if(n < 100)
        {
            sum = n + n / 10 + n % 10;
        }
        else if(n < 1000)
        {
            sum = n + n / 100 + (n % 100) / 10 + n % 10;
        }
        else
        {
            sum = n + n / 1000 + (n % 1000) / 100 + (n % 100) / 10 + n % 10;
        }
        return sum;
    }
}

// 2024.04.27(토) 해결
// 하드코딩 비슷한 문제였다.