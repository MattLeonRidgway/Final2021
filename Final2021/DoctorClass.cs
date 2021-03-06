﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
// Doctor table info:
// Doctor DoctorID 
// DoctorFName string
// DoctorMName string
// DoctorLName string
// DoctorSex char M,F
// DoctorStatus int
// DoctorType int
// DoctorDepartment int
// DoctorClinic int
// DoctorEmail string
// DoctorNotes string
namespace Final2021
{
    class DoctorClass : DBConnection
    {
        string fName, mName, lName, email, notes;
        char sex;
        int status, type, department, clinic;
        public DoctorClass() { }

        public DoctorClass(string fName, string mName, string lName, string email, string notes, char sex, int status, int type, int department, int clinic)
        {

            this.fName = fName;
            this.mName = mName;
            this.lName = lName;
            this.email = email;
            this.notes = notes;
            this.sex = sex;
            this.status = status;
            this.type = type;
            this.department = department;
            this.clinic = clinic;
        }

        public string FName { get => fName; set => fName = value; }
        public string MName { get => mName; set => mName = value; }
        public string LName { get => lName; set => lName = value; }
        public string Email { get => email; set => email = value; }
        public string Notes { get => notes; set => notes = value; }
        public char Sex { get => sex; set => sex = value; }
        public int Status { get => status; set => status = value; }
        public int Type { get => type; set => type = value; }
        public int Department { get => department; set => department = value; }
        public int Clinic { get => clinic; set => clinic = value; }

        public void InsertDoctor(string first, string mid, string last, char sex, int stat, int type, int dep,
            int clinic, string email, string notes)
        {

            try
            {
                DBopen();
                SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO [Doctor] (DoctorFName, DoctorMName, DoctorLName, DoctorSex, DoctorStatus," +
                    "DoctorType, DoctorDepartment, DoctorClinic, DoctorEmail, DoctorNotes)" +
                   "VALUES(@fName,@mName,@lName,@sex,@stat,@type,@depart,@clinic,@email,@notes)", con);
                // "VALUES(?,?,?,?,?,?,?,?,?,?)",con);
                insertCommand.Parameters.Add(new SQLiteParameter("@fName", first));
                insertCommand.Parameters.Add(new SQLiteParameter("@mName", mid));
                insertCommand.Parameters.Add(new SQLiteParameter("@lName", last));
                insertCommand.Parameters.Add(new SQLiteParameter("@sex", sex));
                insertCommand.Parameters.Add(new SQLiteParameter("@stat", stat));
                insertCommand.Parameters.Add(new SQLiteParameter("@type", type));
                insertCommand.Parameters.Add(new SQLiteParameter("@depart", dep));
                insertCommand.Parameters.Add(new SQLiteParameter("@clinic", clinic));
                insertCommand.Parameters.Add(new SQLiteParameter("@email", email));
                insertCommand.Parameters.Add(new SQLiteParameter("@notes", notes));

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
        //get a Doctor
        public void getDoctor(int docID) {
            // need to test
            try {
                DBopen();
                SQLiteCommand sqlCMD;              
                SQLiteDataReader sqlGet;

                sqlCMD = con.CreateCommand();
                sqlCMD.CommandText="SELECT * FROM Doctor WHERE DoctorID=@ID";
                sqlCMD.Parameters.AddWithValue("@ID",docID);
                sqlGet =sqlCMD.ExecuteReader();

                while (sqlGet.Read())
                {
                   FName = sqlGet.GetString(2);
                   MName = sqlGet.GetString(3);
                   LName = sqlGet.GetString(4);
                   Sex = sqlGet.GetChar(5);
                   Status =sqlGet.GetInt32(6);
                   Type = sqlGet.GetInt32(7);
                   Department = sqlGet.GetInt32(8);
                   // Errors here 
                  // Clinic = sqlGet.GetInt32(9);
                  // Email = sqlGet.GetString(10);
                  // Notes = sqlGet.GetString(11);
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
           

        }
        // get a list of doctors from the database
        public List<string> ViewDoctor(List<string> doctorsList)
        {

            try
            {
                DBopen();
                SQLiteDataReader sqlGet;
                SQLiteCommand sqlCMD;
                sqlCMD = con.CreateCommand();
                sqlCMD.CommandText = "SELECT * FROM Doctor";
                sqlGet = sqlCMD.ExecuteReader();
                while (sqlGet.Read())
                {
                    string getDoc = sqlGet.GetString(11);
                    doctorsList.Add(getDoc);
                }
            }
            catch
            {
                Console.WriteLine("View Doctors catch");
            }
            finally { 
              DBClose();
            }
          
            return doctorsList;


        }// end ViewDoctor()
        public void UpdateDoctor(int dID, string first, string mid, string last, char sex, int stat, int type, int dep, int clinic, string email, string notes)
        {

            try
            {
                DBopen();
                SQLiteCommand sqlUpdate;
                sqlUpdate = con.CreateCommand();
                sqlUpdate.CommandText = "UPDATE INTO doctor WHERE dID=DoctorID(DoctorFName,DoctorMName,DoctorLName,DoctorSex,DoctorStatus,DoctorType,DoctorDepartment,DoctorClinic,DoctorEmail,DoctorNotes) " +
                "VALUES(first,mid,last,sex,stats,type,depart,clinic,email,notes);";
                sqlUpdate.ExecuteNonQuery();
            }
            catch
            {

            }
            DBClose();

        }
    }
}
