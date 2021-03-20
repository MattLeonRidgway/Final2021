using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final2021
{
    class ReviewedDoctor : DBConnection 
    {
        int doctorID;
        int reviewedByDoctorID;
        int reviewedDepartmentID;
        List<String> reviewedList = new List<String>();
        DoctorClass doctorClass = new DoctorClass();
        List<int> docRev = new List<int>();
        private Random ranD = new Random();
        public ReviewedDoctor() { }
        public ReviewedDoctor(int doctorID, int reviewedByDoctorID, int reviewedDepartmentID)
        {
            this.doctorID = doctorID;
            this.reviewedByDoctorID = reviewedByDoctorID;
            this.reviewedDepartmentID = reviewedDepartmentID;
        }

        public int DoctorID { get => doctorID; set => doctorID = value; }
        public int ReviewedByDoctorID { get => reviewedByDoctorID; set => reviewedByDoctorID = value; }
        public int ReviewedDepartmentID { get => reviewedDepartmentID; set => reviewedDepartmentID = value; }
        // Get a List of Doctors by IDS and show the Doctors Email from Doctor table for doctor and reviewed by doctor
        public List<String> BuildList(int docID, int reviewedBy, int departmentID)
        {
            String doc = "";
            String rev = "";
            try
            {
                DBopen();
                SQLiteCommand sqlCMD;
                sqlCMD = con.CreateCommand();
                sqlCMD.CommandText = "SELECT * FROM Doctor WHERE DoctorID=@docID";
                sqlCMD.Parameters.Add(new SQLiteParameter("@docID", docID));
                SQLiteDataReader sqlGetDoc = sqlCMD.ExecuteReader();
                //Get email for doc
                while (sqlGetDoc.Read())
                {
                    doc = sqlGetDoc.GetString(8);
                }
                sqlCMD.CommandText = "SELECT * FROM Doctor WHERE DoctorID=@docID";
                sqlCMD.Parameters.Add(new SQLiteParameter("@docID", reviewedBy));
                SQLiteDataReader sqlGet = sqlCMD.ExecuteReader();
                // Get email of reviewedBy doc
                while (sqlGet.Read())
                {
                    rev = sqlGet.GetString(8);
                }
            }//end try
            catch (SQLiteException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                DBClose();
                reviewedList.Add("Doctor " + doc + " Reviewed By " + rev);
                InsertReviewed(docID,reviewedBy,departmentID);
            }
            return reviewedList;

        }
        // INSERT the doctors being reviewed by Doctor into table ReviewedDoctor
        public void InsertReviewed(int docID, int departID, int reviewedBYID)
        {

            try
            {// the INSERT SQL statement
                DBopen();
                SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO [ReviewedDoctor] (ReviewedDoctorID, ReviewedDepartment, ReviewedByDoctorID)" +
                   "VALUES(@ID,@depart,@ByID)", con);
                // Parameters
                insertCommand.Parameters.Add(new SQLiteParameter("@ID", docID));
                insertCommand.Parameters.Add(new SQLiteParameter("@depart", departID));
                insertCommand.Parameters.Add(new SQLiteParameter("@ByID", reviewedBYID));

                // Execute 
                insertCommand.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            { // SQL Exception catch
                throw new Exception(e.Message);
            }
            finally
            { // Finally close DB
                DBClose();
            }

        }
        //Get's a list of the Doctors that have reviewed the selected doctor and department 
        public List<int> GetReviewedByDoctor(int docID, int departID)
        {
            // List of doctors that have reviewed the selected doctor.
            List<int> reviewedDoc = new List<int>();
            try
            {
                DBopen();
                SQLiteCommand sqlCMD;
                sqlCMD = con.CreateCommand();
                sqlCMD.CommandText = "SELECT * FROM ReviewedDoctor WHERE ReviewedDepartment=@departID, AND ReviewedDoctor=@docID";
                sqlCMD.Parameters.Add(new SQLiteParameter("@departID", departID));
                sqlCMD.Parameters.Add(new SQLiteParameter("@docID", docID));

                SQLiteDataReader sqlGet = sqlCMD.ExecuteReader();

                while (sqlGet.Read())
                {
                    reviewedDoc.Add(sqlGet.GetInt32(3));


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
            return reviewedDoc;
        }
        // end getReviewed By Doctor List
        // check departId for a list of doctors
        public void CheckReviewed(int departID)
        {
            // Get a list of doctors by department ID
            List<int> doctorList = doctorClass.ListIntDoctor(departID);
            List<int> reviewList = new List<int>();
            // shuffle list
            Shuffle(doctorList);
            // take first out
            List<int> newDocList = doctorList;

            for (int count = 0; count < doctorList.Count; count++) // Loop through List with for
            {
                int docid = newDocList.IndexOf(0);
                newDocList.RemoveAt(0);
                Shuffle(newDocList);
                // Will get stuff if everyone has reviewed everyone.!!!!!
                int rev = checkList(doctorList, docid, departID);
                BuildList(docid, rev, departID);
            }
        }

        public int checkList(List<int> check, int id, int dep)
        {
            List<int> reviewedDoc = GetReviewedByDoctor(id, dep);
            int rev = check.IndexOf(0);
            // if in list shuffle and call checkList again
            if (reviewedDoc.Contains(rev))
            {
                Shuffle(check);
                checkList(check, id, dep);

            }
            
            return rev;
            


            
        }
        // randomize list 
        public void Shuffle<T>(this IList<T> list)
        {
            int count = list.Count;
            while (count > 1)
            {
                count--;
                int saveNum = ranD.Next(count + 1);
                T value = list[saveNum];
                list[saveNum] = list[count];
                list[count] = value;
            }
        }
        // Delete Department
        public void DeleteDepartment(int departID)
        {// When the doctors can't be paired up anymore delete data in table BY department
            try
            {
                DBopen();
                SQLiteCommand sqlCMD;
                sqlCMD = con.CreateCommand();
                sqlCMD.CommandText = "DELETE FROM ReviewedDoctor WHERE ReviewedDepartment=@ID";
                sqlCMD.Parameters.Add(new SQLiteParameter("@ID", departID));

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

        }//End Delete department 

    }
}
