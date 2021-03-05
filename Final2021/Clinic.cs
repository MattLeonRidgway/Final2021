using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Final2021
{
    class Clinic : DBConnection
    {
        int clinicID;
        string clinicString;

        public Clinic() { }
        public Clinic(string clinic)
        {

            this.clinicString = clinic;
        }
        public Clinic(int clinicID, string clinic)
        {
            this.clinicID = clinicID;
            this.clinicString = clinic;
        }

        public int ClinicID { get => clinicID; set => clinicID = value; }
        public string ClinicString { get => clinicString; set => clinicString = value; }
        // INSERT clinic WORKING
        public void InsertClinic(string clinic)
        {

            try
            {
                DBopen();
                SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO Clinic (Clinic)VALUES(?)", con);
                insertCommand.Parameters.AddWithValue(clinic, ClinicString);
                insertCommand.ExecuteNonQuery();

            }
            catch (SQLiteException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                DBClose();
            }
        }// end insert clinic
        // get a list of clinics 
        public List<string> ViewClinic(List<string> clinicList)
        {

            try
            {
                DBopen();
                SQLiteDataReader sqlGet;
                SQLiteCommand sqlCMD;
                sqlCMD = con.CreateCommand();
                sqlCMD.CommandText = "SELECT * FROM Clinic";
                sqlGet = sqlCMD.ExecuteReader();
                while (sqlGet.Read())
                {
                    string getClinic = sqlGet.GetString(11);
                    clinicList.Add(getClinic);
                }
            }
            catch
            {
                Console.WriteLine("View clinic catch");
            }
            DBClose();
            return clinicList;
        }// end ViewClinic()
        public void UpdateClinic(int clinicID, string clinicType)
        {

            try
            {
                DBopen();
                SQLiteCommand sqlUpdate =new SQLiteCommand("UPDATE Clinic SET Clinic=@clinic WHERE ClinicID=@iD", con);
                sqlUpdate.Parameters.Add(new SQLiteParameter("@iD"));
                sqlUpdate.Parameters.Add(new SQLiteParameter("@clinic"));
                sqlUpdate.Parameters["@iD"].Value = clinicID;
                sqlUpdate.Parameters["@clinic"].Value = clinicType;

              
                sqlUpdate.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                DBClose();

            }

        }
    }
}
