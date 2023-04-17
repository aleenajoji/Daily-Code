using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ElectronicPhone
{

    /*Create a base class, Telephone, and derive a class ElectronicPhone from it.
    In Telephone, create a protected string member phonetype and a public method Ring( )
    which outputs a text message such as this: “Ringing the <phonetype>.”
    In ElectronicPhone, the constructor should set the phonetype to “Digital.”
    In the Run( ) method, call Ring( ) on the ElectronicPhone to test the inheritance.*/


    // Base class
    class Telephone
    {
        protected string phonetype; // protected string member

        // Constructor
        public Telephone()
        {
            phonetype = ""; // Initialize phonetype to empty string
        }

        // Public method
        public void Ring()
        {
            Console.WriteLine($"Ringing the {phonetype}."); // Output ringing message with phonetype
        }
    }

    // Derived class
    class ElectronicPhone : Telephone
    {
        // Constructor
        public ElectronicPhone()
        {
            phonetype = "Digital"; // Set phonetype to "Digital" in the constructor
        }

        // Public method
        public void Run()
        {
            Ring(); // Call Ring() method from the base class to test inheritance
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ElectronicPhone electronicPhone = new ElectronicPhone();
            electronicPhone.Run(); // Call Run() method to test the inheritance
        }
    }
}
