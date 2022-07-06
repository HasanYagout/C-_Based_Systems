using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Hotel_Management_System
{
    class Users
    {
        public void addUser()
        {
            Login form1 = new Login();
            bool success = form1.InsertAdminUser(form1);
            
            
        
        }
       
    }
}
