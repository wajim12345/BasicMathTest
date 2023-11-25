using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMath
{
	public class BasicMath
	{
		public double Num1 {  get; set; }
		public double Num2 { get; set; }

		public BasicMath() 
		{

		}
		
		public double Add(double num1, double num2)
		{
			double num3 = num1 + num2;
			return num3;
		}

		public double Substract(double num1, double num2)
		{
			double num3 = num1 - num2;
			return num3;
		}

		public double Divide(double num1, double num2) 
		{
			double num3 = num1 / num2;
			return num3;
		}

		public double Multiply(double num1, double num2) 
		{
			double num3 = num1 * num2;
			return num3;
		}
	}
}
