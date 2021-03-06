using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Final2021
{
    class NurseClass : DBConnection
    {
        string fName, mName, lName, email, notes;
        char sex;
        int status, type, department, clinic;
        //Empty constructor
        public NurseClass() { }

        public NurseClass(string fName, string mName, string lName, string email, string notes, char sex, int status, int type, int department, int clinic)
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

        public void InsertNurse(string first, string mid, string last, char sex, int stat, int type, int dep, int clinic, string email, string notes)
        {


            try
            {
                DBopen();
                SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO [Nurse] (NurseFName, NurseMName, NurseLName, NurseSex, NurseStatus," +
                    "NurseType, NurseDepartment, NurseClinic, NurseEmail, NurseNotes)" +
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
        }// end insert nurse
        // get a list of nurses from the database
        public List<string> ViewNurse(List<string> nurseList)
        {

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
                    string getNurse = sqlGet.GetString(11);
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
        public void UpdateNurse(int nID, string first, string mid, string last, char sex, int stat, int type, int dep, int clinic, string email, string notes)
        {
            try
            {
                DBopen();
                SQLiteCommand sqlUpdate;
                sqlUpdate = con.CreateCommand();
                sqlUpdate.CommandText = "UPDATE INTO Nurse WHERE nID=NurseID(NurseFName,NurseMName,NurseLName,NurseSex,NurseStatus,NurseType,NurseDepartment,NurseClinic,NurseEmail,NurseNotes)" +
                "VALUES(first,mid,last,sex,stats,type,depart,clinic,email,notes);";
                sqlUpdate.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Catch Update nurse");
            }
            DBClose();
        }
    }
}
