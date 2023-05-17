using System;
using System.Data;
using System.IO;
using System.Security.AccessControl;

namespace Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure figure_1 = new Square(8);
            figure_1.Show();

            Figure figure_2 = new Square(10);
            figure_2.Show();

            Figure figure_3 = new Rectangle(8, 4);
            figure_3.Show();

            Figure figure_4 = new Sphere(8);
            figure_4.Show();

            Figure figure_5 = new Cube(5.5);
            figure_5.Show();

            Figure figure_6 = new Cylinder(3, 5);
            figure_6.Show();

            Console.ReadKey(true);
        }

        abstract class Figure
        {
            public abstract string Area();
            public abstract string Name();

            public abstract void Show();
        }

        abstract class FlatFigure: Figure
        {
            public abstract string Perimeter();

            public override void Show()
            {
                Console.WriteLine(
                    $"Figure name: {Name()}\n" +
                    $"Area value: {Area()}\n" +
                    $"Perimeter value: {Perimeter()}"
                    );
                Console.WriteLine();
            }
        }

        abstract class VolumeFigure: Figure
        {
            public abstract string Volume();

            public override void Show()
            {
                Console.WriteLine(
                    $"Figure name: {Name()}\n" +
                    $"Surface area value: {Area()}\n" +
                    $"Volume value: {Volume()}"
                    );
                Console.WriteLine();
            }
        }

        class Square : FlatFigure
        {
            double a; 
            public Square (double squareSide) // memory
            {
                Side = squareSide;
            }
            public double Side
            {
                get { return a; }
                set { a = value < 0 ? 0 : value; }
            }
            public override string Area()
            {
                return Math.Pow(a, 2).ToString();
            }
            public override string Perimeter()
            {
                return (4*a).ToString();
            }
            public override string Name()
            {
                return "Square";
            }
        }

        class Rectangle : FlatFigure
        {
            double width;
            double height;
            public Rectangle (double rectangleWidth, double rectangleHeight)
            {
                Width = rectangleWidth;
                Height = rectangleHeight;
            }
            public double Width
            {
                get { return width; }
                set { width = value < 0 ? 0 : value; }
            }

            public double Height
            {
                get { return height; }
                set { height = value < 0 ? 0 : value; }
            }
            public override string Area()
            {
                return (width*height).ToString();
            }
            public override string Perimeter()
            {
                return (2*width + 2*height).ToString();
            }
            public override string Name()
            {
                return "Rectangle";
            }
        }

        class Sphere : VolumeFigure
        {
            double radius;
            public Sphere(double sphereRadius)
            {
                Radius = sphereRadius;
            }
            public double Radius
            {
                get { return radius; }
                set { radius = value < 0 ? 0 : value; }
            }

            public override string Area()
            {
                return (Math.Round(4*Math.PI*Math.Pow(radius, 2), 3)).ToString();
            }
            public override string Name()
            {
                return "Sphere";
            }
            public override string Volume()
            {
                return (Math.Round((4*Math.PI*Math.Pow(radius,3))/3, 3)).ToString();
            }
        }

        class Cube : VolumeFigure
        {
            double a;
            public Cube(double cubeSide)
            {
                Side = cubeSide;
            }
            public double Side
            {
                get { return a; }
                set { a = value < 0 ? 0 : value; }
            }

            public override string Area()
            {
                return (Math.Round(6*Math.Pow(a,2), 3)).ToString();
            }
            public override string Name()
            {
                return "Cube";
            }
            public override string Volume()
            {
                return (Math.Round(Math.Pow(a,3), 3)).ToString();
            }
        }

        class Cylinder : VolumeFigure
        {
            double radius;
            double height;
            public Cylinder(double cylinderRadius, double cylinderHeight)
            {
                Radius = cylinderRadius;
                Height = cylinderHeight;
            }
            public double Radius
            {
                get { return radius; }
                set { radius = value < 0 ? 0 : value; }
            }
            public double Height
            {
                get { return height; }
                set { height = value < 0 ? 0 : value; }
            }

            public override string Area()
            {
                return (Math.Round(2*Math.PI*radius*height + 2*Math.PI*Math.Pow(radius,2), 3)).ToString();
            }
            public override string Name()
            {
                return "Cylinder";
            }
            public override string Volume()
            {
                return (Math.Round(Math.PI*Math.Pow(radius,2)*height, 3)).ToString();
            }
        }
    }

}