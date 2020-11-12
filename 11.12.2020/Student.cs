using System;
using System.Collections.Generic;
using System.Text;

namespace Contains
{
    class Student
    {
        public int GroupNo;
        public readonly string Name;
       
        public bool IsNameValid(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (!char.IsLetter(name[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public Student(int groupNo, string name)
        {
            this.GroupNo = groupNo;
            if (IsNameValid(name))
            {
                this.Name = name;
            }
            
        }
    }
}
