using System;
using static System.Console;

class BJ2920
{
    public static void Scale()
    {
        string s = ReadLine();
        if(s == "1 2 3 4 5 6 7 8"){WriteLine("ascending");}
        else if(s == "8 7 6 5 4 3 2 1"){WriteLine("descending");}
        else{WriteLine("mixed");}
        ReadLine();
    }
}

// 2024.04.29(월) 해결
// 입력받은 숫자의 형태에 따라 그에 맞는 상태를 출력하는 문제였다.
// 그냥 하드코딩했다. 그게 간단하고 짧아보여서.
// 웬만하면 하드코딩하지 말고 확장성을 생각해서 풀어보자