using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    class Student
    {
        private static int _totalNo;
        private int _no;
        public int No { get => _no; }
        public string FullName;
        public Student(string fullName)
        {
            _totalNo++;
            _no = _totalNo;
            this.FullName = fullName;
        }

    }
}
