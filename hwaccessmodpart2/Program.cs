using System;
using hwaccessmodpart2.Models;

namespace hwaccessmodpart2
{
    class Program
    {
        static void Main(string[] args)
        {
//            Person class

              //- Name
//              - Surname
//              - Age

//Name və Age təyin olunmamış bir Person obyekti yaratmaq olmaz.

//Name və Surname dəyərləri mütləq böyük hərf ilə başlamalıdı.
//Name dəyəri minumum 3 maximum 30 hərfdən ibarət ola bilər.
//Surname dəyəri minumum 3 maximum 35 hərfdən ibarət ola bilər.

//----

//Student class (Person-dan miras alır)

//- Point

//Point təyin olunmamış bir Student obyekti yaratmaq olmaz.

//Point dəyəri minimum 0 maximum 100 ola bilər.
            do
            {
                Person user = new Person();
                Console.Clear();
                Console.Write("Please enter your name: ");
                user.name = Console.ReadLine();
                Console.Write("Please enter your surname: ");
                user.surname = Console.ReadLine();
                Console.Write("Please write your age: ");
                user.age = int.Parse(Console.ReadLine());
                Student user1 = new Student();
                Console.Write("Please write your point: ");
                user1.point = int.Parse(Console.ReadLine());


                Console.WriteLine("for next press any key::");
                Console.WriteLine("for exit press esc::");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
