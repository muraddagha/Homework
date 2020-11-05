using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Task
{
    class Group
    {
        private Student[] Students;

        static int _totalNo = 100;
        private int _no;
        public string Name;
        private int _capacity;

        public int Capacity { get => _capacity; }
        public int No { get => _no; }

        public Group(string name, int capacity)
        {
            _totalNo++;
            _no = _totalNo;
            Students = new Student[0];
            this.Name = name;
            this._capacity = capacity;

        }
        string wantToContinueAnswer;
        bool wantToContinue=true;
        

        public void AddStudent(Student student)
        {
            while (wantToContinue)
            {
                if (student.No > Capacity)
                {
                    do
                    {
                        Console.WriteLine("Daxil ola bilmezsiniz qrupun capacitysi yeterli deyil\nCapacity artirilsin mi? y/n");
                        wantToContinueAnswer = Console.ReadLine();
                    } while (wantToContinueAnswer != "y" && wantToContinueAnswer != "n");
                    wantToContinue = wantToContinueAnswer == "y" ? true : false;
                    _capacity++;
                }
                else
                {
                    Array.Resize(ref Students, Students.Length + 1);
                    Students[Students.Length - 1] = student;
                    Console.WriteLine($"{student.No+"." +student.Name + " " + student.Surname} adli student daxil oldu");
                    break;
                }
            }
        }
    }
}
