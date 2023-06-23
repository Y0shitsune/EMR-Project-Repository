using CrystalDecisions.Shared;
using Med_Docs.src;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Med_Docs.models.documents
{
    internal class CrystalReportGeneration
    {
        private static SqlConnection _conn;
        private static void GenerateXMLAsSecretary(Secretary secr, int hospitalID, int patID, int prescID)
        {
            StringBuilder mainQuery = new StringBuilder();
            mainQuery.AppendLine("SELECT LocationName," +
                "CONCAT(City,' ',Province) AS Address " +
                "FROM HOSPITAL " +
                $"WHERE HospitalID = {hospitalID};" +

                "SELECT CONCAT(First_Name,' ',SUBSTRING(Middle_Name,1,1),'. ', Last_Name) AS Name," +
                "CONCAT('Reg. No. ',LicenseNumber) AS LicenseNumber FROM APP_USER " +
                "INNER JOIN CREDENTIAL ON APP_USER.ID = CREDENTIAL.getID() "+
                $"WHERE ID = {secr.doctorID};" +

                "SELECT Title FROM CREDENTIAL " +
                $"WHERE UserID = {secr.doctorID};" +

                "SELECT Name, YEAR(Birthdate) AS Age, Sex, Address FROM PATIENT " +
                $"WHERE PatientID = {patID};" +

                "SELECT CONCAT(Description,'\n','Sig: ',Doses,'\n','#',Total) AS Medicine FROM MEDICINE "+
                "INNER JOIN PRESCRIPTION_MEDICINE ON MEDICINE.MedicineID = PRESCRIPTION_MEDICINE.MedicineID "+
                $"WHERE PRESCRIPTION_MEDICINE.PrescriptionID = {prescID};"
                );

            DataSet mainResults = DbConnection.doQuery(mainQuery.ToString(), _conn);

            int age = DbConnection.getAge(patID);
            mainResults.Tables[3].Rows[0][1] = age;

            mainResults.WriteXml(Application.StartupPath + "\\Prescription.xml");
        }
        private static void GenerateXMLAsDoctor(Doctor dr, int hospitalID, int patID, int prescID)
        {
            StringBuilder mainQuery = new StringBuilder();
            mainQuery.AppendLine("SELECT LocationName," +
                "CONCAT(City,' ',Province) AS Address " +
                "FROM HOSPITAL " +
                $"WHERE HospitalID = {hospitalID};" +

                "SELECT CONCAT(First_Name,' ',SUBSTRING(Middle_Name,1,1),'. ', Last_Name) AS Name," +
                "CONCAT('Reg. No. ',LicenseNumber) AS LicenseNumber FROM APP_USER " +
                "INNER JOIN CREDENTIAL ON APP_USER.ID = CREDENTIAL.getID() " +
                $"WHERE ID = {dr.getID()};" +

                "SELECT Title FROM CREDENTIAL " +
                $"WHERE UserID = {dr.getID()};" +

                "SELECT Name, YEAR(Birthdate) AS Age, Sex, Address FROM PATIENT " +
                $"WHERE PatientID = {patID};" +

                "SELECT CONCAT(Description,'\n','Sig: ',Doses,'\n','#',Total) AS Medicine FROM MEDICINE " +
                "INNER JOIN PRESCRIPTION_MEDICINE ON MEDICINE.MedicineID = PRESCRIPTION_MEDICINE.MedicineID " +
                $"WHERE PRESCRIPTION_MEDICINE.PrescriptionID = {prescID};"
                );

            DataSet mainResults = DbConnection.doQuery(mainQuery.ToString(), _conn);

            int age = DbConnection.getAge(patID);
            mainResults.Tables[3].Rows[0][1] = age;

            mainResults.WriteXml(Application.StartupPath + "\\Prescription.xml");
        }
        private static void GeneratePDF()
        {
            var folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Please enter the folder you want to save in";
            folderDialog.ShowNewFolderButton = true;
            folderDialog.RootFolder = Environment.SpecialFolder.Desktop;
            folderDialog.ShowDialog();

            DataSet ds = new DataSet();
            ds.ReadXml(Application.StartupPath + "\\Prescription.xml");


            var report = new PrescriptionReport();
            report.SetDataSource(ds.Tables);
            report.ExportToDisk(ExportFormatType.PortableDocFormat, $"{folderDialog.SelectedPath}\\REPORT.pdf");
        }
        public static void GenerateReport(User user,int hospitalID, int patID, int prescID)
        {
            _conn = DbConnection.getConnection();
            //get the typeof
            if(user.GetType() == typeof(Doctor))
            {
                GenerateXMLAsDoctor((Doctor)user, hospitalID,patID,prescID);
                GeneratePDF();
            }
            else if(user.GetType() == typeof(Secretary))
            {
                GenerateXMLAsSecretary((Secretary)user, hospitalID, patID, prescID);
                GeneratePDF();
            }
        }
    }
}
