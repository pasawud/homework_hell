using System;
using System.Collections.Generic;
using System.Collections;

namespace activity_
{
    enum Mainmenu
    {
        Login = 1,
        Register =2,
        end = 3,
    }

    class Program
    {
        static void Main(string[] args)
        {
            main();
        }
        static void main()
        {
            Console.WriteLine("register event");
            Console.WriteLine("Login |1| ");
            Console.WriteLine("Register |2| ");
            Console.WriteLine("End this program |3| ");
            Console.Write("Select menu : ");
            Mainmenu manu = (Mainmenu)(int.Parse(Console.ReadLine()));
            Console.Clear();
            selectmenu(manu);
        }
        static void selectmenu(Mainmenu manu)
        {
            if (manu == Mainmenu.Login)
            {
                Login();
            }
            else if (manu == Mainmenu.Register)
            {
                Register();
            }
            else if (manu == Mainmenu.end)
            {
                Console.Clear();
            }
        }
        static void Register()
        {
            Console.WriteLine("register event");
            type();
        }
        static string type()
        {
            Console.WriteLine("Student |1| ");
            Console.WriteLine("Teacher |2| ");
            Console.Write("select : ");
            int types = int.Parse(Console.ReadLine());

            if (types == 1 )
            {
                name();
                password();
                Studentinfor();
                Console.Clear();
                main();
            }
            else if (types == 2 )
            {
                name();
                password(); 
                teacherinfor();
                Console.Clear();
                main();
            }
            else
            {
                Console.Clear();
                type();
            }
            return Console.ReadLine();
        }
        static PersonList PersonList;
        static void Loding()
        {
            Program.PersonList = new PersonList();
        }
        static Student creatnewstudent()
        {
            return new Student(name(), password(), type(), Studentinfor());
        }
        static Teacher creatnewTeacher()
        {
            return new Teacher(name(), password(), type(), teacherinfor());
        }
        static string Studentinfor()
        {
            Console.Write("Student ID : ");
            return Console.ReadLine();
        }
        static string teacherinfor()
        {
            Console.Write("Teacher ID : ");
            return Console.ReadLine();
        }
        //
        static string name()
        {
            Console.Write("Name : ");
            return Console.ReadLine();
        }
        static string password()
        {
            Console.Write("Password : ");
            return Console.ReadLine();
        }
        static void Login()
        {
            Console.WriteLine("Login manu");
            Console.Write("Name : ");
            string names = Console.ReadLine();
            Console.Write("Password : ");
            string passwords = Console.ReadLine();
            Console.WriteLine("Your Type");
            Console.WriteLine(" Student |1| ");
            Console.WriteLine(" Teacher |2| ");
            Console.Write("Select menu : ");
            int ty = int.Parse(Console.ReadLine());


            if (ty == 1)
            {
                Console.WriteLine("Register Activity Student");
                Activity();
            }
            if (ty == 2)
            {
                Console.WriteLine("Register Activity Teacher");
                Activity();
                Console.Clear();
            }

            static string Activity()
            {
                Console.Write("Please input activity : ");
                string regis = Console.ReadLine();
                Console.Clear();
                main();
                return Console.ReadLine();

            }
            static club creatclub()
            {
                return new club(Activity());
            }
        }
    }
}
