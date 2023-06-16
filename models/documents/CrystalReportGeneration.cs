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
        SqlConnection _conn;

        public CrystalReportGeneration()
        {
            _conn = DbConnection.getConnection();
        }

        public void GenerateXML(int prescID, int licID, int patID)
        {
            string medIDQuery = $"SELECT MedicineID FROM PRESCRIPTION_DOCUMENT WHERE PrescriptionID = {prescID};";

            StringBuilder mainQuery = new StringBuilder();
            mainQuery.AppendLine("SELECT LocationName," +
                "CONCAT(City,' ',Province) AS Address " +
                "FROM FACILITY " +
                $"WHERE LicenseNumber = {licID};" +

                "SELECT CONCAT(First_Name,' ',SUBSTRING(Middle_Name,1,1),'. ', Last_Name) AS Name," +
                "CONCAT('Reg. No. ',LicenseNumber) AS LicenseNumber FROM APP_USER " +
                $"WHERE LicenseNumber = {licID};" +

                "SELECT JobTitle FROM DOCTOR " +
                $"WHERE LicenseNumber = {licID};" +

                "SELECT Patient_Name, YEAR(Birthdate) AS Age, Sex, Patient_Address FROM PATIENT " +
                $"WHERE PatientID = {patID};" +


                "SELECT CONCAT(Description,'\n','Sig: ',Doses,'\n','#',Total) AS Medicine FROM MEDICINE"
                );

            DataSet mainResults = DbConnection.doQuery(mainQuery.ToString(), _conn);
            DataSet medIDResults = DbConnection.doQuery(medIDQuery, _conn);

            DataRow firstrow = medIDResults.Tables[0].Rows[0];
            mainQuery.Append($"WHERE MedicineID = {firstrow[0]}");

            firstrow.Delete();
            firstrow.AcceptChanges();

            foreach (DataRow row in medIDResults.Tables[0].Rows)
            {
                mainQuery.Append($"\nOR MedicineID = {row[0]}");
            }

            mainQuery.Append(";");

            int age = DbConnection.getAge(patID);
            mainResults.Tables[3].Rows[0][1] = age;

            mainResults.WriteXml(Application.StartupPath + "\\Prescription.xml");
        }

        public void GeneratePDF()
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

        public void GenerateReport()
        {
            if (File.Exists(Application.StartupPath + "\\Prescription.xml"))
            {
                GeneratePDF();
            }
            else
            {
                GenerateXML(909321, 123213, 33401032);
                GeneratePDF();
            }
        }
    }
}
