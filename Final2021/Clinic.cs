using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Final2021
{/* Clinic Class:
  * Builds the Clinic Object
  * Insert and Update
  * Gets Clinic List
  */
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
        /* InsertClinic:
         * Insert Clinic the ID is auto incremented at the DB
         */
        public void InsertClinic(string clinic)
        {
           
            try
            {
                DBopen();
                SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO [Clinic] (Clinic) VALUES(@clinic)", con);
                insertCommand.Parameters.Add(new SQLiteParameter( "@clinic",ClinicString));
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
        }// END insert clinic

        /* ViewClinic:
         * Returns a List of Clinics
         */
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
            catch (SQLiteException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                DBClose();

            }
            return clinicList;
        }// end ViewClinic()
        /* UpdateClinic
         * clinicID and clinicType sent in
         * Update Clinic by type and ID
         */
        public void UpdateClinic(int clinicID, string clinicString)
        {

            try
            {
                DBopen();
                SQLiteCommand sqlUpdate =new SQLiteCommand("UPDATE Clinic SET Clinic=@clinic WHERE ClinicID=@iD", con);
                sqlUpdate.Parameters.Add(new SQLiteParameter("@iD",ClinicID));
                sqlUpdate.Parameters.Add(new SQLiteParameter("@clinic",ClinicString));      
                // Execute
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

        }// END UpdateClinic
    }//END class
}
