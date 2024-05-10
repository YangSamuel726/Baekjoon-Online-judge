using System;
using static System.Console;
using System.Text;

class BJ8958
{
    public static void OXQuiz()
    {
        int n = int.Parse(ReadLine());
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < n; i++)
        {
            int sum = 0;
            int count = 0;
            char[] oxarr = ReadLine().ToCharArray();
            for(int j = 0; j < oxarr.Length; j++)
            {
                if(oxarr[j] == 'O'){count++; sum += count;}
                else{count = 0;}
            }
            sb.AppendLine(sum.ToString());
        }
        WriteLine(sb.ToString().Trim());
        ReadLine();
    }
}

// 2024.04.27(토) 해결
// string type을 foreach문으로 돌리면 char로 변환해서 볼 수 있다는 것을 유념하자(char의 배열이 string임)