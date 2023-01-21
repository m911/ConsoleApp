using System;

namespace ConsoleApp_SoftUni
{
	class Integers
	{
		static void Main()
		{
			double nylonPrice = 1.5 * IntRead();
			double paintPrice = 14.50 * IntRead();
			int diluentPrice = 5 * IntRead();
			int hours = IntRead();

			double totalPrice = nylonPrice + paintPrice + diluentPrice;

			double discount2 = Convert.ToDouble(hours) / 100;
			double discountPrice = totalPrice * discount2;

			double result = totalPrice - discountPrice;
			DoublePrint(result);
		}

		public static object Discounted (int discount, double discountedPrice)
		{
			discount = discount/ 100;
			

			return new object();
		}

		public static int IntRead()
		{ return int.Parse(Console.ReadLine()); }

		public static double DoubleRead()
		{ return double.Parse(Console.ReadLine()); }

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
	}
}