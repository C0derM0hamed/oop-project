using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
     class users
    {
        string name;
        string email;
        int phone;

        public void setname(string nm)
        {
            name = nm;
        }
        public void setemail(string em)
        {
            email = em;
        }
        public void setphone(int ph)
        {
            phone = ph;
        }

        public string getname() {
            return name;
        }
        public string getemail()
        {
            return name;
        }
        public int getphone()
        {
            return phone;
        }

      

    }
}
