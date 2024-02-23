using ProcessingOfTwoNumber;
using XUnitTestingDemo;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Task_Add_TwoNumber()
        {
            var num1 = 100;
            var num2 = 20;
            var expectedValue = 120;

            

            // Act
            var sum = Numbers.Add(num1,num2);

            //Assert
            Assert.AreEqual(expectedValue, sum);

        }
        [TestMethod]
        public void Task_Subtract_TwoNumber()
        {
            var num1 = 100;
            var num2 = 20;
            var expectedValue = 80;

           

            var subtract = Numbers.Subtract(num1, num2);
            Assert.AreEqual(expectedValue, subtract);


        }
        [TestMethod]
        public void Task_Multiply_TwoNumber()
        {
            var num1 = 100;
            var num2 = 20;
            var expectedValue = 2000;

           
            var Multiply = Numbers.Multiply(num1, num2);
            Assert.AreEqual(expectedValue, Multiply);


        }
        [TestMethod]
        public void Task_Divide_TwoNumber()
        {
            var num1 = 100;
            var num2 = 20;
            var expectedValue = 5;

           
            var Divide = Numbers.Divide(num1, num2);
            Assert.AreEqual(expectedValue, Divide);


        }
    }
}