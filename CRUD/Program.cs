using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class Program :function
    {

        static void Main(string[] args)
        {

            int l = 0;
            List<users> ls = new List<users>();

            while (l == 0 ) { 
            Console.WriteLine("1- Add user");
            Console.WriteLine("2- Update user");
            Console.WriteLine("3- Delete user");
            Console.WriteLine("4- Display user");
            int x = Convert.ToInt32(Console.ReadLine());
                users op1 = new users();

                #region adduser
                if (x == 1)
                {
                    adduser(ls);
                }
                #endregion
                #region update
                else if (x == 2)
                {
                    Console.WriteLine("enter the phone number u want to update");
                    int ph;
                    ph = Convert.ToInt32(Console.ReadLine());
                    UpdateUser(ls, ph);
                }
                #endregion
                #region delete
                else if (x == 3)
                {
                    Console.WriteLine("enter the phone number u want to update");
                    int pho;
                    pho = Convert.ToInt32(Console.ReadLine());
                  DeleteUser(ls, pho);
                }
                #endregion
                #region display
                else if (x == 4)
                {
                    Display(ls);
                } 
                #endregion
                Console.WriteLine("if you want to do anothor operation enter 0 else enter any number");
                l = Convert.ToInt32(Console.ReadLine());

            }
         
        }
    }
}
