using System;
using System.Linq;
namespace LINQvsLoop
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentArray = {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
            new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
            new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
        };

            Student[] students = new Student[10];

            var descent = from stu in studentArray
                                          where stu.Age >12 && stu.Age<20
                                          orderby stu.StudentName descending
                                          select stu;
            int i = 0;

            foreach (var s in descent)
            {
                Console.WriteLine(s.StudentID + " " + s.StudentName + " " + s.Age);
            }
            Console.ReadKey();

        }
    }
}
