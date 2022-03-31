using System;
using  static System.Console;


namespace Model
{
    internal class Modle
    {

        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return "User: " + Id + " " + Name + " " + Age;
            }

            public User(int Id, string Name, int Age)
            {
                this.Id = Id;
                this.Name = Name;
                this.Age = Age;
            }
        }
        public class StaffUser
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public enum Role { Role1, Role2, Role3 };

            public StaffUser(int id, string n, int age)
            {
                Id = id;
                Name = n;
                Age = age;
            }

            public override string ToString()
            {
                return "Staff User : " + Id + " " + Name + " " + Age + " ";
            }
        }
        public class AdminUser
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public List<StaffUser> Staff = new List<StaffUser>();


            public override string ToString()
            {
                return "Admin User: " + Id + " " + Name + " " + Age;
            }


            public AdminUser(int id, string name, int age)
            {
                Id = id;
                Name = name;
                Age = age;
            }
            public AdminUser() { }

           
        }
        public class Menu
        {
            public void ShowForUser()
            {
                Console.WriteLine("What Is The Type Of User : " + "\n");
                Console.WriteLine("Please choose the number to choose the user " + "\n");
                Console.WriteLine("Please choose the number to choose the  Staff User " + "\n");
                Console.WriteLine("Please choose the number to choose the  Admin User " + "\n" + "\n");


            }
            public void ShowOperation()
            {
                Console.WriteLine("The Operation : " + "\n");
                Console.WriteLine("Please choose A to Add " + "\n");
                Console.WriteLine("Please choose E to Edit " + "\n");
                Console.WriteLine("Please choose D to Delete " + "\n");
                Console.WriteLine("Please choose X to Exit " + "\n");

            }
        }

    }
}

