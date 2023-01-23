namespace DayOfWeek
{
	//enum Days
	//{
	//	square,
	//	rectangle,
	//	circle,
	//	triangle,
	//}s
	class Strings
	{
		static void Main()
		{
			string movieName = Console.ReadLine();

			string selectedDay = "";

			string[] daysOfTheWeek ={
			"Monday",
			"Touesday",
			"Wednesday",
			"Thursday",
			"Friday",
			"Saturday",
			"Sunday"
			};

			List<string> dayNames = new List<string>(daysOfTheWeek);

			//switch (Position(shapes))
			//{
			//	case 1:
			//		bonusPoints = 5;
			//		break;
			//	case 2:
			//		double c = Math.Abs(DoubleRead());
			//		double b = Math.Abs(DoubleRead());
			//		Console.WriteLine($"{c * b:f3}");
			//		break;
			//	case 3:
			//		double d = Math.Abs(DoubleRead());
			//		double res2 = Math.PI * Math.Pow(d, 2);
			//		Console.WriteLine($"{res2:f3}");
			//		break;
			//	case 4:
			//		double e = Math.Abs(DoubleRead());
			//		double f = Math.Abs(DoubleRead());
			//		double res3 = (e * f) / 2;
			//		Console.WriteLine($"{res3:f3}");
			//		break;
			//}


		}
		int IntRead()
		{ return int.Parse(Console.ReadLine()); }

		double DoubleRead()
		{ return double.Parse(Console.ReadLine()); }

		string StringRead()
		{ return Console.ReadLine(); }
	}
}

