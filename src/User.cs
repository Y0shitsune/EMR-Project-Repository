using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Med_Docs.src
{
    public class User
    {
        private enum Permissions { };
        private int _securityLevel;
        public User(string roleID) {
            if (roleID.Equals("2000"))
            {
                _securityLevel = 3;
                _permissions = new AdminPermissions();
            }
            else if (roleID.Equals("2010"))
            {
                _securityLevel = 2;
                _permissions = new DoctorPermissions();
            }
            else if (roleID.Equals("2020"))
            {
                _securityLevel = 1;
                _permissions = new SecretaryPermissions();
            }
        }
        public Permissions permissions { 
            get { return _permissions; } 
        }
        public int securityLevel
        {
            get { return _securityLevel; }
        }
    }
}
