using BasicMath;

namespace BasicMathTest
{
	public class Tests
	{
		public double number1;
		public double number2;
		public double number3;

		[SetUp]
		public void Setup()
		{
			number1 = 25;
			number2 = 5;
		}
		[TearDown]
		public void TearDown()
		{
			number1 = 0;
			number2 = 0;
			number3 = 0;
		}
		[Test]
		public void Test_AddMethod()
		{
			number3 = number1 + number2;
			BasicMath.BasicMath basicMath = new BasicMath.BasicMath();
			double testNum = basicMath.Add(number1, number2);
			Assert.AreEqual(number3, testNum);

		}
		[Test]
		public void Test_SubstractMethod()
		{
			number3 = number1 - number2;
			BasicMath.BasicMath basicMath = new BasicMath.BasicMath();
			double testNum = basicMath.Substract(number1, number2);
			Assert.AreEqual(number3, testNum);

		}
		[Test]
		public void Test_DivideMethod()
		{
			number3 = number1 / number2;
			BasicMath.BasicMath basicMath = new BasicMath.BasicMath();
			double testNum = basicMath.Divide(number1, number2);
			Assert.AreEqual(number3, testNum);

		}
		[Test]
		public void Test_MultiplyMethod()
		{
			number3 = number1 * number2;
			BasicMath.BasicMath basicMath = new BasicMath.BasicMath();
			double testNum = basicMath.Multiply(number1, number2);
			Assert.AreEqual(number3, testNum);

		}
		[Test]
		public void Test1()
		{

		}
	}
}