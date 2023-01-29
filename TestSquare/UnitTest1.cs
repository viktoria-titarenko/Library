using squareLibrary;

namespace TestSquare
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod("������� ����������� �� ��������� 3,4,5")]
        public void TestMethod1()
        {
            Triangle triangle = new (3, 4, 5);
            double result = SquareCalculator.Square(triangle);

            Assert.AreEqual(6, result);
        }

        [TestMethod("������� ����� ������� 10")]
        public void TestMethod2()
        {
            Circle circle = new Circle(10);
            double result = SquareCalculator.Square(circle);

            Assert.AreEqual(314, result, 1);
  
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
    "������������� ������")]
        public void TestMethod3()
        {
            Circle circle = new Circle(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),"������������� ����� ����� �� ������")]
        public void TestMethod4()
        {
            Triangle traing = new(-5, 6, 7);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "������������ �� ����������")]
        public void TestMethod5()
        {
            Triangle traing = new(1, 2, 3);
        }

        [TestMethod("�������� �� ����������� �������������")]
        public void TestMethod6()
        {
            Triangle triangle = new(3.5, 2.1, 2.8);
            var result = PythagoreanTheorem.IsTheorem(triangle);


            Assert.AreEqual(true, result);

        }
    }
}