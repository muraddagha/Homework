using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Person[] Person = new Person[5];
            //    Person person1 = new Person
            //    {
            //        Name = "Murad",
            //        Surname = ""

            //    };
            //    Person person2 = new Person
            //    {
            //        Name = "Jobs",
            //        Surname = ""

            //    };
            //    Person person3 = new Person
            //    {
            //        Name = "Deli",
            //        Surname = ""

            //    };
            //    Person person4 = new Person
            //    {
            //        Name = "Salam",
            //        Surname = ""

            //    };
            //    Person person5 = new Person
            //    {
            //        Name = "Alala",
            //        Surname = ""

            //    };

            //    Person[0] = person1;
            //    Person[1] = person2;
            //    Person[2] = person3;
            //    Person[3] = person4;
            //    Person[4] = person5;

            //    Console.WriteLine("Orginal: ");
            //    for (int i = 0; i < Person.Length; i++)
            //    {
            //        Console.WriteLine(Person[i].Name);
            //    }

            //    Console.WriteLine("***********");
            //    Person[] Pperson = PersonArrCopyReverse(Person);

            //    Console.WriteLine("Reversed: ");

            //    for (int i = 0; i < Person.Length; i++)
            //    {
            //        Console.WriteLine(Pperson[i].Name);
            //    }

        //public static Person[] PersonArrCopyReverse(Person[] person)
        //{
        //    Person[] reversedPeople = new Person[person.Length];

        //    for (int i = 0; i < person.Length; i++)
        //    {
        //        reversedPeople[person.Length - (i+1)] = person[i];

        //    }
        //    return reversedPeople;
        //}
             Console.WriteLine("Size daxil edin");
            int size = Convert.ToInt32(Console.ReadLine());

            string[] names = new string[size];

            string wantToContinueAnswer;
            bool wantTocontinue = true;

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Ad Daxil edin");
                names[i] = Console.ReadLine();
            }


            do
            {
                Console.WriteLine("Davam etmek isteyirsiniz mi? y/n");
                wantToContinueAnswer = Console.ReadLine();
            } while (wantToContinueAnswer != "y" && wantToContinueAnswer != "n");


            wantTocontinue = wantToContinueAnswer == "y" ? true : false;


            while (wantTocontinue)
            {
                Console.WriteLine("Ad Daxil edin");
                Array.Resize(ref names, names.Length + 1);

                names[names.Length - 1] = Console.ReadLine();
                Console.WriteLine("Davam etmek isteyirsiniz mi? y/n");

                wantToContinueAnswer = Console.ReadLine();
                if (wantToContinueAnswer == "y" && wantToContinueAnswer != "n")
                {
                    wantTocontinue = true;
                }
                else
                {
                    wantTocontinue = false;
                }

            }
            Console.WriteLine("Daxil Edilmis butun adlar: ");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
