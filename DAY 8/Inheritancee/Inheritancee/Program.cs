using System;

using System.Linq;

namespace InheritDemoFruits

{

    class Program

    {

        static void Main(string[] args)

        {

            Orange o1 = new Orange(101, "Nagpur Orange", "Maharasthra");

            o1.print();

            Orange o2 = new Orange(102, "Solan Keenu", "Himachal");

            o2.print();

        }

    }

    class fruit

    {

        private int _fno;

        public int FNO

        {

            get { return _fno; }

            set { _fno = value; }

        }

        private string _name;

        public string Name

        {

            get { return _name; }

            set

            {

                if (value != null)

                    _name = value;

                else

                    Console.WriteLine("Invalid Fruit Name");

            }

        }

        public fruit()

        {

        }

        public fruit(int fno, string name)

        {

            _fno = fno;

            _name = name;

        }

        public void print()

        {

            Console.WriteLine("Fruit No:" + FNO);

            Console.WriteLine("Fruit Name:" + Name);

        }

    }

    class Orange : fruit

    {

        static string[] origins = { "Maharasthra", "Himachal", "Telangana" };

        private string _origin;

        public string Origin

        {

            get { return _origin; }

            set

            {

                Array.Sort(origins);

                if (Array.BinarySearch(origins, value) >= 0)

                    //if (origins.Contains(value))

                    _origin = value;

                else

                    Console.WriteLine("Invalid Origin");

            }

        }

        public Orange()

        {



        }

        public Orange(int fno, string name, string origin) : base(fno, name)

        {

            Origin = origin;

        }

        public new void print()

        {

            base.print();

            Console.WriteLine("Origin of Fruit:" + Origin);

        }

    }

}





