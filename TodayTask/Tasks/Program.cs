using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Book books = new Book();
            int page = books.GetBookPage(16);
            Console.WriteLine(page);
            
        }

        //public static void FindNumber(int[] arr,int num)
        //{

        //    for (int i = 0; i < ints.Length; i++)
        //    {

        //    }
        //}

        
    }
}
