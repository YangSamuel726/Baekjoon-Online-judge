using System;
using System.Reflection.Metadata;
using static System.Console;

class BJ2178
{
    public static void Miro()
    {
        int[] n = Array.ConvertAll(ReadLine().Split(), int.Parse);
        char[,] arr = new char[n[0],n[1]];
        int[,] dp = new int[n[0],n[1]];
        bool[,] check = new bool[n[0],n[1]];
        Queue<(int, int)> que = new Queue<(int, int)>();
        for(int i = 0; i < n[0]; i++)
        {
            string s = ReadLine();
            int index = 0;
            foreach(char c in s)
            {
                arr[i,index] = c;
                index++;
            }
        }
        dp[0,0] = 1;
        check[0,0] = true;
        que.Enqueue((0,0));

        while(!check[n[0]-1,n[1]-1])
        {
            var (a, b) = que.Dequeue();
            if(b<n[1]-1 && arr[a,b+1] != '0' &&  !check[a,b+1])
            {que.Enqueue((a,b+1)); dp[a,b+1] = dp[a,b]+1; check[a,b+1] = true;} // 우측 확인
            if(a<n[0]-1 && arr[a+1,b] != '0' && !check[a+1,b])
            {que.Enqueue((a+1,b)); dp[a+1,b] = dp[a,b]+1; check[a+1,b] = true;} // 아래 확인
            if(a>0 && arr[a-1,b] != '0' && !check[a-1,b])
            {que.Enqueue((a-1,b)); dp[a-1,b] = dp[a,b]+1; check[a-1,b] = true;} // 위 확인
            if(b>0 && arr[a,b-1] != '0' && !check[a,b-1])
            {que.Enqueue((a,b-1)); dp[a,b-1] = dp[a,b]+1; check[a,b-1] = true;} // 좌측 확인
        }
        WriteLine(dp[n[0]-1,n[1]-1]);
        ReadLine();
    }
}

// 2024.04.30(화) 해결
// 숫자로 이루어진 미로를 최단 경로로 통과하는 문제였다.
// BFS(너비 우선 탐색)으로 문제를 해결했다. 알고리즘 분류 확인 후 해결.