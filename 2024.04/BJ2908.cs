using System;
using static System.Console;

class BJ2908
{
    public static void Const()
    {
        int[] n = Array.ConvertAll(ReadLine().Split(), int.Parse);

        int a = n[0]/100 + n[0]%100/10*10 + n[0]%10*100;
        int b = n[1]/100 + n[1]%100/10*10 + n[1]%10*100;
        WriteLine(a > b ? a : b);
        ReadLine();
    }
}

// 2024.05.01(수) 해결
// 숫자의 각 자리를 바꾸고 바뀐 두 수를 비교하여 출력하는 문제였다.
// Array.Reverse()메소드를 사용하면 더 간편하다.