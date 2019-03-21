using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {


 

            List<Student> studentList = new List<Student>() {
                new Student(){ UserName="Marko", Password="123", Grades = 4, Subject = "History" },
                new Student(){ UserName="Jovana", Password="1234", Grades = 5, Subject = "Math"},
                new Student(){ UserName="Stoyan", Password="12345", Grades = 3, Subject = "English"},

            };

            List<User> users = new List<User>()
          {

              new User()
              {

                  UserName = "Boyana", Password = "dva", Role = Role.Admin
              },

              new User(){UserName = "Trpko", Password = "eden", Role = Role.Trainer}
          };


            Console.WriteLine("If you want to enter as an Admin press 1, If you want to enter as a Trainer press 2, If you want to enter as a Student press 3");

            int selection = int.Parse(Console.ReadLine());


            switch (selection)
            {

                case 1:
                    Console.WriteLine("You've logged as an Admin");
                    break;

                case 2:
                    Console.WriteLine("You've logged as a Trainer");
                    break;

                case 3:

                    Console.WriteLine("You've logged as a Student");
                    break;
            }

            Console.ReadLine();

            Console.WriteLine("Enter your username here:");
            var user = Console.ReadLine();

            Console.WriteLine("Enter your password here:");
            var pw = Console.ReadLine();




            bool imaLi = false;
            foreach (var student in studentList)
            {
                if (student.UserName == user && student.Password == pw)
                {

                    Console.WriteLine($"Welcome {user}");
                    imaLi = true;
                    Console.ReadLine();
                    
                }
            }
            if (!imaLi)
            {
                Console.WriteLine($"Error, username  or password is not recognized ");
                Console.ReadLine();
            }
           
           



        }
    }
}

