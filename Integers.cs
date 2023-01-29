using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

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

		public static void IntPrint(int key)
		{
			string result = key.ToString();
			Console.WriteLine(result);
		}

		public static void DoublePrint(double key)
		{
			string result = key.ToString();
			Console.WriteLine(result);
		}

		public static void StringPrint(string key)
		{
			Console.WriteLine(key);
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
		public PercentCalc() { }
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
		public List<string> Season = new List<string>();
		public SortedList<string, double> Prices = new SortedList<string, double>();
		public bool InPromotion = false;
		public List<int> DiscountsIndex = new List<int>();
		public List<int> DiscountsValues = new List<int>();

		//Constructor
		public Integers(string season1, string season2, string housing1, string housing2, double price1, double price2, int limit1 = 0, int discount1 = 0,
			int limit2 = 0, int discount2 = 0)
		{
			Season.AddRange(new string[] { season1, season2 });
			Prices.Add(housing1, price1);
			Prices.Add(housing2, price2);

			if (limit1 > 0 | limit2 > 0)
			{
				InPromotion = true;
				AddDiscountPrice(limit1, discount1);
				AddDiscountPrice(limit2, discount2);
				
			}
		}

		//Methods
		public void AddDiscountPrice(int limit, int discount)
		{
			DiscountsIndex.Add(limit);
			DiscountsValues.Add(discount);
		}

		public SortedList<string, double> GetPromoPrice(int orders)
		{
			SortedList<string, double> Result = new SortedList<string, double>();
			if (InPromotion && DiscountsIndex.Any(key => orders > key))
			{
				double firstPrice = Prices.Values[0];
				double secondPrice = Prices.Values[1];
				firstPrice = firstPrice.CalcPersent(DiscountsValues[0]).loweredSum;
				secondPrice = secondPrice.CalcPersent(DiscountsValues[1]).loweredSum;
				Result = Prices;
			};
			return Result;
		}

		public void CalcTotalPrice (int orders)
		{

			Prices.Values.Aggregate()
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
			//string day = StringRead();
			string userInput = StringRead();
			int readFirst = IntRead();
			//int readSecond = IntRead();
			//double budget = DoubleRead();

			//Define price interfaces


			//Define string list to search in

			//Price defining
			List<Integers> db = new List<Integers>();
			Integers int1 = new Integers("May", "October", "Studio", "Apartment", 50, 65, 7, 5, 14, 10);
			int1.AddDiscountPrice(14, 30);
			Integers int2 = new Integers("June", "September", "Studio", "Apartment", 75.20, 68.70, 14, 20, 14, 10);
			Integers int3 = new Integers("July", "August", "Studio", "Apartment", 76, 77, 0, 0, 14, 10);
			db.Add(int1);
			db.Add(int2);
			db.Add(int3);

			//Define discounts condition and their values

			//Calculating discounts
			Integers selectedPrice = db.Find(item => item.Season.Contains(userInput));
			Console.WriteLine("Apartment: {0:f2} lv.", selectedPrice.Prices["Apartment"]);
			Console.WriteLine("Studio: {0:f2} lv.", selectedPrice.Prices["Studio"]);
		}
	}
}
