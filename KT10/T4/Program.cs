using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {

            new Shapes().AddShape();

        }
    }

    public abstract class Shape
    {
        public string Name { get; set; }
        public double A { get; set; }
        public double C { get; set; }

        public abstract void Area();
        public abstract void Circum();

    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public static double P = 3.14159;

        public override void Area()
        {
            A = P*(Radius*Radius);
            //Console.WriteLine("The area of circle is {0}cm^2", A);
        }

        public override void Circum()
        {
            C = 2*P*Radius;
            //Console.WriteLine("The Circumference of the circle is {0}cm", C);
        }

        public override string ToString()
        {
            return string.Format("Circle Radius={0} Area={1} Circumference={2}", Radius, A, C);
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override void Area()
        {
            A = Width*Height;
            //Console.WriteLine("The area of the rectangle is {0}cm^2",A);
        }

        public override void Circum()
        {
            C = 2 * Width * Height;
            //Console.WriteLine("The Circumference of the rectangle is {0}cm", C);
        }

        public override string ToString()
        {
            return string.Format("Rectangle Width={0} Height= {1} Area={2} Circumference={3}", Width, Height, A, C);
        }
    }

    class Shapes
    {
        public List<Shape> shapes = new List<Shape>();

        public void AddShape()
        {

            int sCounter = 0;

            while (true)
            {
                Console.Write("Create new circle or rectangle (1/2), print shapes and exit (3) > ");
                int input = int.Parse(Console.ReadLine());
                

                if (input == 1)
                {
                    Circle c = new Circle();

                    Console.Write("Radius > ");
                    c.Radius = double.Parse(Console.ReadLine());
                    c.Area();
                    c.Circum();
                    shapes.Add(c);
                    sCounter++;
                }

                if (input == 2)
                {
                    Rectangle r = new Rectangle();

                    Console.Write("Width > ");
                    r.Width = double.Parse(Console.ReadLine());
                    Console.Write("Height > ");
                    r.Height = double.Parse(Console.ReadLine());
                    r.Area();
                    r.Circum();
                    shapes.Add(r);
                    sCounter++;
                }
                if (input == 3)
                {
                    if (sCounter > 0)
                    {
                        foreach (Shape item in shapes)
                        {
                            Console.WriteLine(item.ToString());
                        }
                    }

                    if(sCounter == 0)
                    {
                        Console.WriteLine("Nothing to print");
                    }

                    break;
                }



            }
        }

    }
}
