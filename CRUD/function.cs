using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class function 
    {
        public static void adduser(List<users> ls)
        {
            users op1 = new users();
            Console.WriteLine("========================== add user ==================");
            Console.WriteLine("enter the name");
            op1.setname(Console.ReadLine());
            Console.WriteLine("enter the email");
            op1.setemail(Console.ReadLine());
            Console.WriteLine("enter the phone");
            op1.setphone(Convert.ToInt32(Console.ReadLine()));
            ls.Add(op1);
        }
        public static void UpdateUser(List<users> ls, int ph)
        {
            foreach (var u in ls)
            {
                if (ph == u.getphone())
                {
                    Console.WriteLine("edit name ");
                    u.setname(Console.ReadLine());
                    Console.WriteLine("edit email");
                    u.setemail(Console.ReadLine());
                    Console.WriteLine("edit phone ");
                    u.setphone(Convert.ToInt32(Console.ReadLine()));

                }
                else
                {
                    Console.WriteLine("user not found");
                }

            }
        }
        public static void DeleteUser(List<users> ls, int ph)
        {
            for (int i = 0; i < ls.Count; i++)
            {
                if (ph == ls[i].getphone())
                {
                    ls.Remove(ls[i]);
                }
                else
                {
                    Console.WriteLine("user not found");
                }

            }
        }
        public static void Display(List<users> ls)
        {
            int cnt = 1;
            foreach (var u in ls)
            {
                Console.WriteLine($"the user {cnt}");
                Console.WriteLine($"the name = {u.getname()} \n the email = {u.getemail()} \n the phone = {u.getphone()}");
                cnt++;
            }
        }
    }
}
