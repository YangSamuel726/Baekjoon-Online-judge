using System;
using System.Reflection.PortableExecutable;
using System.Text;
using static System.Console;

class BJ10809
{
    public static char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
    public static StringBuilder sb = new StringBuilder();
    public static void FindAlphabet()
    {
        string s = ReadLine();
        
            char[] characters = s.ToCharArray();
        

        for(int i = 0; i < alphabet.Length; i++)
        {
            sb.Append(Array.IndexOf(characters, alphabet[i]) + " ");
        }
        WriteLine(sb.ToString().Trim());
    }
}

// 2024.04.26(금) 해결
// 문자열 검색에 관련된 문제였음 특히 IndexOf()메서드가 검색하는 문자열이 없을 경우 -1을 반환하는 것을 이용하여 해결하였다.