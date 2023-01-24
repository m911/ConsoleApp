using System;
using System.Collections.Generic;
using System.Linq;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System.Runtime.CompilerServices;

namespace ConsoleApp_SoftUni
{
	class Integers : Methods
	{
		static void Main()
		{
			//Kinds ot Console read -->
			//double age = DoubleRead();
			//int video = IntRead();
			string product = StringRead();
			string day = StringRead();
			//int number = IntRead();
			double quantity = DoubleRead();
			
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


			List<double> priceWorkingday = new List<double>(new double[]
			{
				2.50 ,1.20,0.85,1.45,2.70,5.50,3.85
			});

			List<double> priceWeekend = new List<double>(new double[]
            {
                    2.70,1.25,0.90,1.6,3,5.6,4.2
            });

			List<string> fruits = new List<string>(new string[]
			{
				"banana",
				"apple",
				"orange",
				"grapefruit",
				"kiwi",
				"pineapple",
				"grapes"
			});
            
            if (workingDays.IndexOf(day) != -1 && fruits.IndexOf(product) != -1)
            {

            bool isWeekEnd = workingDays.IndexOf(day) == -1;
			bool isWeekEnd = workingDays.IndexOf(day) == -1;
            List<double> weekEndPrice = isWeekEnd ? priceWeekend : priceWorkingday;

			double result = (weekEndPrice[fruits.IndexOf(product)]) * quantity;
            } else {

                Console.WriteLine("error");
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
		public static bool IsBetween(this int value, double minimum, double maximum)
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
