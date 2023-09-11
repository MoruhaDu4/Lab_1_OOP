namespace LB_1
{
    internal class Program
    {
        class Circle
        {
            private double r;

            public Circle(double radius)
            {
                r = radius;
            }

            public bool Correct()
            {
                return r > 0;
            }

            public double Area()
            {
                if (Correct())
                {
                    return Math.PI * Math.Pow(r, 2);
                }
                else
                {
                    return -1;
                }
            }

            public double Length()
            {
                if (Correct())
                {
                    return 2 * Math.PI * r;
                }
                else
                {
                    return -1;
                }
            }

            public void Print()
            {
                Console.WriteLine($"Радiус кола: {r}");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введiть радiус кола: ");
                double radius;
                if (double.TryParse(Console.ReadLine(), out radius))
                {
                    Circle circle = new Circle(radius);
                    circle.Print();

                    if (circle.Correct())
                    {
                        Console.WriteLine($"Площа кола: {circle.Area()}");
                        Console.WriteLine($"Довжина кола: {circle.Length()}");
                    }
                    else
                    {
                        Console.WriteLine("Помилка: Неправильне значення радiусу.");
                    }
                }
                else
                {
                    Console.WriteLine("Помилка: Неправильний формат введеного радiусу.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }
}