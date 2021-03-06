using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Final2021
{
    class NurseClass : DBConnection
    {
        string fName, mName, lName, email, notes;       
        int status, type, department, clinic;
        //Empty constructor
        public NurseClass() { }

        public NurseClass(string fName, string mName, string lName, string email, string notes, int status, int type, int department, int clinic)
        {            this.fName = fName;
            this.mName = mName;
            this.lName = lName;
            this.email = email;
            this.notes = notes;          
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
        public int Status { get => status; set => status = value; }
        public int Type { get => type; set => type = value; }
        public int Department { get => department; set => department = value; }
        public int Clinic { get => clinic; set => clinic = value; }

        public void InsertNurse(string first, string mid, string last, int stat, int type, int dep, int clinic, string email, string notes)
        {


            try
            {
                DBopen();
                SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO [Nurse] (NurseFName, NurseMName, NurseLName, NurseStatus," +
                    "NurseType, NurseDepartment, NurseClinic, NurseEmail, NurseNotes)" +
                   "VALUES(@fName,@mName,@lName,@stat,@type,@depart,@clinic,@email,@notes)", con);
                // "VALUES(?,?,?,?,?,?,?,?,?)",con);
                insertCommand.Parameters.Add(new SQLiteParameter("@fName", first));
                insertCommand.Parameters.Add(new SQLiteParameter("@mName", mid));
                insertCommand.Parameters.Add(new SQLiteParameter("@lName", last));        
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
        }// end insert nurse
         // get Nurse Get
        public void getNurse(int nurseID)
        {
           
            try
            {
                DBopen();
                SQLiteCommand sqlCMD;

                sqlCMD = con.CreateCommand();
                sqlCMD.CommandText = "SELECT * FROM Nurse WHERE NurseID=@ID";
                sqlCMD.Parameters.Add(new SQLiteParameter("@ID", nurseID));

                SQLiteDataReader sqlGet = sqlCMD.ExecuteReader();

                while (sqlGet.Read())
                {

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


        }
        // end Nurse Get
        // Delete Nurse
        public void deleteNurse(int nurID)
        {
            try
            {
                DBopen();
                SQLiteCommand sqlCMD;
                sqlCMD = con.CreateCommand();
                sqlCMD.CommandText = "DELETE FROM Nurse WHERE NurseID=@ID";
                sqlCMD.Parameters.Add(new SQLiteParameter("@ID", nurID));

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
        // End Delete Nurse
        // get a list of nurses from the database
        public List<string> ViewNurse(List<string> nurseList)
        {//not tested

            try
            {
                DBopen();
                SQLiteDataReader sqlGet;
                SQLiteCommand sqlCMD;
                sqlCMD = con.CreateCommand();
                sqlCMD.CommandText = "SELECT * FROM Nurse";
                sqlGet = sqlCMD.ExecuteReader();
                while (sqlGet.Read())
                {
                    string getNurse = sqlGet.GetString(9);
                    nurseList.Add(getNurse);
                }
            }
            catch
            {
                Console.WriteLine("View nurse catch");
            }
            finally { 
              DBClose();
            }
          
            return nurseList;



        }// end ViewNurse()
        public void UpdateNurse(int nID, string first, string mid, string last, int stat, int type, int dep, int clinic, string email, string notes)
        {
            try
            {
                DBopen();
                SQLiteCommand sqlUpdate;
                sqlUpdate = con.CreateCommand();
                sqlUpdate.CommandText = "UPDATE INTO Nurse WHERE nID=NurseID(NurseFName,NurseMName,NurseLName,NurseStatus,NurseType,NurseDepartment,NurseClinic,NurseEmail,NurseNotes)" +
                "VALUES(first,mid,last,stats,type,depart,clinic,email,notes);";
                sqlUpdate.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Catch Update nurse");
            }
            finally { 
                DBClose();
            }
           
        }
    }
}
