using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final2021
{
  class ReviewedDoctor 
    {
        int doctorID;
        int reviewedByDoctorID;
        int reviewedDepartmentID;
   
        List<String> reviewedList = new List<String>();
        DoctorClass doctorClass = new DoctorClass();
        DBConnection dbClass = new DBConnection();
        List<int> docRev = new List<int>();
        List<int> dbList = new List<int>();

        Random ranD = new Random();
        // Default
        public ReviewedDoctor() { }
        public int DoctorID { get => doctorID; set => doctorID = value; }
        public int ReviewedByDoctorID { get => reviewedByDoctorID; set => reviewedByDoctorID = value; }
        public int ReviewedDepartmentID { get => reviewedDepartmentID; set => reviewedDepartmentID = value; }

        public ReviewedDoctor(int doctorID, int reviewedByDoctorID, int reviewedDepartmentID)
        {
            this.doctorID = doctorID;
            this.reviewedByDoctorID = reviewedByDoctorID;
            this.reviewedDepartmentID = reviewedDepartmentID;
        }

        // Get a List of Doctors by IDS and show the Doctors Email from Doctor table for doctor and reviewed by doctor
        public List<String> BuildList(int docID, int reviewedBy, int departmentID, List<int> docList, List<int> revList)
        {
            String docEmail = getDoctor(docID);
            String revEmail = getDoctor(reviewedBy);
            DoctorID = docID;
            ReviewedDepartmentID = departmentID;
            ReviewedByDoctorID = reviewedBy;
           // add to list for viewing
            reviewedList.Add("Doctor " + docEmail + " Reviewed By " + revEmail);
            // insert into DB IF the reviewed list is the same size
            if (reviewedList.Count ==docList.Count) {
                for (int count=0; count<docList.Count; count++) {
                    int doc = docList[count];
                    int rev = revList[count];
                    // Loop through two Lists and call InsertReviewed
                    InsertReviewed(doc, rev, departmentID);
                }              
           
            }
            
            //return the list for viewing
            return reviewedList;

        }
        // Get doctor
        public string getDoctor(int docID)
        {// Used to get the doctors email
            String docEmail = "";          
            // get the doctor using ID
            try
            {
                dbClass.DBopen();
                SQLiteCommand sqlCMD;
                sqlCMD =dbClass.con.CreateCommand();
                sqlCMD.CommandText = "SELECT * FROM Doctor WHERE DoctorID=@ID";
                sqlCMD.Parameters.Add(new SQLiteParameter("@ID", docID));
                
                SQLiteDataReader sqlGet = sqlCMD.ExecuteReader();

                while (sqlGet.Read())
                {                  
                   docEmail = sqlGet.GetString(8);                   
                }
            }//end try
            catch (SQLiteException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
               dbClass.DBClose();
            }
            return docEmail;

        }
        // End get doctor
        // INSERT the doctors being reviewed by Doctor into table ReviewedDoctor
        public void InsertReviewed(int docID, int departID, int reviewedBYID)
        {
            // Insert into the DB
            try
            {// the INSERT SQL statement
                dbClass.DBopen();
                SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO [ReviewedDoctor] (ReviewedDoctorID, ReviewedDepartment, ReviewedByDoctorID)"+
                   "VALUES(@ID,@depart,@ByID)", dbClass.con);
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
                dbClass.DBClose();
            }

        }
        
        //Get's a list of the Doctors that have reviewed the selected doctor and department 
        public List<int> GetReviewedByDoctor(int docID, int departID)
        {
            // List of doctors that have reviewed the selected doctor.
            List<int> reviewedDoc = new List<int>();
            try
            {
                dbClass.DBopen();
                SQLiteCommand sqlCMD;
                sqlCMD = dbClass.con.CreateCommand();
                sqlCMD.CommandText = "SELECT * FROM ReviewedDoctor WHERE ReviewedDepartment=@departID AND ReviewedDoctorID=@docID";
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
                dbClass.DBClose();
            }
            return reviewedDoc;
        }
        // end getReviewed By Doctor List
    
       
        // check departId for a list of doctors
        public List<String> CheckReviewed(int departID)
        {// Clear the list
            reviewedList.Clear();
            // Get 2 lists of doctors by department ID THEY are the same size
            List<int> doctorList = doctorClass.ListIntDoctor(departID);          
            List<int> revList = doctorClass.ListIntDoctor(departID);
            //Shuffle list
            Shuffle(doctorList);
            Shuffle(revList);
            bool checkTF = false;
        // Loop through the two list's
                for (int count=0; count<doctorList.Count; count++)
                {// get the index of count for each list
                    int doctorSelected = doctorList[count];
                    int reviewSelected = revList[count];
                    // Build list of doctors THAT HAVE reviewed doctorSelected
                    List<int> reviewList = GetReviewedByDoctor(doctorSelected, departID);
                // If doctor and reviewer are the same loop again
                    if (doctorSelected == reviewSelected)
                    {    checkTF = false;
                        CheckReviewed(departID);                
                    }
                    else
                    {
                    // Check to see if the reviewList has been reviewed by the reviewSelected
                        if (checkList(reviewList, reviewSelected))
                        {
                            checkTF = false;
                            //if in list call again to start over
                            CheckReviewed(departID);                            
                        }
                        else
                        { //else build
                            checkTF = true;
                            // BuildList will return reviewedList
                            BuildList(doctorSelected, reviewSelected, departID, doctorList, revList);
                        }
                    }// end ELSE ==
                }//end For LOOP through two lists
                // if checkTF still equals false delete, clear and call again
                // This means that the doctor can't be reviewed because the doctor has been reviewed by all other doctors
                if (checkTF == false)
                {
                    DeleteDepartment(departID);
                // used to see when false
                    Console.WriteLine("Deleted Done");
                    CheckReviewed(departID);
                }          
           
     return reviewedList;
        }
   
        public Boolean checkList(List<int> check, int id)
        {// Check if doctor (id) is in check
            if (check.Contains(id))
            {
                return true;
            }
            else {
                return false;
            }
        }
        // randomize list 
        public void Shuffle(List<int> list)
        {
            int count = list.Count;
            while (count > 1)
            {
                count--;
                int saveNum = ranD.Next(count + 1);
                int value = list[saveNum];
                list[saveNum] = list[count];
                list[count] = value;
            }
        }
        // Delete Department
        public void DeleteDepartment(int departID)
        {// When the doctors can't be paired up anymore delete data in table BY department
            try
            {
                dbClass.DBopen();
                SQLiteCommand sqlCMD;
                sqlCMD = dbClass.con.CreateCommand();
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
                dbClass.DBClose();
            }

        }//End Delete department 

    }
}
