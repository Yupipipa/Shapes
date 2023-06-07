using Shapes;

namespace ShapesProject
{
    public class Triangle : IShape
    {
        double a, b, c;

        public Triangle(double a = 0, double b = 0, double c = 0)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double AreaCalculate()
        {
            double p = (a + b + c) / 2;
            double area = Math.Pow(p * (p - a) * (p - b) * (p - c), 0.5);

            return area;
        }

        public bool IsRightAngle()
        {
            double[] numbers = { a, b, c };
            Array.Sort(numbers);

            if (Math.Pow(numbers[2], 2) == Math.Pow(numbers[0], 2) + Math.Pow(numbers[1], 2))
                return true;
            else
                return false;
        }

        /*string GetTriangleType(double a, double b, double c)
        {
            StringBuilder triangleType = new StringBuilder(); ;

            double[] numbers = { a, b, c };
            Array.Sort(numbers);

            if (Math.Pow(numbers[2], 2) == Math.Pow(numbers[0], 2) + Math.Pow(numbers[1], 2))
                triangleType = triangleType.Append("Right");
            else if (Math.Pow(numbers[2], 2) < Math.Pow(numbers[0], 2) + Math.Pow(numbers[1], 2))
                triangleType = triangleType.Append("Acute");
            else
                triangleType = triangleType.Append("Obtuse");
            return triangleType.ToString();
        }*/
    }
}
