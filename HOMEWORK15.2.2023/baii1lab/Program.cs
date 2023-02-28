using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace baii1lab
{
    internal class program
    {
        // Shape abstract base class
        public abstract class Shape
        {
            protected int x;
            protected int y;

            public Shape(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public void Move(int dx, int dy)
            {
                x += dx;
                y += dy;
            }

            public abstract void Show();
        }

        // Line class
        public class Line : Shape
        {
            private int x2;
            private int y2;

            public Line(int x1, int y1, int x2, int y2) : base(x1, y1)
            {
                this.x2 = x2;
                this.y2 = y2;
            }

            public override void Show()
            {
                Console.WriteLine($"Line: ({x}, {y}) - ({x2}, {y2})");
            }

            public override string ToString()
            {
                return $"Line: ({x}, {y}) - ({x2}, {y2})";
            }
        }

        // Circle class
        public class Circle : Shape
        {
            private int radius;

            public Circle(int x, int y, int radius) : base(x, y)
            {
                this.radius = radius;
            }

            public override void Show()
            {
                Console.WriteLine($"Circle: ({x}, {y}), radius: {radius}");
            }

            public override string ToString()
            {
                return $"Circle: ({x}, {y}), radius: {radius}";
            }
        }

        // Rectangle class
        public class Rectangle : Shape
        {
            private int x2;
            private int y2;
            private int x3;
            private int y3;

            public Rectangle(int x1, int y1, int x2, int y2, int x3, int y3) : base(x1, y1)
            {
                this.x2 = x2;
                this.y2 = y2;
                this.x3 = x3;
                this.y3 = y3;
            }

            public override void Show()
            {
                Console.WriteLine($"Rectangle: ({x}, {y}), ({x2}, {y2}), ({x3}, {y3})");
            }

            public override string ToString()
            {
                return $"Rectangle: ({x}, {y}), ({x2}, {y2}), ({x3}, {y3})";
            }
        }

        // PolyLine class
        public class PolyLine : Shape
        {
            private int[] xs;
            private int[] ys;
            private int n;

            public PolyLine(int[] xs, int[] ys, int n) : base(xs[0], ys[0])
            {
                this.xs = xs;
                this.ys = ys;
                this.n = n;
            }

            public override void Show()
            {
                Console.Write("Polyline: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"({xs[i]}, {ys[i]}) ");
                }
                Console.WriteLine();
            }

            public override string ToString()
            {
                string result = "Polyline: ";
                for (int i = 0; i < n; i++)
                {
                    result += $"({xs[i]}, {ys[i]}) ";
                }
                return result;
            }
        }

        static void Main(string[] args)
        {
            Line line = new Line(0, 0, 10, 10);
            Console.WriteLine(line);
            line.Move(5, 5);
            Console.WriteLine(line);

            Circle circle = new Circle(3, 3, 5);

            Console.ReadLine();
        }
    }
}
