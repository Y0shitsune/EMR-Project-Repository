using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Med_Docs.src
{
    public class User
    {
        public int id { get;}
        public enum Permission
        {
            CanCreateUser,
            CanDeleteUser,
            CanModifyUser,
            CanCreatePrescription,
            CanDeletePrescription,
            CanModifyPrescription,
            CanCreateMedRecord,
            CanDeleteMedRecord,
            CanModifyMedRecord
        }
        private List<Permission> _permissions { get; set; }
        private int _securityLevel;
        public User(string roleID, int id)
        {
            this.id = id;
            if (roleID.Equals("2000"))
            {
                _securityLevel = 3;
                _permissions = new List<Permission>()
                {
                    Permission.CanCreateUser,
                    Permission.CanDeleteUser,
                    Permission.CanModifyUser,
                    Permission.CanCreatePrescription,
                    Permission.CanDeletePrescription,
                    Permission.CanCreateMedRecord,
                    Permission.CanModifyMedRecord
                };
            }
            else if (roleID.Equals("2010"))
            {
                _securityLevel = 2;
                _permissions = new List<Permission>()
                {
                    Permission.CanCreatePrescription,
                    Permission.CanDeletePrescription,
                    Permission.CanCreateMedRecord,
                    Permission.CanModifyMedRecord
                };
            }
            else if (roleID.Equals("2020"))
            {
                _securityLevel = 1;
                _permissions = new List<Permission>()
                {
                    Permission.CanCreateMedRecord,
                    Permission.CanModifyMedRecord
                };
            }
        }
        public List<Permission> permissions { 
            get { return _permissions; } 
        }
        public int securityLevel
        {
            get { return _securityLevel; }
        }
    }
}
