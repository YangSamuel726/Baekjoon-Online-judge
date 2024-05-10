using System;
using static System.Console;
using System.Text;

class BJ10845
{
    public static void Q()
    {
        int n = int.Parse(ReadLine());
        Queue<int> intq = new Queue<int>();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            string[] s = ReadLine().Split();
            switch (s[0])
            {
                case "push":
                    intq.Enqueue(int.Parse(s[1])); break;
                case "pop":
                    sb.AppendLine(intq.Count() == 0 ? "-1" : intq.Dequeue().ToString()); break;
                case "size":
                    sb.AppendLine(intq.Count().ToString()); break;
                case "empty":
                    sb.AppendLine(intq.Count() == 0 ? "1" : "0"); break;
                case "front":
                    sb.AppendLine(intq.Count() == 0 ? "-1" : intq.First().ToString()); break;
                case "back":
                    sb.AppendLine(intq.Count() == 0 ? "-1" : intq.Last().ToString()); ; break;
                default: break;
            }
        }
        WriteLine(sb);
        ReadLine();
    }
}

// 2024.05.01(수) 해결
// Q를 활용하여 입출력 문제를 해결하는 문제였다.
// ? 조건부 연산자에서 참&거짓 값의 형식이 동일해야 한다는 것을 배움