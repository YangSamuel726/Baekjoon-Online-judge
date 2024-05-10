using System;
using static System.Console;

class BJ1157
{
    public static void WordStudy()
    {
        string s = ReadLine()?.ToLower() ?? string.Empty;
        int[] count = new int[26];
        bool same = false;
        int max = 0;
        char result = '?';
        foreach (char c in s)
        {
            int index = c - 'a';
            count[index]++;
            if(count[index] > max){max = count[index]; same = false; result = c;}
            else if(count[index] == max){same = true;}
        }
        if(same == true){WriteLine("?");}
        else{WriteLine(char.ToUpper(result));}
        ReadLine();
    }
}

// 2024.05.01(수)해결
// MatchCollection 클래스를 사용해 문자열에서 어떤 문자 c와 매치되는 수를 구했으나 중복 검사가 알파벳 수만큼 되서
// 문자 하나 하나를 따로 검색해서 count를 올리는 식으로 계산했다.