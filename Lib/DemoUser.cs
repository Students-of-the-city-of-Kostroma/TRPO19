using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
	public class DemoUser
	{
		/// <summary>
		/// Возвращает описание тасков
		/// </summary>
		/// <returns></returns>
		public static string[] Tasks()
		{
			return new string[] {
				"Task_1 - сложить два числа переданных во входных параметрах и вернуть как результат функции",
				"Task_2 - умножить два числа переданных во входных параметрах и вернуть как результат функции" };
		}
		/// <summary>
		/// сложить два числа переданных во входных параметрах и вернуть как результат функции
		/// </summary>
		/// <param name="a">Первое слогаемое</param>
		/// <param name="b">Второе слогаемое</param>
		/// <returns></returns>
		public static int Task_1(int a, int b)
		{
			return a + b;
		}
		/// <summary>
		/// умножить два числа переданных во входных параметрах и вернуть как результат функции
		/// </summary>
		/// <param name="a">первый множитель</param>
		/// <param name="b">второй множитель</param>
		/// <returns></returns>
		public static int Task_2(int a, int b)
		{
			return a * b;
		}
	}
}