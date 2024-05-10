using System;
using static System.Console;
using System.Text;
using System.ComponentModel.Design;
class BJ1978
{
    public static void Minority()
    {
        int n = int.Parse(ReadLine());
        int[] mi = Array.ConvertAll(ReadLine().Split(), int.Parse);
        int count = 0;
        for (int i = 0; i < mi.Length; i++)
        {
            if(mi[i] == 1){continue;}
            else if(mi[i] ==2) {count++;}
            else if (mi[i] % 2 == 0) { continue; }
            else if (Check(mi[i])) { count++; }
        }
        WriteLine(count);
        ReadLine();
    }

    static bool Check(int m)
    {
        for (int j = 2; j <= Math.Sqrt(m); j++)
        {
            if (m % j == 0) { return false; }
        }
        return true;
    }
}

// 2024.04.29(월) 해결
// 특정 수 n이 소수인지 확인하기 위해서 2부터 n의 제곱근까지 나눠지는지 계산을 했다.
// n의 제곱근까지만 검사를 한다는 것이 소수판별 과정을 단축하는데 큰 기여를 했다.
// 예시로 100을 검사한다 할 때 2부터 (100의 제곱근인)10까지만 나누기 검사를 한다.