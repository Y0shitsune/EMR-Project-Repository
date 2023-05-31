using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Med_Docs.src
{
    internal class Constants
    {
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

        public List<Permission> adminPermissions = new List<Permission>()
        {
            Permission.CanCreateUser,
            Permission.CanDeleteUser,
            Permission.CanModifyUser,
            Permission.CanCreatePrescription,
            Permission.CanDeletePrescription,
            Permission.CanCreateMedRecord,
            Permission.CanModifyMedRecord
        };

        public List<Permission> doctorPermissions = new List<Permission>()
        {
            Permission.CanCreatePrescription,
            Permission.CanDeletePrescription,
            Permission.CanCreateMedRecord,
            Permission.CanModifyMedRecord
        };

        public List<Permission> secretaryPermissions = new List<Permission>()
        {
            Permission.CanCreateMedRecord,
            Permission.CanModifyMedRecord
        };
    }
}
