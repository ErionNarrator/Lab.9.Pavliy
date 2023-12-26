public class Vector
{
    protected double x1, y1, x2, y2;

    public Vector(double x1, double y1, double x2, double y2)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }

    public (double, double) Point1
    {
        get { return (x1, y1); }
        set { (x1, y1) = value; }
    }

    public (double, double) Point2
    {
        get { return (x2, y2); }
        set { (x2, y2) = value; }
    }

    public double Length()
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    public virtual double CalculateTriangleArea(double x3, double y3)
    {
        double side1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        double side2 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
        double side3 = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

        double semiperimeter = (side1 + side2 + side3) / 2;
        double area = Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));

        return area;
    }
}

public class Vector3 : Vector
{
    private double x3, y3;

    public Vector3(double x1, double y1, double x2, double y2, double x3, double y3) : base(x1, y1, x2, y2)
    {
        this.x3 = x3;
        this.y3 = y3;
    }

    public (double, double) Point3
    {
        get { return (x3, y3); }
        set { (x3, y3) = value; }
    }

    public override double CalculateTriangleArea(double x3, double y3)
    {
        double side1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        double side2 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
        double side3 = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

        double semiperimeter = (side1 + side2 + side3) / 2;
        double area = Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));

        return area;
    }
}

public class Program
{
    public static void Main()
    {
        try
        {
            Console.Write("Введите x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Vector vector = new Vector(x1, y1, x2, y2);
            Console.WriteLine($"Длина вектора: {vector.Length()}");

            Console.Write("Введите x3: ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y3: ");
            double y3 = Convert.ToDouble(Console.ReadLine());

            Vector3 vector3 = new Vector3(x1, y1, x2, y2, x3, y3);
            double triangleArea = vector3.CalculateTriangleArea(x3, y3);
            Console.WriteLine($"Площадь треугольника: {triangleArea}");
        }
        catch (Exception err)
        {
            Console.WriteLine(err.Message);
        }
    }
}