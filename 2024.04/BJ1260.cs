using System;
using static System.Console;
using System.Linq;
using System.Text;
using System.Collections.Generic;

class BJ1260
{
    public static void DFSBFS()
    {
        int[] nmv = Array.ConvertAll(ReadLine().Split(), int.Parse);
        int n = nmv[0];
        int m = nmv[1];
        int v = nmv[2];
        int[,] graph = new int[n + 1, n + 1];
        for(int i = 0; i < m; i++)
        {
            int[] edge = Array.ConvertAll(ReadLine().Split(), int.Parse);
            graph[edge[0], edge[1]] = 1;
            graph[edge[1], edge[0]] = 1;
        }
        StringBuilder sb = new StringBuilder();
        bool[] visited = new bool[n + 1];
        DFS(graph, v, visited, sb);
        sb.AppendLine();
        visited = new bool[n + 1];
        BFS(graph, v, visited, sb);
        WriteLine(sb.ToString().Trim());
        ReadLine();
    }
    
    static void DFS(int[,] graph, int v, bool[] visited, StringBuilder sb)
    {
        visited[v] = true;
        sb.Append(v + " ");
        for(int i = 1; i < graph.GetLength(0); i++)
        {
            if(graph[v, i] == 1 && !visited[i]) // 연결되어 있고 방문하지 않았다면
            {
                DFS(graph, i, visited, sb);
            }
        }
    }

    static void BFS(int[,] graph, int v, bool[] visited, StringBuilder sb)
    {
        visited[v] = true;
        Queue<int> q = new Queue<int>();
        q.Enqueue(v);
        while(q.Count > 0)
        {
            int node = q.Dequeue();
            sb.Append(node + " ");
            for(int i = 1; i < graph.GetLength(0); i++)
            {
                if(graph[node, i] == 1 && !visited[i])
                {
                    visited[i] = true;
                    q.Enqueue(i);
                }
            }
        }
    }
}

// 2024.04.28(일) 해결
// 트리와 그래프를 탐색하는 알고리즘임 깊이냐 너비냐에 따라 다른 방식의 검색을 수행함