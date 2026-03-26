namespace Tutorial.OOP_Concept
{
    public abstract class Figure
    {
        public double Width, Height, Length, Radius;
        public const float Pi = 3.142f;

        public abstract double GetArea();
    }

    public class Rectangle : Figure
    {
        public Rectangle(double length, double width)
        {
            this.Width = width;
            this.Length = length;
        }

        public override double GetArea()
        {
            return Length * Width;
        }
    }

    public class Square : Figure
    {
        public Square(double length)
        {
            this.Length = length;
        }
        public override double GetArea()
        {
            return Length * Length;

        }
    }

    public class Circle : Figure
    {
        public Circle(double radius)
        {
            this.Radius = radius;

        }
        public override double GetArea()
        {
            return 2 * Pi * Radius;
        }
    }

    public class  TestFigures
    {
        public static void Main (string[] args)
        {
            Rectangle r1 = new Rectangle(12, 8);
            Circle c1 = new Circle(7);
            Square s1 = new Square(3);

            Console.WriteLine($"Area of rectangle: {r1.GetArea()}cm^2");
            Console.WriteLine($"Area of circle: {c1.GetArea()}cm^2");
            Console.WriteLine($"Area of square: {s1.GetArea()}cm^2");
        }
    }
}
