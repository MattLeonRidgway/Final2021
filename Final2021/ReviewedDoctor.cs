using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Data.Linq;

namespace Final2021
{
  class ReviewedDoctor: DBConnection
    {
        
        Random ranD = new Random();
   
        public List<String> reviewedList = new List<String>();
        DoctorClass doctorClass = new DoctorClass();
      
        // Get a List of Doctors by IDS and show the Doctors Email from Doctor table for doctor and reviewed by doctor
        public List<String> BuildList(int docID, int reviewedBy)
        {// Get email for each doctor
            String docEmail = getDoctor(docID);
            String revEmail = getDoctor(reviewedBy);
  
           // add to list for viewing
            reviewedList.Add("Doctor " + docEmail + " Reviewed By " + revEmail);
            String doctorSave = "Doctor " + docEmail + " Reviewed By " + revEmail;
            //Insert into saved
            InsertSaved(doctorSave);
            //return the list that will be viewed
            return reviewedList;
        }
        // Get doctor
        public string getDoctor(int docID)
        {// Used to get the doctors email
            String docEmail = "";          
            // get the doctor using ID
            try
            {
                DBopen();
                SQLiteCommand sqlCMD;
                sqlCMD =con.CreateCommand();
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
               DBClose();
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
                DBopen();
                SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO [ReviewedDoctor] (ReviewedDoctorID, ReviewedDepartment, ReviewedByDoctorID)"+
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
                sqlCMD =con.CreateCommand();
                sqlCMD.CommandText = "SELECT * FROM ReviewedDoctor WHERE ReviewedDepartment=@departID AND ReviewedDoctorID=@docID";
                sqlCMD.Parameters.Add(new SQLiteParameter("@departID", departID));
                sqlCMD.Parameters.Add(new SQLiteParameter("@docID", docID));
                SQLiteDataReader sqlGet = sqlCMD.ExecuteReader();
                while (sqlGet.Read())
                {// get reviewed by doctors
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
        }// end getReviewed By Doctor List    
        public List<String> GetSaved()
        {
            // List of doctors that have reviewed the selected doctor.
            List<String> reviewedList = new List<String>();
            int doctorInt = 1;
            try
            {
                DBopen();
                SQLiteCommand sqlCMD;
                sqlCMD = con.CreateCommand();
                sqlCMD.CommandText = "SELECT * FROM SaveReview WHERE SavedDoctor=@doc";
                             
                sqlCMD.Parameters.Add(new SQLiteParameter("@doc", doctorInt));


                SQLiteDataReader sqlGet = sqlCMD.ExecuteReader();
                while (sqlGet.Read())
                {// get reviewed by doctors
                   
                    string getDoc = sqlGet.GetString(1);
                    string getDate = sqlGet.GetString(4); 
                    reviewedList.Add(getDoc+" "+getDate);
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
            return reviewedList;
        }// end get Doctor List    from saved

        // check departId for a list of doctors
        public List<String> CheckReviewed(int departID)
        {// Clear the list
            reviewedList.Clear();
            // Make 2 lists of doctors by department ID THEY are the same size
            List<int> doctorList = doctorClass.ListIntDoctor(departID);          
            List<int> revList = doctorClass.ListIntDoctor(departID);
            
            //Shuffle two lists
            Shuffle(doctorList);
            Shuffle(revList);
            bool check = true;
            // Loop through the two list's create pairing
   
                for (int count=0; count<doctorList.Count; count++)
                {// use index of count for each list
                    int doctorSelected = doctorList[count];
                    int reviewSelected = revList[count];
                    // Build list of doctors THAT HAVE reviewed doctorSelected
                    List<int> reviewList = GetReviewedByDoctor(doctorSelected, departID);
                // If doctor and reviewer are the same call and start over
                    if (doctorSelected == reviewSelected)
                    { 
                        check = false;
                        Console.WriteLine("------------Same DOCTOR----------------");
                        break;                 
                   }
                // else if (reviewList.Contains(reviewSelected)){ 
                //else if (reviewList.Exists(p=>p.Equals(reviewSelected))) { 
                else if (reviewList.Contains(reviewSelected)==true) {
                    check = false;
                    Console.WriteLine("-----------------------------Delete called ------------------- Done");
                    DeleteDepartment(departID);
                    reviewedList.Clear();
                       
                    break;
                    }                     
                }//end For LOOP through two lists
            if (check == false)
            {
                CheckReviewed(departID);
            }
            else { 
                Console.WriteLine("Calling Loop List");
                ListLoop(doctorList, revList, departID);
            }
          
                 
     return reviewedList;
        }
        public void ListLoop(List<int> dList, List<int> rList, int departID) {
            Console.WriteLine("The list size for the FOR LOOP is "+dList.Count);
            for (int count = 0; count < dList.Count; count++)
            {
                Console.WriteLine("Count is "+count);
                int doc = dList[count];
                int rev = rList[count];
                Console.WriteLine("The list size is " + dList.Count);
                // Loop through two Lists and call InsertReviewed and build List
                BuildList(doc, rev);
                InsertReviewed(doc, departID, rev);
            }

        }
    
        // randomize list 
        public void Shuffle(List<int> list)
        {// Used to shuffle the list
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
        public void InsertSaved(String revAnd) {
            string sDate = "Date Added: " + DateTime.Now.ToString("MMMM", CultureInfo.InvariantCulture) + " " + DateTime.Now.Year.ToString();
            //for doctors doc=1 nurs=0
            int doctorInt = 1;
            int nurseInt = 0;
            SavedClass saveClass = new SavedClass();
            saveClass.InsertSaved(revAnd,doctorInt,nurseInt,sDate);
            
            //try
            //{
            //    DBopen();
            //    SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO [SavedReview] (SavedReviewed, SavedDoctor, SavedNurse, SavedDate)" +
            //       "VALUES(@savedRev,@savedDoc,@savedNur,@savedDate)", con);
            //    // Parameters
            //    insertCommand.Parameters.Add(new SQLiteParameter("@savedRev", revAnd));
            //    insertCommand.Parameters.Add(new SQLiteParameter("@savedDoc", doctorInt));
            //    insertCommand.Parameters.Add(new SQLiteParameter("@savedNur", nurseInt));
            //    insertCommand.Parameters.Add(new SQLiteParameter("@savedDate", sDate));

            //    // Execute 
            //    insertCommand.ExecuteNonQuery();
            //}//end try
            //catch (SQLiteException e)
            //{
            //    throw new Exception(e.Message);
            //}
            //finally
            //{
            //    DBClose();
            //}

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
                //debug
                Console.WriteLine("--------------INSIDE DELETE---------------------------------------------------------");
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
