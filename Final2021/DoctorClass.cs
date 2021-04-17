using System;
using System.Collections.Generic;
using System.Data.SQLite;
// Doctor table info:
// Doctor DoctorID 
// DoctorFName string
// DoctorMName string
// DoctorLName string
// DoctorStatus int
// DoctorType int
// DoctorDepartment int
// DoctorClinic int
// DoctorEmail string
// DoctorNotes string
namespace Final2021
{/* DoctorClass
  * Used to Insert, Update, Delete
  * Get a List of Active Doctors
  * Get View
  * 
  */
    class DoctorClass : DBConnection
    {// Doctor extends DBConnection
        // Variables
        string fName, mName, lName, email, notes;

        int status, type, department, clinic;
        // Empty Constructor
        public DoctorClass() { }

        public DoctorClass(string fName, string mName, string lName, string email, string notes, int status, int type, int department, int clinic)
        {
            this.fName = fName;
            this.mName = mName;
            this.lName = lName;
            this.email = email;
            this.notes = notes;         
            this.status = status;
            this.type = type;
            this.department = department;
            this.clinic = clinic;
        }
        // Getters and Setters
        public string FName { get => fName; set => fName = value; }
        public string MName { get => mName; set => mName = value; }
        public string LName { get => lName; set => lName = value; }
        public string Email { get => email; set => email = value; }
        public string Notes { get => notes; set => notes = value; }      
        public int Status { get => status; set => status = value; }
        public int Type { get => type; set => type = value; }
        public int Department { get => department; set => department = value; }
        public int Clinic { get => clinic; set => clinic = value; }
        /* Insert Doctor
         * Open DB connection Insert a new doctor and close DB connection
         */
        public void InsertDoctor(string first, string mid, string last, int stat, int type, int dep,
            int clinic, string email, string notes)
        {

            try
            {// INSERT sql statement
                DBopen();
                SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO [Doctor] (DoctorFName, DoctorMName, DoctorLName, DoctorStatus," +
                    "DoctorType, DoctorDepartment, DoctorClinic, DoctorEmail, DoctorNotes)" +
                   "VALUES(@fName,@mName,@lName,@stat,@type,@depart,@clinic,@email,@notes)", con);
             // Parameters
                insertCommand.Parameters.Add(new SQLiteParameter("@fName", first));
                insertCommand.Parameters.Add(new SQLiteParameter("@mName", mid));
                insertCommand.Parameters.Add(new SQLiteParameter("@lName", last));     
                insertCommand.Parameters.Add(new SQLiteParameter("@stat", stat));
                insertCommand.Parameters.Add(new SQLiteParameter("@type", type));
                insertCommand.Parameters.Add(new SQLiteParameter("@depart", dep));
                insertCommand.Parameters.Add(new SQLiteParameter("@clinic", clinic));
                insertCommand.Parameters.Add(new SQLiteParameter("@email", email));
                insertCommand.Parameters.Add(new SQLiteParameter("@notes", notes));
                // Execute 
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
        }// end insert doctor
        /* GetDoctor selected doctor
         * 
         */
        public void GetDoctor(int docID)
        {
            // get the doctor using ID
            try
            {
                DBopen();
                SQLiteCommand sqlCMD;
                sqlCMD = con.CreateCommand();
                sqlCMD.CommandText = "SELECT * FROM Doctor WHERE DoctorID=@ID";
                sqlCMD.Parameters.Add(new SQLiteParameter("@ID", docID));
                // READER
                SQLiteDataReader sqlGet = sqlCMD.ExecuteReader();

                while (sqlGet.Read())
                {// Build doctor
                    FName = sqlGet.GetString(1);
                    MName = sqlGet.GetString(2);
                    LName = sqlGet.GetString(3);
                    Status = sqlGet.GetInt32(4);
                    Type = sqlGet.GetInt32(5);
                    Department = sqlGet.GetInt32(6);
                    Clinic = sqlGet.GetInt16(7);
                    Email = sqlGet.GetString(8);
                    Notes = sqlGet.GetString(9);
                }
            }//end try
            catch (SQLiteException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                DBClose();
            }

        }// END GetDoctor
        /* DeleteDoctor
         * delete the selected doctor based on docID
         */
        public void DeleteDoctor(int docID) {
            try
            {
                DBopen();
                SQLiteCommand sqlCMD;
                sqlCMD = con.CreateCommand();
                sqlCMD.CommandText = "DELETE FROM Doctor WHERE DoctorID=@ID";
                sqlCMD.Parameters.Add(new SQLiteParameter("@ID", docID));
                // Execute statement
                sqlCMD.ExecuteNonQuery();
            }//end try
            catch (SQLiteException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                DBClose();
            }

        }
        // End Delete Doctor
        /* ViewDoctor
         * get a list of doctors from the database WHERE departmentID
         * returns a list
         */

        public List<string> ViewDoctor(int department)
        {
            List<string> doctorList = new List<string>();
           // Status active = 1 
            int status = 1;
            try
            {
                DBopen();
                SQLiteCommand sqlCMD;
                sqlCMD = con.CreateCommand();
                sqlCMD.CommandText = "SELECT * FROM Doctor WHERE DoctorDepartment=@departID AND DoctorStatus=@statusID";
                sqlCMD.Parameters.Add(new SQLiteParameter("@departID", department));
                sqlCMD.Parameters.Add(new SQLiteParameter("@statusID", status));

                SQLiteDataReader sqlGet = sqlCMD.ExecuteReader();

                while (sqlGet.Read())
                {
                   // Read from DB and add to list LOOP
                    doctorList.Add(sqlGet.GetString(8));
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

            return doctorList;


        }// end ViewDoctor()
        /* ListIntDoctor
         * Build an int List of doctors from the database WHERE departmentID
         * DoctorId is an INT
         */
        public List<int> ListIntDoctor(int department)
        {
            List<int> doctorList = new List<int>();
            // Status active = 1 
            int status = 1;
            try
            {
                DBopen();
                SQLiteCommand sqlCMD;
                sqlCMD = con.CreateCommand();
                sqlCMD.CommandText = "SELECT * FROM Doctor WHERE DoctorDepartment=@departID AND DoctorStatus=@statusID";
                sqlCMD.Parameters.Add(new SQLiteParameter("@departID", department));
                sqlCMD.Parameters.Add(new SQLiteParameter("@statusID", status));

                SQLiteDataReader sqlGet = sqlCMD.ExecuteReader();
                while (sqlGet.Read())
                {
                    doctorList.Add(sqlGet.GetInt32(0));
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

            return doctorList;


        }//END list int doctor
         /* UpdateDoctor
          * Updates the doctor BY doctor ID
          */
        public void UpdateDoctor(int dID, string first, string mid, string last, int stat, int type, int dep, int clinic, string email, string notes)
        {
            try
            {
                DBopen();
                SQLiteCommand sqlUpdate = new SQLiteCommand("UPDATE Doctor SET DoctorID=@ID, DoctorFName=@fName,DoctorMName=@mName,DoctorLName=@lName," +
                    "DoctorStatus=@status,DoctorType=@type,DoctorDepartment=@depart,DoctorClinic=@clinic,DoctorEmail=@email,DoctorNotes=@note " +
                    "WHERE DoctorID=@ID", con);
                sqlUpdate.Parameters.Add(new SQLiteParameter("@ID", dID));
                sqlUpdate.Parameters.Add(new SQLiteParameter("@fName", first));
                sqlUpdate.Parameters.Add(new SQLiteParameter("@mName", mid));
                sqlUpdate.Parameters.Add(new SQLiteParameter("@lName", last));
                sqlUpdate.Parameters.Add(new SQLiteParameter("@status", stat));
                sqlUpdate.Parameters.Add(new SQLiteParameter("@type", type));
                sqlUpdate.Parameters.Add(new SQLiteParameter("@depart", dep));
                sqlUpdate.Parameters.Add(new SQLiteParameter("@clinic", clinic));
                sqlUpdate.Parameters.Add(new SQLiteParameter("@email", email));
                sqlUpdate.Parameters.Add(new SQLiteParameter("@note", notes));

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
        // END UPDATE doctor
    }//END class
}
