using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
	public class DemoUser
	{
		public static string[] Tasks()
		{
			return new string[] {
				"Task_1 - сложить два числа переданных во входных параметрах и вернуть как результат функции",
				"Task_2 - умножить два числа переданных во входных параметрах и вернуть как результат функции" };
		}
		public static int Task_1(int a, int b)
		{
			return a + b;
		}
		public static int Task_2(int a, int b)
		{
			return a * b;
		}
	}
}