using System;
using static System.Console;
using System.Text;

class BJ9012

{
    public static void VPS()
    {
        int n = int.Parse(ReadLine());
        StringBuilder sb = new StringBuilder();

        for(int i = 0; i < n; i++)
        {
            int count = 0;
            bool check = false;
            string s = ReadLine();
            foreach(char c in s)
            {
                if( c == '('){count++;}
                else if(c == ')'){count--;}
                if(count <0 && !check){check = true; sb.AppendLine("NO");}
            }
            if(count == 0 && !check){sb.AppendLine("YES");}
            else if(count > 0 && !check){sb.AppendLine("NO");}
        }
        WriteLine(sb);
        ReadLine();
    }
}

// 2024.04.29(월) 해결
// Stack 자료구조를 통해 더욱 간단하고 쉽게 만들 수 있다. 나중에 시간되면 해보길 바람