using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Med_Docs.src
{
    public class User
    {
        protected string name {  get; set; }
        protected int userID { get; set; }
        protected int roleID { get; set; }
        public int getRole()
        {
            return roleID;
        }

        public int getID()
        {
            return userID;
        }

        public string getName()
        {
            return name;
        }

        public User(int userID, string name)
        { 
            this.userID = userID;
            this.name = name;
        }
    }
    public class Admin : User
    {
        
        public Admin(int userID, string name) : base(userID,name)
        {
            this.userID = userID;
            this.name = name;
            roleID = 1000;
        }
    }

    public class Doctor : User
    {
        public Doctor(int userID, string name) : base(userID,name)
        {
            this.userID = userID;
            this.name = name;
            roleID = 1001;
        }
    }
    public class Secretary : User
    {
        public int doctorID { get; }
        public Secretary(int userID, int doctorID, string name) : base(userID,name)
        {
            this.userID = userID;
            this.doctorID = doctorID;
            this.name = name;
            roleID = 1002;
        }
    }
}
