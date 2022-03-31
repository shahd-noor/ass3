using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Model.Modle;
using static View.View;

namespace ModelView
{
    
    internal class ModelView {


        public class Functions
        {
           public void AddUser (List< User >list , User u ){
                
                list.Add(u);


            }
            public void DeleteUser(List<User> list, int id)
            {
                int index = list.FindIndex(x => x.Id == id);
                list.Remove(list[index]);

            }
            public void EditUser(List<User> list, int  id ,User u)
            {
                int index = list.FindIndex(x => x.Id == id);
                list[index].Id = u.Id;
                list[index].Name = u.Name;
                list[index].Age = u.Age;

            }
            public void AddStaffUser(List<StaffUser> list, StaffUser u)
            {

                list.Add(u);


            }
            public void EdiStfftUser(List<StaffUser> list, int id, StaffUser u)
            {
                int index = list.FindIndex(x => x.Id == id);
                list[index].Id = u.Id;
                list[index].Name = u.Name;
                list[index].Age = u.Age;


            }
            public void DeleteStaffUser(List<StaffUser> list, int id)
            {
                int index = list.FindIndex(x => x.Id == id);
                list.Remove(list[index]);

            }
            public void AddAdminUser(List<AdminUser> list, AdminUser u )
            {

                list.Add(u);


            }
            public void EditAdminUser(List<AdminUser> list, int id, AdminUser u)
            {
                int index = list.FindIndex(x => x.Id == id);
                list[index].Id = u.Id;
                list[index].Name = u.Name;
                list[index].Age = u.Age;


            }
            public void DeleteAdminUser(List<AdminUser> list, int id)
            {
                int index = list.FindIndex(x => x.Id == id);
                list.Remove(list[index]);

            }

