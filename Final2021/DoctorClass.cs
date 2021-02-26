using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    class DoctorClass :DBConnection
    {
        string fName, mName, lName, email, notes;
        char sex;
        int status, type, department, clinic;          
        public DoctorClass() { }

        public DoctorClass(string fName, string mName, string lName, string email, string notes, char sex, int status, int type, int department, int clinic){

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

       public void InsertDoctor(string first, string mid, string last, char sex, int stat, int type, int dep, int clinic, string email, string notes){

            try
            {
                DBopen();
                SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO Doctor(DoctorFName, DoctorMName, DoctorLName, DoctorSex,DoctorStatus," +
                    "DoctorType, DoctorDepartment,DoctorClinic, DoctorEmail,DoctorNotes)VALUES(?,?,?,?,?,?,?,?,?,?)", con);
                insertCommand.Parameters.AddWithValue(first, FName);
                insertCommand.Parameters.AddWithValue(mid, MName);
                insertCommand.Parameters.AddWithValue(last, LName);
                insertCommand.Parameters.AddWithValue(sex.ToString(), Sex);
                insertCommand.Parameters.AddWithValue(type.ToString(), Type);
                insertCommand.Parameters.AddWithValue(dep.ToString(), Department); 
                insertCommand.Parameters.AddWithValue(clinic.ToString(),Clinic); 
                insertCommand.Parameters.AddWithValue(email, Email);
                insertCommand.Parameters.AddWithValue(notes, Notes);

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
        // get a list of doctors from the database
        public List<string> ViewDoctor(List<string> doctorsList)
        {  
           
            try{
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
            catch {
                Console.WriteLine("View Doctors catch");
            }
            DBClose();
            return doctorsList;           


        }// end ViewDoctor()
        public void UpdateDoctor(int dID, string first, string mid, string last, char sex, int stat, int type, int dep, int clinic, string email, string notes) {

            try{
                DBopen();
                SQLiteCommand sqlUpdate;
                sqlUpdate =con.CreateCommand();
                sqlUpdate.CommandText = "UPDATE INTO doctor WHERE dID=DoctorID(DoctorFName,DoctorMName,DoctorLName,DoctorSex,DoctorStatus,DoctorType,DoctorDepartment,DoctorClinic,DoctorEmail,DoctorNotes) " +
                "VALUES(first,mid,last,sex,stats,type,depart,clinic,email,notes);";
                sqlUpdate.ExecuteNonQuery();
            }
            catch { 
            
            }
            DBClose();
            
        }
    }
}
