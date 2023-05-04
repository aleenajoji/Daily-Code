using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SampleLinq1
{
    internal class Student
    {
        private int _studentID;

        public int StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }
        private string _studentName;

        public string StudentName
        {
            get { return _studentName; }
            set { _studentName = value; }
        }
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        private int _standardID  ;

        public int StandardID
        {
            get { return _standardID; }
            set { _standardID = value; }
        }



        public Student() { }
        public Student(int studentID, string studentName,int age,int standardID)
        {
            _studentID = studentID;
            _studentName = studentName;
            _age = age;
            _standardID = standardID;   

        }


        public static List<Student> GetStudentList()
        {
            IList<Student> studentList = new List<Student>() {

    new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
    new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
    new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }

    };


            
            return (List<Student>)studentList;
        }
     
    }
}
