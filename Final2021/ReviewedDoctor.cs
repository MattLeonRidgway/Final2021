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
        int rev;
        List<String> reviewedList = new List<String>();
        DoctorClass doctorClass = new DoctorClass();
        DBConnection dbClass = new DBConnection();
        List<int> docRev = new List<int>();

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
        public List<String> BuildList(int docID, int reviewedBy, int departmentID)
        {
            String docEmail = getDoctor(docID);
            String revEmail = getDoctor(reviewedBy);
           
            reviewedList.Add("Doctor " + docEmail + " Reviewed By " + revEmail);
            InsertReviewed(docID, reviewedBy, departmentID);
            return reviewedList;

        }
        // Get doctor
        public string getDoctor(int docID)
        {
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
        public Boolean checkPair(List<int> doctorList, List<int> doctorRev) {
         
            for (int count = 0; count <= doctorList.Count; count++) {
                // get first, remove and check pair
               int docOne= doctorList.First();
               int docTwo = doctorRev.First();

                doctorList.RemoveAt(1);
                doctorRev.RemoveAt(1);
              // check if pair is same
                if (docOne == docTwo)
                {  // Same
                    return false;
                }
                
            }
            return true;
        }// end checkPair
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
        {
            reviewedList.Clear();
            // Get 2 lists of doctors by department ID
            List<int> doctorList = doctorClass.ListIntDoctor(departID);          
            List<int> revList = doctorClass.ListIntDoctor(departID);
            Shuffle(doctorList);
            Shuffle(revList);
            bool checkTF = false;

            int listSize = doctorList.Count;
            
            // IF checkPair is good
            if (checkPair(doctorList,revList)){
             
                    var newList = doctorList.Zip(revList, (d, r) => new{ Doc=d, Rev=r  });
                    foreach (var value in newList)
                    {
                       int doctorSelected = value.Doc;
                       int reviewSelected = value.Rev;

                        // Build list of doctors THAT HAVE reviewed doctorSelected
                        List<int> reviewList = GetReviewedByDoctor(doctorSelected, departID);
                    if (doctorSelected == reviewSelected)
                    {
                        CheckReviewed(departID);
                    }
                    else {                   
                 
                        if (checkList(reviewList, reviewSelected))
                        {
                            //if in list call again to start over
                            CheckReviewed(departID);
                        }
                        else
                        { //else build
                            checkTF = true;
                            // BuildList will return reviewedList
                            BuildList(doctorSelected, reviewSelected, departID);

                        }
                    }// end ELSE ==
                }//end ForEach
               // }// end FOR looping through the two lists
                         
              // if checkTF still equals false delete, clear and call again
              if (checkTF==false) {
                    DeleteDepartment(departID);
                    Console.WriteLine("Deleted Done");
                    reviewedList.Clear();
                    CheckReviewed(departID);
                }   
            }// end if checkPair        
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
