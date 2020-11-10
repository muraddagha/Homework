using System;

namespace _11102020
{
    static class ExMethods
    {
       
        public static void Compare(this DateTime date,DateTime date1)
        {
           
            if (date>=date1)
            {
                Console.WriteLine("True");
            }
           
            else
            {
                Console.WriteLine("False");
            }
            
        }
    }
    
    class Program
    {
       
        static void Main(string[] args)
        {
            //DateTime date = new DateTime(2020,8,9);

            //date.Compare(new DateTime(2020,10,31));
            Account account = new Account("Murad");

        }
    }
}
