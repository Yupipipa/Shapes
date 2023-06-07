using Shapes;

namespace ShapesProject
{
    public class Circle : IShape
    {
        double radius;

        public Circle(double radius = 0)
        {
            this.radius = radius;
        }

        public double AreaCalculate()
        {
            double area = Math.Round(Math.PI, 2) * Math.Pow(radius, 2);

            return area;
        }
    }
}
