using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    public class Student
    {
        static int _totalNo;
        private int _no;
        public int No { get => _no; }
        public string Name;
        public string Surname;
        public Student(string name,String surname)
        {
            _totalNo++;
            _no = _totalNo;

            this.Name = name;
            this.Surname = surname;
            
        }
    }
}
