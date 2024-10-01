//завдання 5, приклад 1
using System;

class ThreeD
{
    int x, y, z; // Тривимірні координати

    // Конструктор без параметрів
    public ThreeD() { x = y = z = 0; }

    // Конструктор з параметрами
    public ThreeD(int i, int j, int k) { x = i; y = j; z = k; }

    // Перевантаження бінарного оператора +
    public static ThreeD operator +(ThreeD op1, ThreeD op2)
    {
        ThreeD result = new ThreeD
        {
            x = op1.x + op2.x,
            y = op1.y + op2.y,
            z = op1.z + op2.z
        };
        return result;
    }

    // Перевантаження бінарного оператора -
    public static ThreeD operator -(ThreeD op1, ThreeD op2)
    {
        ThreeD result = new ThreeD
        {
            x = op1.x - op2.x,
            y = op1.y - op2.y,
            z = op1.z - op2.z
        };
        return result;
    }

    // Виведення координат на консоль
    public void Show() => Console.WriteLine($"{x}, {y}, {z}");
}

class ThreeDDemo
{
    static void Main()
    {
        ThreeD a = new ThreeD(1, 2, 3);
        ThreeD b = new ThreeD(10, 10, 10);
        ThreeD c;

        // Виведення координат точок a і b
        Console.Write("Координати точки a: ");
        a.Show();
        Console.Write("Координати точки b: ");
        b.Show();

        // Операції додавання і віднімання
        c = a + b;
        Console.Write("Результат складання a + b: ");
        c.Show();

        c = a + b + c;
        Console.Write("Результат складання a + b + c: ");
        c.Show();

        c = c - a;
        Console.Write("Результат віднімання c - a: ");
        c.Show();

        c = c - b;
        Console.Write("Результат віднімання c - b: ");
        c.Show();

        Console.ReadKey();
    }
}

//приклад 2 
using System;

namespace Lab8_3D
{
    class ThreeD
    {
        int x, y, z;

        // Конструктор без параметрів
        public ThreeD() { x = y = z = 0; }

        // Конструктор з параметрами
        public ThreeD(int i, int j, int k) { x = i; y = j; z = k; }

        // Перевантаження бінарного оператора +
        public static ThreeD operator +(ThreeD op1, ThreeD op2)
        {
            return new ThreeD(op1.x + op2.x, op1.y + op2.y, op1.z + op2.z);
        }

        // Перевантаження бінарного оператора -
        public static ThreeD operator -(ThreeD op1, ThreeD op2)
        {
            return new ThreeD(op1.x - op2.x, op1.y - op2.y, op1.z - op2.z);
        }

        // Перевантаження унарного оператора -
        public static ThreeD operator -(ThreeD op)
        {
            return new ThreeD(-op.x, -op.y, -op.z);
        }

        // Перевантаження унарного оператора +
        public static ThreeD operator +(ThreeD op)
        {
            return new ThreeD(op.x + 1, op.y + 1, op.z + 1);
        }

        // Виведення координат на консоль
        public void Show() => Console.WriteLine($"{x}, {y}, {z}");
    }

    class Program
    {
        static void Main(string[] args)
        {
            ThreeD a = new ThreeD(1, 2, 3);
            ThreeD b = new ThreeD(10, 10, 10);
            ThreeD c;

            // Виведення координат
            Console.Write("Координати точки a: ");
            a.Show();
            Console.Write("Координати точки b: ");
            b.Show();

            // Операції додавання і віднімання
            c = a + b;
            Console.Write("Результат складання a + b: ");
            c.Show();

            c = a + b + c;
            Console.Write("Результат складання a + b + c: ");
            c.Show();

            c = c - a;
            Console.Write("Результат віднімання c - a: ");
            c.Show();

            c = c - b;
            Console.Write("Результат віднімання c - b: ");
            c.Show();

            // Використання унарних операторів
            c = -a;
            Console.Write("Результат унарного оператора - для a: ");
            c.Show();

            c = +a;
            Console.WriteLine("Результат унарного оператора + для a: ");
            c.Show();

            Console.ReadKey();
        }
    }
}
