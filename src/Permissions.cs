using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Med_Docs.src
{
    public abstract class Permissions
    {
        private Boolean canCreateUser;
        private Boolean canDeleteUser;
        private Boolean canModifyUser;
        private Boolean canCreatePrescription;
        private Boolean canDeletePrescription;
        private Boolean canModifyPrescription;
        private Boolean canCreateMedRecord;
        private Boolean canDeleteMedRecord;
        private Boolean canModifyMedRecord;
    }
    internal class AdminPermissions : Permissions
    {
        private Boolean canCreateUser = true;
        private Boolean canDeleteUser = true;
        private Boolean canModifyUser = true;
        private Boolean canCreatePrescription = true;
        private Boolean canDeletePrescription = true;
        private Boolean canModifyPrescription = true;
        private Boolean canCreateMedRecord = true;
        private Boolean canDeleteMedRecord = true;
        private Boolean canModifyMedRecord = true;
    }
    internal class DoctorPermissions : Permissions
    {
        private Boolean canCreateUser = true;
        private Boolean canDeleteUser = false;
        private Boolean canModifyUser = false;
        private Boolean canCreatePrescription = true;
        private Boolean canDeletePrescription = true;
        private Boolean canModifyPrescription = true;
        private Boolean canCreateMedRecord = true;
        private Boolean canDeleteMedRecord = true;
        private Boolean canModifyMedRecord = true;
    }
    internal class SecretaryPermissions : Permissions
    {
        private Boolean canCreateUser = false;
        private Boolean canDeleteUser = false;
        private Boolean canModifyUser = false;
        private Boolean canCreatePrescription = true;
        private Boolean canDeletePrescription = false;
        private Boolean canModifyPrescription = false;
        private Boolean canCreateMedRecord = false;
        private Boolean canDeleteMedRecord = false;
        private Boolean canModifyMedRecord = false;
    }
}
