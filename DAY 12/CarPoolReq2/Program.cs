using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolReq2
{


    internal class Program

    {

        static void Main(string[] args)

        {

            ArrayList memberList = new ArrayList();

            ArrayList carList = new ArrayList();

            int choice = 0;

            while (true)

            {

                Console.WriteLine("\nMenu: ");

                Console.WriteLine("\n1) Add a Member");

                Console.WriteLine("\n2) Add a Car");

                Console.WriteLine("\n3) Assign Car to Member (Assume valid data is supplied)");

                Console.WriteLine("\n4) Cars Owned");

                Console.WriteLine("\n5) Exit");

                Console.WriteLine("\nEnter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)

                {

                    case 1:

                        Console.WriteLine("Id: ");

                        long id = long.Parse(Console.ReadLine());

                        Console.WriteLine("First Name: ");

                        string firstName = Console.ReadLine();

                        Console.WriteLine("Last Name: ");

                        string lastName = Console.ReadLine();

                        Console.WriteLine("Email: ");

                        string email = Console.ReadLine();

                        Console.WriteLine("Contact Number: ");

                        string contactNumber = Console.ReadLine();

                        Console.WriteLine("License Number: ");

                        string licenseNumber = Console.ReadLine();

                        Console.WriteLine("License Start Date (dd-MM-yyyy): ");

                        DateTime licenseStartDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);

                        Console.WriteLine("License Expiry Date (dd-MM-yyyy): ");

                        DateTime licenseExpiryDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);

                        Member member = new Member(id, firstName, lastName, email, contactNumber, licenseNumber, licenseStartDate, licenseExpiryDate);

                        memberList.Add(member);

                        Console.WriteLine("Member added successfully");

                        break;

                    case 2:

                        Console.WriteLine("Id: ");

                        long carId = long.Parse(Console.ReadLine());

                        Console.WriteLine("Name: ");

                        string Name = Console.ReadLine();

                        Console.WriteLine("Model: ");

                        string Model = Console.ReadLine();

                        Console.WriteLine("MakeYear: ");

                        int MakeYear = int.Parse(Console.ReadLine());

                        Console.WriteLine("Company: ");

                        string Company = Console.ReadLine();

                        Console.WriteLine("Comfort level: ");

                        int ComfortLevel = int.Parse(Console.ReadLine());

                        Car car = new Car(carId, Name, Model, MakeYear, Company, ComfortLevel);

                        carList.Add(car);

                        Console.WriteLine("Car added successfully");

                        break;

                    case 3:

                        Console.WriteLine("Member Id: ");

                        long memberId = long.Parse(Console.ReadLine());

                        Console.WriteLine("Car Id: ");

                        long carIdForAssignment = long.Parse(Console.ReadLine());

                        Console.WriteLine("Car Registration Number: ");

                        string carRegistrationNumber = Console.ReadLine();

                        Console.WriteLine("Car Color: ");

                        string carColor = Console.ReadLine();

                        Member memberForAssignment = Member.FindMember(memberList, memberId);

                        Car carForAssignment = Car.FindCar(carList, carIdForAssignment);

                        if (memberForAssignment != null && carForAssignment != null)

                        {

                            MemberCar memberCar = new MemberCar(memberForAssignment, carForAssignment, carRegistrationNumber, carColor);

                            memberForAssignment.CarList.Add(memberCar);

                            Console.WriteLine("Car assigned to member susseccfully");

                        }

                        else

                        {

                            Console.WriteLine("Invalid member id or car id");

                        }

                        break;

                    case 4:

                        Console.WriteLine("Member id: ");

                        long memberIdForCarOwned = long.Parse(Console.ReadLine());

                        Member memberForCarOwned = Member.FindMember(memberList, memberIdForCarOwned);

                        if (memberForCarOwned != null)

                        {

                            Console.WriteLine("Number of cars owned: " + memberForCarOwned.FirstName + " " + memberForCarOwned.LastName + ": " + memberForCarOwned.CarList.Count);

                        }

                        break;

                    case 5:

                        break;

                }

            }

        }

    }
}

    









