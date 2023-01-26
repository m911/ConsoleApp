using System;
using System.Collections.Generic;

namespace ConsoleApp_SoftUni
{
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
			int budget = IntRead();
			string userString = StringRead();
			int quantity = IntRead();
			//double sells = DoubleRead();
			//string day = StringRead();

			//Define string list to search in
			string[] flowerNames =
			{
				"Spring", "Summer", "Autumn", "Winter"
			};
			List<string> stringList = new List<string>(flowerNames);

			//Define prices and discounts
			int[] prices = { 3000, 4200, 4200, 2600 };
			int[] discountCondition = { 6, 11, int.MaxValue };
			int[] discounts = { 10, 15, 25 };
			int selectedSeason = stringList.IndexOf(userString);

			//Price defining
			double totalPrice = prices[selectedSeason];

			//Discounts
			int discount = discounts[selectedSeason];
			for (int i = 0; i < discountCondition.Length; i++)
			{
				if (quantity >= discountCondition[i])
				{
					discount = discounts[i];
				}
			}
			totalPrice = totalPrice.CalcPersent(discount).loweredSum;

			if (quantity % 2 == 0 && selectedSeason != 2)
			{
				totalPrice = totalPrice.CalcPersent(discount).loweredSum;
			}

			//Output condition
			if (totalPrice <= budget)
			{
				Console.WriteLine("Yes! You have {0:f2} leva left.", budget - totalPrice);
			}
			else
			{
				Console.WriteLine("Not enough money! You need {0:f2} leva.", totalPrice - budget);

			}

			// Keep the console window open in debug mode.
			//System.Console.WriteLine("Press any key to exit.");
			//System.Console.ReadKey();
			//End of Main()-->
		}
	}
}
