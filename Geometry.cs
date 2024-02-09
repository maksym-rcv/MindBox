
namespace GeometryLib
{
    public interface IShape
    {
        double CalculateArea();
    }

    public class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            // Рассчитываем площадь круга
            return Math.PI * Radius * Radius;
        }
    }

    public class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double CalculateArea()
        {
            // Рассчитываем площадь треугольника
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public bool IsRightTriangle()
        {
            // Проверяем, является ли треугольник прямоугольным
            return (SideA * SideA + SideB * SideB == SideC * SideC) ||
                   (SideA * SideA + SideC * SideC == SideB * SideB) ||
                   (SideB * SideB + SideC * SideC == SideA * SideA);
        }
    }
}
