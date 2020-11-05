using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("Felsefe", 2);
            Console.Write($"Qrup: {group.Name+"."+group.No} "); 
            Console.Write($"(Capacity: {group.Capacity})\n");
            
            Student Murad = new Student("Murad", "Agha");
            Student Jobs = new Student("Steve", "Jobs");
            Student Leo = new Student("Messi", "Leo");
            Student Deli = new Student("Delisov", "Anastasiya");
            
            group.AddStudent(Murad);
            group.AddStudent(Jobs);
            group.AddStudent(Leo);
            group.AddStudent(Deli);
            

        }
    }
}
