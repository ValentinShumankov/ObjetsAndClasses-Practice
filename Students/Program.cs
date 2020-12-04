using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            List<Student> studentsList = new List<Student>();
            for (int i = 0; i < studentsCount; i++)
            {
                var studentInfo = Console.ReadLine().Split().ToArray();
                Student student = new Student(studentInfo[0], studentInfo[1], double.Parse(studentInfo[2]));
                studentsList.Add(student);
            }

            Console.WriteLine(string.Join(Environment.NewLine,studentsList.OrderByDescending(x => x.Grade)));

        }

        public class Student
        {

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }

            public Student(string firstName, string lastName, double grade)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Grade = grade;
            }


            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade:f2}";
            }

        }



    }
}
