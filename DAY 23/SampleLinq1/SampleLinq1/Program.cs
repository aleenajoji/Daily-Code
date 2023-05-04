using SampleLinq1;
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace SampleLinqQueries

{

    class Program

    {

        static void Main(string[] args)

        {

            

            //By calling a function GetStudentNames()

            List<Student> studentList = Student.GetStudentList();

            //Multiple Select and where Operator

            var Names = studentList.Where(s => s.Age > 18)

                     .Select(s => s)

                     .Where(st => st.StandardID > 0)

                     .Select(s => s.StudentName);

            foreach (var students in Names)

            {

                Console.WriteLine(students);

            }

            Console.WriteLine("*************************************************************");

            //LINQ Query returns Collection of Anonymous Objects

            var teenStudentsName = from s in studentList

                                   where s.Age > 12 && s.Age < 20

                                   select new { StudentName = s.StudentName };

            teenStudentsName.ToList().ForEach(s => Console.WriteLine(s.StudentName));

           

            //LINQ GroupBy Query

            var studentsGroupByStandard = from s in studentList

                                          group s by s.StandardID into sg

                                          orderby sg.Key

                                          select new { sg.Key, sg };

            foreach (var group in studentsGroupByStandard)

            {

                Console.WriteLine("StandardID {0}:", group.Key);

                group.sg.ToList().ForEach(st => Console.WriteLine(st.StudentName));

            }

            Console.WriteLine("*************************************************************");

            //LINQ GroupBy Query

            var studentsGroupByStandard1 = from s in studentList

                                           where s.StandardID > 0

                                           group s by s.StandardID into sg

                                           orderby sg.Key

                                           select new { sg.Key, sg };

            List<Standard> standardList = Standard.GetStandards();

            ;

            //LINQ Left Outer Join

            var studentsGroup = from stad in standardList

                                join s in studentList

                                on stad.StandardID equals s.StandardID

                                  into sg

                                select new

                                {

                                    StandardName = stad.StandardName,

                                    Students = sg

                                };

            foreach (var group in studentsGroup)

            {

                Console.WriteLine(group.StandardName);

                group.Students.ToList().ForEach(st => Console.WriteLine(st.StudentName));

            }

            
            //LINQ Left Outer Join

            var studentsWithStandard = from stad in standardList

                                       join s in studentList

                                       on stad.StandardID equals s.StandardID

                                       into sg

                                       from std_grp in sg

                                       orderby stad.StandardName, std_grp.StudentName

                                       select new

                                       {

                                           StudentName = std_grp.StudentName,

                                           StandardName = stad.StandardName

                                       };

            foreach (var group in studentsWithStandard)

            {

                Console.WriteLine("{0} is in {1}", group.StudentName, group.StandardName);

            }

           

            //Sorting

            var sortedStudents = from s in studentList

                                 orderby s.StandardID, s.Age

                                 select new

                                 {

                                     StudentName = s.StudentName,

                                     Age = s.Age,

                                     StandardID = s.StandardID

                                 };

            sortedStudents.ToList().ForEach(s => Console.WriteLine("Student Name: {0}, Age: {1}, StandardID: {2}", s.StudentName, s.Age, s.StandardID));

           

            //LINQ Inner join

            var studentWithStandard = from s in studentList

                                      join stad in standardList

                                      on s.StandardID equals stad.StandardID

                                      select new

                                      {

                                          StudentName = s.StudentName,

                                          StandardName = stad.StandardName

                                      };

            studentWithStandard.ToList().ForEach(s => Console.WriteLine("{0} is in {1}", s.StudentName, s.StandardName));

            Console.WriteLine("*************************************************************");

            //Nested Query

            var nestedQueries = from s in studentList

                                where s.Age > 18 && s.StandardID ==

                                  (from std in standardList

                                   where std.StandardName == "Standard 1"

                                   select std.StandardID).FirstOrDefault()

                                select s;

            nestedQueries.ToList().ForEach(s => Console.WriteLine(s.StudentName));

        }

    }

}

