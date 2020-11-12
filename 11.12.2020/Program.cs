using System;
using System.Collections.Generic;
using System.Linq;

namespace Contains
{
    class Program
    {
        //public static bool Contains(List<int> list1,List<int> list2)
        //{
        //    foreach (var item1 in list1)
        //    {
        //        if (!list2.Contains(item1))
        //        {
        //            return false;
        //        }
        //    }
        //    return true; ;
        //}
        //public static bool IsListEqual(List<int> list1, List<int> list2)
        //{
        //        if (list1.SequenceEqual(list2))
        //        {
        //            return true;
        //        } 
                
        //    return false;
            
        //}

        static void Main(string[] args)
        {
            Student Student1 = new Student(1, "Murad");
            Console.WriteLine(Student1.Name);

            //List<int> MyList1 = new List<int>();
            //List<int> MyList2 = new List<int>();
            //MyList1.Add(15);
            //MyList1.Add(17);
            //MyList1.Add(1);
            //MyList2.Add(15);
            //MyList2.Add(17);
            //MyList2.Add(1);

            //Console.WriteLine(Program.IsListEqual(MyList1, MyList2));
        }
    }
}
