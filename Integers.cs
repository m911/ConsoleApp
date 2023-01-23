using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace ConsoleApp_SoftUni
{
	static class MyClass
	{
		public static bool IsBetween(this int value, int minimum, int maximum)
		{
			return value >= minimum && value <= maximum;
		}
		public static bool IsBetween(this int value, double minimum, double maximum)
		{
			return value >= minimum && value <= maximum;
		}
	}
	class Integers
	{
		static void Main()
		{
			string[] arrayDays ={
			"Monday",
			"Touesday",
			"Wednesday",
			"Thursday",
			"Friday",
			"Saturday",
			"Sunday"
			};

			List<string> dayNames = new List<string>(arrayDays);

			//Kinds ot Console read -->
			//double budget = DoubleRead();
			//int video = IntRead();
			//string movieName = Console.ReadLine();
			//int totalBreak = IntRead();
			int query = IntRead();
			
			

			//End of Main()-->
		}

		static int Position(bool[] array)
		{
			int pos = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == true)
				{
					pos = i + 1;
					break;
				}
			}
			return pos;
		}

		static int IntRead()
		{ return int.Parse(Console.ReadLine()); }

		static double DoubleRead()
		{ return double.Parse(Console.ReadLine()); }

		static string StringRead()
		{ return Console.ReadLine(); }

		static void IntPrint(int item)
		{
			string result = item.ToString();
			Console.WriteLine(result);
		}

		static void DoublePrint(double item)
		{
			string result = item.ToString();
			Console.WriteLine(result);
		}

		static void StringPrint(string item)
		{
			Console.WriteLine(item);
		}
	}

	class PercentCalc
	{
		public double persentPart;
		public double loweredSum;
		public double increasedSum;

		public PercentCalc(int percent, double sum)
		{
			double newPercent = Convert.ToDouble(percent);
			persentPart = sum * (newPercent / 100);
			loweredSum = sum - persentPart;
			increasedSum = sum + persentPart;

		}
		public PercentCalc(double percent, double sum)
		{
			persentPart = sum * (percent / 100);
			loweredSum = sum - persentPart;
			increasedSum = sum + persentPart;

		}
	}
}