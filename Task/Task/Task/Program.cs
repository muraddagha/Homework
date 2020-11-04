using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Murad", "Agha");
            Student student2 = new Student("Ilkin", "Aghayev");
            Student student3 = new Student("Sultan", "Sultanli");

            Group group = new Group();
            group.AddStudent(student1);
        }
    }
}
