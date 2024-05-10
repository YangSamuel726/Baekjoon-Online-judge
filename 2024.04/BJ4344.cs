using System;
using static System.Console;
using System.Text;

class BJ4344
{
    public static void AverageOver()
    {
        StringBuilder sb = new StringBuilder();
        int[][] cases = new int[int.Parse(ReadLine())][];
        for (int i = 0; i < cases.Length; i++)
        {
            //입력받은 줄의 값을 배열로 변환
            int[] values = Array.ConvertAll(ReadLine().Split(), int.Parse);
            // cases[i][]에 values[0]의 값만큼 배열을 할당
            cases[i] = new int[values[0]];
            for (int j = 1; j < cases[i].Length + 1; j++)
            {
                cases[i][j - 1] = values[j];
            }
        }

        for (int i = 0; i < cases.Length; i++)
        {
            int sum = 0;
            for (int j = 0; j < cases[i].Length; j++)
            {
                sum += cases[i][j];
            }
            float average = (float)sum / cases[i].Length;
            int count = 0;
            for (int j = 0; j < cases[i].Length; j++)
            {
                if (cases[i][j] > average)
                {
                    count++;
                }
            }
            sb.AppendLine($"{(float)count / cases[i].Length * 100:F3}%");
        }
        WriteLine(sb.ToString().Trim());
        ReadLine();
    }
}

// 2024.04.27(토) 해결
// 학생들의 성적의 평균을 구하고 그 평균을 넘는 아이들의 비율을 구하는 문제였다.