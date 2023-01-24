using System;
using System.Collections.Generic;

namespace ConsoleApp_SoftUni
{
	class Integers : Methods
	{
		string firstMember = "";
		string shoes = "";

		public Integers(string _outfit, string _shoes)
		{
			this.firstMember = _outfit;
			this.shoes = _shoes;
		}

		public void setMembers(string _outfit, string _shoes)
		{
			this.firstMember = _outfit;
			this.shoes = _shoes;
		}
		static void Main()
		{
			List<string> workingDays = new List<string>(new string[]
			{
				DayOfWeek.Monday.ToString(),
				DayOfWeek.Tuesday.ToString(),
				DayOfWeek.Wednesday.ToString(),
				DayOfWeek.Thursday.ToString(),
				DayOfWeek.Friday.ToString(),
				DayOfWeek.Saturday.ToString(),
				DayOfWeek.Sunday.ToString(),
			});

			//Kinds ot Console read -->
			//double age = DoubleRead();
			string userString = StringRead();
			int flowersCount = IntRead();
			int budget = IntRead();
			//double sells = DoubleRead();
			//string day = StringRead();


			 string[] flowers =
			{
				"Roses",
				"Dahlias",
				"Tulips",
				"Narcissus",
				"Gladiolus"
			};

			double[] prices = { 5, 3.8, 2.8, 3, 2.5 };

			int partOfTheDayIndex = stringList.IndexOf(userString);
			//int fruitsIndex = commisions.IndexOf(city);

			if (partOfTheDayIndex == -1)
			{
				Console.WriteLine("Hey, you have a great garden with {броя цвета} {вид цветя} and {останалата сума} leva left");
			}
			else
			{

				int result = ;


				Console.WriteLine($"Not enough money, you need {нужната сума} leva more}.");

			}

			//End of Main()-->
		}
	}

	class Methods
	{

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

		public static int IntRead()
		{ return int.Parse(Console.ReadLine()); }

		public static double DoubleRead()
		{ return double.Parse(Console.ReadLine()); }

		public static string StringRead()
		{ return Console.ReadLine(); }

		public static void IntPrint(int item)
		{
			string result = item.ToString();
			Console.WriteLine(result);
		}

		public static void DoublePrint(double item)
		{
			string result = item.ToString();
			Console.WriteLine(result);
		}

		public static void StringPrint(string item)
		{
			Console.WriteLine(item);
		}
	}

	static class ExtensionMethods
	{
		public static PercentCalc CalcPersent(this double sum, int percent)
		{
			return new PercentCalc(sum, percent); ;
		}

		public static bool IsBetween(this int value, int minimum, int maximum)
		{
			return value >= minimum && value <= maximum;
		}
		public static bool IsBetween(this double value, double minimum, double maximum)
		{
			return value >= minimum && value <= maximum;
		}
	}

	class PercentCalc
	{
		public double persentPart;
		public double loweredSum;
		public double increasedSum;

		public PercentCalc(double sum, int percent)
		{
			double newPercent = Convert.ToDouble(percent);
			persentPart = sum * (newPercent / 100);
			loweredSum = sum - persentPart;
			increasedSum = sum + persentPart;
		}
		public PercentCalc(double sum, double percent)
		{
			persentPart = sum * (percent / 100);
			loweredSum = sum - persentPart;
			increasedSum = sum + persentPart;

		}

		public void SetPercent(double sum, int percent)
		{
			double newPercent = Convert.ToDouble(percent);
			double persentPart = sum * (newPercent / 100);
			double loweredSum = sum - persentPart;
			double increasedSum = sum + persentPart;

			this.persentPart = persentPart;
			this.loweredSum = loweredSum;
			this.increasedSum = increasedSum;

		}
	}
}
