using CalculatorApp;

namespace TestCalculatorApp
{
    public class Tests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Test_addition()
        {
            int a = 123;
            int b = 325;

            int result = calculator.add(a, b);

            Assert.AreEqual(a + b, result);
        }

        [Test]
        public void Test_addition_not_equal()
        {
            int a = 2142;
            int b = 22;

            int result = calculator.add(a, b);

            Assert.AreNotEqual(a + b + 1, result);
        }

        [Test]
        public void Test_subtraction()
        {
            int a = 9;
            int b = 10;

            int result = calculator.sub(a, b);

            Assert.AreEqual(a - b, result);
        }

        [Test]
        public void Test_subtraction_not_equal()
        {
            int a = 42;
            int b = 10;

            int result = calculator.sub(a, b);

            Assert.AreNotEqual(a - b + 1, result);
        }

        [Test]
        public void Test_multiplication()
        {
            int a = 91;
            int b = 510;

            int result = calculator.mul(a, b);

            Assert.AreEqual(a * b, result);
        }

        [Test]
        public void Test_multiplication_not_equal()
        {
            int a = 412;
            int b = 13;

            int result = calculator.mul(a, b);

            Assert.AreNotEqual(a * b + 1, result);
        }

        [Test]
        public void Test_division()
        {
            int a = 10;
            int b = 2;

            int result = calculator.div(a, b);

            Assert.AreEqual(a / b, result);
        }

        [Test]
        public void Test_division_not_equal()
        {
            int a = 220;
            int b = 5;

            int result = calculator.div(a, b);

            Assert.AreNotEqual(a / b + 1, result);
        }
    }
}