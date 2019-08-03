using System;
using System.Linq;

namespace NumericKey
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			int[] errorCount = new int[12];
			int[] correctCount = new int[12];
			int count = 0;
			char nc;
			Console.WriteLine("按任意键开始");
			char input = Console.ReadKey().KeyChar;

			while (input != 'q')
			{
				int n = rnd.Next(12);
			error:
				if (n == 10)
				{
					nc = '-';
					Console.WriteLine($"输入: {nc}");
				}
				else if (n == 11)
				{
					nc = '=';
					Console.WriteLine($"输入: {nc}");
				}
				else
				{
					nc = (char)(n + 48);
					Console.WriteLine($"输入: {nc}");
				}

				input = Console.ReadKey().KeyChar;
				if (input == nc)
				{
					correctCount[n]++;
					Console.WriteLine("\n正确");
				}
				else
				{
					errorCount[n]++;
					Console.WriteLine("\n\t错误");
					if (input != 'q')
						goto error;
				}
				Console.WriteLine("------------------------");
				count++;
			}
			Console.WriteLine("结束");
			Console.WriteLine("统计结果：");
			for (int i = 0; i < 10; i++)
			{
				string p = ((float)correctCount[i] / (correctCount[i] + errorCount[i])).ToString("P");
				Console.WriteLine($"{i} : {p}");
			}
			string p1 = ((float)correctCount[10] / (correctCount[10] + errorCount[10])).ToString("P");
			Console.WriteLine($"- : {p1}");
			string p2 = ((float)correctCount[11] / (correctCount[11] + errorCount[11])).ToString("P");
			Console.WriteLine($"= : {p2}");

			Console.WriteLine($"总正确率: {((float)correctCount.Sum() / count).ToString("p")}");

			Console.ReadKey();
		}
	}
}
