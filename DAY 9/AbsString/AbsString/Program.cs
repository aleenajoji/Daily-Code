using System;


namespace AbsString
{
    

    public abstract class Shape

    {

        private string name;

        public Shape(string s)

        {

            Id = s;

        }

        public string Id

        {

            get

            {

                return name;

            }

            set

            {

                name = value;

            }

        }

        public abstract double Area

        {

            get;

        }

        public override string ToString()

        {

            return Id + " Area = " + string.Format("{0:F2}", Area);

        }

    }

    public class Square : Shape

    {

        private int side;

        public Square(int side, string id)

          : base(id)

        {

            this.side = side;

        }

        public override double Area

        {

            get

            {

                return side * side;

            }

        }

    }

    public class Circle : Shape

    {

        private int radius;

        public Circle(int radius, string id) : base(id)

        {

            this.radius = radius;

        }

        public override double Area

        {

            get

            {

                return radius * radius * System.Math.PI;

            }

        }

    }

    public class Rectangle : Shape

    {

        private int width;

        private int height;

        public Rectangle(int width, int height, string id) : base(id)

        {

            this.width = width;

            this.height = height;

        }

        public override double Area

        {

            get

            {

                return width * height;

            }

        }

    }

    class TestClass

    {

        static void Main()

        {

            Shape[] shapes =

            {

      new Square(5, "Square #1"),

      new Circle(3, "Circle #1"),

      new Rectangle( 4, 5, "Rectangle #1")

    };

            Console.WriteLine("Shapes Collection");

            foreach (Shape s in shapes)

            {

                Console.WriteLine(s);

            }

        }

    }










}
