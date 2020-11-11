using System;
using System.Collections.Generic;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Murad Agha");
            Student student2 = new Student("Sultan Sultanli");
            Student student3 = new Student("Steve Jobs");
            Student student4 = new Student("Steve Jobs");
            Student student5 = new Student("Steve Jobs");
            Student student6 = new Student("Steve Jobs");

            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);
            students.Add(student5);
            students.Add(student6);
            List<Student> findStu = students.FindAll(a => a.FullName == "Steve Jobs");

            foreach (var item in findStu)
            {
                Console.WriteLine(item.No+"."+item.FullName);
            }
        }
    }
}
