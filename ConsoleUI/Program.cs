using System;
using Lib;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{

			while (Menu()) Console.WriteLine("=========================================================================");
		}
		static string[] fams = { "DemoUser", "Demo", "User" };
		static bool Menu()
		{
			Console.WriteLine("Вы запустили программу в которой собраны работы студентов ВУЗа КГУ 2019 года поступления");
			Console.WriteLine("Укажите фамилию или часть фамили студента");
			foreach (string fam in fams) Console.WriteLine(fam);
			Console.WriteLine("Нажимет Enter для выхода из программы");
			string inFam = Console.ReadLine();
			if (string.IsNullOrEmpty(inFam)) return false;
			string[] resultFams;
			resultFams = Array.FindAll(fams, s => s.Contains(inFam));
			if (resultFams.Length == 0) Console.WriteLine("Совпадений со списком студентов не найдено");
			else if (resultFams.Length > 1)
			{
				Console.WriteLine("Найдено несколько совпадений:");
				foreach (string fam in resultFams) Console.WriteLine(fam);
			}
			else ShowTasks(resultFams[0]);
			return true;
		}
		static void ShowTasks(string fam)
		{
			Console.WriteLine("Задачи студента " + fam + " :");
			switch (fam)
			{
				case "Demo": while (DemoUser()) ; break;
				default: Console.WriteLine("Задачи студента не найдены"); break;
			}
		}
		static bool DemoUser()
		{
			string[] tasks = Lib.DemoUser.Tasks();
			foreach (string task in tasks) Console.WriteLine(task);
			
			string[] resultTask;
			while(true)
			{
				string inTask = Console.ReadLine();
				if (string.IsNullOrEmpty(inTask)) return false;
				resultTask = Array.FindAll(tasks, s => s.Contains(inTask));
				if (resultTask.Length > 1)
				{
					Console.WriteLine("Найдено несколько совпадений:");
					foreach (string task in resultTask) Console.WriteLine(task);
				}
				else if (resultTask.Length == 0) Console.WriteLine("Совпадений со списком задач не найдено");
				else break;
			}
			switch (Array.IndexOf(tasks, resultTask[0])+1)
			{
				case 1: Task_1_Of_DemoUser(); break;
				case 2: Task_2_Of_DemoUser(); break;
				default: Console.WriteLine("Задача студента не найдена"); break;
			}
			return true;
		}
		static void Task_1_Of_DemoUser()
		{
			int a, b;
			do
			{
				Console.Write("Введите число a:");
			} while (!int.TryParse(Console.ReadLine(), out a));
			do
			{
				Console.Write("Введите число b:");
			} while (!int.TryParse(Console.ReadLine(), out b));
			Console.WriteLine("Результат: " + Lib.DemoUser.Task_1(a, b));
		}
		static void Task_2_Of_DemoUser()
		{
			int a, b;
			do
			{
				Console.Write("Введите число a:");
			} while (!int.TryParse(Console.ReadLine(), out a));
			do
			{
				Console.Write("Введите число b:");
			} while (!int.TryParse(Console.ReadLine(), out b));
			Console.WriteLine("Результат: " + Lib.DemoUser.Task_2(a, b));
		}
	}
}
