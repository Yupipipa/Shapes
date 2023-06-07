using ShapesProject;

namespace TestShapes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCirlceArea()
        {
            Circle myCircle = new Circle(3);

            double expected = 28.26;
            double result = myCircle.AreaCalculate();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestTriangleArea()
        {
            Triangle myTriangle = new Triangle(3, 4, 5);

            double expected = 6;
            double result = myTriangle.AreaCalculate();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestTriangleType()
        {
            Triangle myTriangle = new Triangle(3, 4, 5);

            bool expected = true;
            bool result = myTriangle.IsRightAngle();

            Assert.AreEqual(expected, result);
        }
    }
}