            static void Main(string[] args)
            {

                List<User> users = new List<User>();
                List<StaffUser> staf = new List<StaffUser>();

                List<AdminUser> admins = new List<AdminUser>();

                int UserNum;
                char Operation;
                string UserName = null;
                int Id = 0;
                int Age = 0;
                int NumberOfStaffInAdimn = 0;

                Menu menu = new Menu();
                Functions func = new Functions();

                menu.ShowForUser();
                UserNum = Convert.ToInt32(Console.ReadLine());
                menu.ShowOperation();
                Operation = Convert.ToChar(Console.ReadLine());

                do
                {

                    switch (UserNum)
                    {

                        case 1:
                            {
                                if (Operation.Equals("A") || Operation.Equals("a"))
                                {
                                    Console.WriteLine("Please Enter User ID  : ");
                                    try
                                    {
                                        Id = Convert.ToInt32(Console.ReadLine());
                                        bool IsExest = users.Exists(x => x.Id == Id);
                                        if (IsExest)
                                            throw new DuplicateIdExpction(" You Have Enter Duplicate ID !!");

                                    }
                                    catch (DuplicateIdExpction ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }

                                    Console.WriteLine("\n" + "Please Enter User Name  :   ");
                                    try
                                    {
                                        UserName = Console.ReadLine();
                                        if (!(UserName.GetType().Equals(typeof(string))))
                                            throw new InValidDataExpction("Not Vaild Input !");


                                    }
                                    catch (InValidDataExpction ex)
                                    {
                                        Console.WriteLine(ex);

                                    }
                                    try
                                    {
                                        Console.WriteLine("Please Enter User Age  :   ");
                                        Age = Convert.ToInt32(Console.ReadLine());
                                        if (Age.GetType().Equals(typeof(string)))
                                            throw new InValidDataExpction("You Enter String Instead Of Number !!");

                                    }
                                    catch (InValidDataExpction ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }


                                    User user = new User(Id, UserName, Age);
                                    func.AddUser(users, user);

                                }


                                if (Operation.Equals("E") || Operation.Equals("e"))
                                {
                                    Console.WriteLine("Enter The Id of The User You Want to Update His/ Her Information " + "\n");
                                    try
                                    {
                                        Id = Convert.ToInt32(Console.ReadLine());
                                        if (!users.Exists(x => x.Id == Id))
                                            throw new NotFoundExpction("There Is No Such A User");
                                        else
                                        {
                                            int index = users.FindIndex(x => x.Id == Id);
                                            Console.WriteLine("New ID :  " + "\n");
                                            Id = Convert.ToInt32(Console.ReadLine());

                                            Console.WriteLine("\n" + "New Name :  ");
                                            UserName = Console.ReadLine();
                                            Console.WriteLine("\n" + "New Age :  ");
                                            Age = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("\n");
                                            User user = new User(Id, UserName, Age);
                                            func.EditUser(users, Id, user);

                                        }


                                    }
                                    catch (NotFoundExpction e)
                                    {
                                        Console.WriteLine(e.Message);
                                    }
                                }


                                if (Operation.Equals("D") || Operation.Equals("d"))
                                {
                                    Console.WriteLine("Please Enter The Id of The User You Want to Update His/ Her Information " + "\n");

                                    try
                                    {
                                        Id = Convert.ToInt32(Console.ReadLine());
                                        if (!(users.Exists(x => x.Id == Id)))
                                            throw new NotFoundExpction("This User Is Not Existed to Delete");
                                        else
                                        {
                                            func.DeleteUser(users, Id);
                                        }

                                    }
                                    catch (NotFoundExpction e)
                                    {
                                        Console.WriteLine(e.Message);
                                    }

                                }
                            }
                            break;


                        case 2:
                            {
                                if (Operation.Equals("A") || Operation.Equals("a"))
                                {
                                    Console.WriteLine("Please Enter Staff USer ID  :   ");
                                    try
                                    {
                                        Id = Convert.ToInt32(Console.ReadLine());
                                        bool IsExest = users.Exists(x => x.Id == Id);
                                        if (IsExest)
                                            throw new DuplicateIdExpction(" You Have Enter Duplicate ID !!");



                                    }
                                    catch (DuplicateIdExpction ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }

                                    Console.WriteLine("\n" + "Enter User Name  :   ");
                                    try
                                    {
                                        UserName = Console.ReadLine();
                                        if (!(UserName.GetType().Equals(typeof(string))))
                                            throw new InValidDataExpction("Not Vaild Input !");


                                    }
                                    catch (InValidDataExpction ex)
                                    {
                                        Console.WriteLine(ex);

                                    }
                                    try
                                    {
                                        Console.WriteLine("Please Enter User Age  :   ");
                                        Age = Convert.ToInt32(Console.ReadLine());
                                        if (Age.GetType().Equals(typeof(string)))
                                            throw new InValidDataExpction("You Enter String Instead Of Number !!");

                                    }
                                    catch (InValidDataExpction ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }
                                    StaffUser staff = new StaffUser(Id, UserName, Age);

                                    func.AddStaffUser(staf, staff);

                                }


                                if (Operation.Equals("E") || Operation.Equals("e"))
                                {
                                    Console.WriteLine("Please Enter The Id of The User You Want to Update His/ Her Information " + "\n");
                                    try
                                    {
                                        Id = Convert.ToInt32(Console.ReadLine());
                                        if (!users.Exists(x => x.Id == Id))
                                            throw new NotFoundExpction("There Is No Such A User");
                                        else
                                        {
                                            int index = users.FindIndex(x => x.Id == Id);
                                            Console.WriteLine("New ID :  " + "\n");
                                            Id = Convert.ToInt32(Console.ReadLine());

                                            Console.WriteLine("\n" + "New Name :  ");
                                            UserName = Console.ReadLine();
                                            Console.WriteLine("\n" + "New Age :  ");
                                            Age = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("\n");
                                            StaffUser staff = new StaffUser(Id, UserName, Age);

                                            func.EdiStfftUser(staf, Id, staff);

                                        }


                                    }
                                    catch (NotFoundExpction e)
                                    {
                                        Console.WriteLine(e.Message);
                                    }

                                }


                                if (Operation.Equals("D") || Operation.Equals("d"))
                                {
                                    Console.WriteLine("Please Enter The Id of The User You Want to Update His/ Her Information " + "\n");

                                    try
                                    {
                                        Id = Convert.ToInt32(Console.ReadLine());
                                        if (!(users.Exists(x => x.Id == Id)))
                                            throw new NotFoundExpction("This User Is Not Existed to Delete");
                                        else
                                        {
                                            func.DeleteStaffUser(staf, Id);
                                        }

                                    }
                                    catch (NotFoundExpction e)
                                    {
                                        Console.WriteLine(e.Message);
                                    }

                                }
                            }
                            break;



                        case 3:
                            {
                                if (Operation.Equals("A") || Operation.Equals("a"))
                                {
                                    Console.WriteLine("Enter Admin User ID  :   ");
                                    try
                                    {
                                        Id = Convert.ToInt32(Console.ReadLine());
                                        bool IsExest = users.Exists(x => x.Id == Id);
                                        if (IsExest)
                                            throw new DuplicateIdExpction(" You Have Enter Duplicate ID !!");



                                    }
                                    catch (DuplicateIdExpction ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }

                                    Console.WriteLine("\n" + "Enter User Name  :   ");
                                    try
                                    {
                                        UserName = Console.ReadLine();
                                        if (!(UserName.GetType().Equals(typeof(string))))
                                            throw new InValidDataExpction("Not Vaild Input !");


                                    }
                                    catch (InValidDataExpction ex)
                                    {
                                        Console.WriteLine(ex);

                                    }
                                    try
                                    {
                                        Console.WriteLine("Please Enter User Age  :   ");
                                        Age = Convert.ToInt32(Console.ReadLine());
                                        if (Age.GetType().Equals(typeof(string)))
                                            throw new InValidDataExpction("You Enter String Instead Of Number !!");

                                    }
                                    catch (InValidDataExpction ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }

                                    Console.WriteLine("Do " + UserName + "  Have Staff Users ?" + "\n" + "If Yes Plaese Enter The Number If No enter 0 " + "\n");
                                    NumberOfStaffInAdimn = Convert.ToInt32(Console.ReadLine());

                                    if (NumberOfStaffInAdimn == 0)
                                    {
                                        AdminUser admin = new AdminUser(Id, UserName, Age);

                                    }
                                    else
                                    {
                                        for (int i = 0; i < NumberOfStaffInAdimn; i++)
                                        {

                                            AdminUser admin = new AdminUser();
                                            Console.WriteLine("Enter Staff USer ID  :   ");
                                            try
                                            {
                                                Id = Convert.ToInt32(Console.ReadLine());
                                                bool IsExest = users.Exists(x => x.Id == Id);
                                                if (IsExest)
                                                    throw new DuplicateIdExpction(" You Have Enter Duplicate ID !!");



                                            }
                                            catch (DuplicateIdExpction ex)
                                            {
                                                Console.WriteLine(ex.Message);
                                            }

                                            Console.WriteLine("\n" + "Enter User Name  :   ");
                                            try
                                            {
                                                UserName = Console.ReadLine();
                                                if (!(UserName.GetType().Equals(typeof(string))))
                                                    throw new InValidDataExpction("Not Vaild Input !");


                                            }
                                            catch (InValidDataExpction ex)
                                            {
                                                Console.WriteLine(ex);

                                            }
                                            try
                                            {
                                                Console.WriteLine("Enter User Age  :   ");
                                                Age = Convert.ToInt32(Console.ReadLine());
                                                if (Age.GetType().Equals(typeof(string)))
                                                    throw new InValidDataExpction("You Enter String Instead Of Number !!");

                                            }
                                            catch (InValidDataExpction ex)
                                            {
                                                Console.WriteLine(ex.Message);
                                            }
                                            StaffUser staff = new StaffUser(Id, UserName, Age);

                                            admin.Staff[i] = staff;


                                        }
                                    }

                                }


                                if (Operation.Equals("E") || Operation.Equals("e"))
                                {
                                    Console.WriteLine("Enter The Id of The User You Want to Update His/ Her Information " + "\n");
                                    try
                                    {
                                        Id = Convert.ToInt32(Console.ReadLine());
                                        if (!users.Exists(x => x.Id == Id))
                                            throw new NotFoundExpction("There Is No Such A User");
                                        else
                                        {
                                            int index = users.FindIndex(x => x.Id == Id);
                                            Console.WriteLine("New ID :  " + "\n");
                                            Id = Convert.ToInt32(Console.ReadLine());

                                            Console.WriteLine("\n" + "New Name :  ");
                                            UserName = Console.ReadLine();
                                            Console.WriteLine("\n" + "New Age :  ");
                                            Age = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("\n");
                                            AdminUser admin = new AdminUser(Id, UserName, Age);

                                            func.EditAdminUser(admins, Id, admin);

                                        }


                                    }
                                    catch (NotFoundExpction e)
                                    {
                                        Console.WriteLine(e.Message);
                                    }

                                }


                                if (Operation.Equals("D") || Operation.Equals("d"))
                                {
                                    Console.WriteLine("Enter The Id of The User You Want to Update His/ Her Information " + "\n");

                                    try
                                    {
                                        Id = Convert.ToInt32(Console.ReadLine());
                                        if (!(users.Exists(x => x.Id == Id)))
                                            throw new NotFoundExpction("This User Is Not Existed to Delete");
                                        else
                                        {

                                            func.DeleteAdminUser(admins, Id);
                                        }

                                    }
                                    catch (NotFoundExpction e)
                                    {
                                        Console.WriteLine(e.Message);
                                    }

                                }
                            }
                            break;
                    }
                    break;


                } while ('x'.Equals(Operation) || UserNum == 0);

            }

        }

    }
}
        


    


