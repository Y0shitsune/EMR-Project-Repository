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
    }
    internal class DoctorPermissions : Permissions
    {
    }
    internal class SecretaryPermissions : Permissions
    {
    }
}
