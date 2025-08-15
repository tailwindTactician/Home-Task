class Program
{
    static void Main()
    {
        Console.Write("inter a radius: ");
        double r = Convert.ToDouble(Console.ReadLine());

        Circle myCircle = new Circle(r);

        Console.WriteLine("Площадь: " + myCircle.GetArea());
        Console.WriteLine("Диаметр: " + myCircle.GetDiameter());
        Console.WriteLine("Длина окружности: " + myCircle.GetCircumference());
    }
}
