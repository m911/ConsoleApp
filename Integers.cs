using System;
namespace ConsoleApp_SoftUni
{
	static class MyClass
	{
		public static bool IsBetween(this int value, int minimum, int maximum)
		{
			return value >= minimum && value <= maximum;
		}
	}
	class Integers
	{
		static void Main()
		{
			//string input = Console.ReadLine().ToLower();

			//double input = DoubleRead();

			int input = IntRead();
			//int input2 = IntRead();
			//int input3 = IntRead();

			

			//string[] shapes = { "square", "rectangle", "circle", "triangle" };
			//int position = Position(input, shapes);

			int bonusPoints = 0;
			switch (true)
			{
				case input.IsBetween(0, 100):
					double a = Math.Abs(DoubleRead());
					double res1 = Math.Pow(a, 2);
					Console.WriteLine($"{res1:f3}");
					break;
				case 2:
					double c = Math.Abs(DoubleRead());
					double b = Math.Abs(DoubleRead());
					Console.WriteLine($"{c * b:f3}");
					break;
				case 3:
					double d = Math.Abs(DoubleRead());
					double res2 = Math.PI * Math.Pow(d, 2);
					Console.WriteLine($"{res2:f3}");
					break;
				case 4:
					double e = Math.Abs(DoubleRead());
					double f = Math.Abs(DoubleRead());
					double res3 = (e * f) / 2;
					Console.WriteLine($"{res3:f3}");
					break;
			}

		}

		static int Position(string input, string[] array)
		{
			int pos = 0;
			for (int i = 0; i < array.Length; i++)

			{
				if (array[i] == input)
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


	enum CheckString
	{
		square,
		rectangle,
		circle,
		triangle,
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