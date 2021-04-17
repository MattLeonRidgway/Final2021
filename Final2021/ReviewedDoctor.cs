using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;


namespace Final2021
{/*
  * Class that can call DBconnection top open and close connection to the database
  * Get a List of Doctors and another List of Doctors to be selected to be the reviewer
  * Shuffle both lists
  * Loop and Pair the two lists if no pair delete from database and start over
  * Check if paired before, or if doctor is the same as reviewer 
  */
  class ReviewedDoctor: DBConnection
    {
        // Used for Shuffle
        Random ranD = new Random();
        // List for viewing
        public List<String> reviewedList = new List<String>();
        DoctorClass doctorClass = new DoctorClass();     
        
        /* BuildList:
         * reviewedList is used for viewing
         * Get both doctor and reviewer EMAIL
         * Save as string doctor save add to list and send to InsertSaved         * 
         */
        public List<String> BuildList(int docID, int reviewedBy)
        {// Get email for each doctor
            String docEmail = GetDoctor(docID);
            String revEmail = GetDoctor(reviewedBy);
            String doctorSave = "Doctor " + docEmail + " Reviewed By " + revEmail;

           // add to list for viewing
            reviewedList.Add(doctorSave);
            
            //Insert into table
            InsertSaved(doctorSave);
            //return the list that will be viewed
            return reviewedList;
        }// END BuildList

       /* GetDoctor:
        * Used to get the EMAIL for a doctor
        * returns EMAIL
        */
        public string GetDoctor(int docID)
        {// Used to get the doctors email
            String docEmail = "";          
            // get the doctor using ID
            try
            {// SQL statement
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
        // END get doctor

        /* InsertReviewed:
         * Passed in Doctor ID, Department ID, The Other Doctor ID is the selected reviewed doctor (reviewedBYID)
         * Used to insert 
         */
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

        }// END InsertReviewed        
      
        /* GetReviewedByDoctor:
         * Build a list of doctors that have reviewed the selected doctor.
         * Passed in Department ID and Doctor ID
         */
        public List<int> GetReviewedByDoctor(int docID, int departID)
        {
            // List of doctors that have reviewed the selected doctor.
            List<int> reviewedDoc = new List<int>();
            try
            {// SQL 
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
        }// END getReviewed By Doctor List    
        
        /* GetSaved:
         * Build a List of doctors from SavedReview Showing ALL current and OLD
         * Doctors and the dates from the table SaveReview 
         */
        public List<String> GetSaved()
        {
            List<String> reviewedList = new List<String>();
            int doctorInt = 1;// DoctorInt is used for doctors =1 and Nurse =0 
            try
            {// SQL select and where
                DBopen();
                SQLiteCommand sqlCMD;
                sqlCMD = con.CreateCommand();
                sqlCMD.CommandText = "SELECT * FROM SaveReview WHERE SavedDoctor=@doc";                             
                sqlCMD.Parameters.Add(new SQLiteParameter("@doc", doctorInt));
                SQLiteDataReader sqlGet = sqlCMD.ExecuteReader();
                while (sqlGet.Read())
                {                  
                    string getDoc = sqlGet.GetString(1);
                    string getDate = sqlGet.GetString(4); 
                    // Build the list of all doctors and dates
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
        }// END GetSaved

        /* CheckReviewed:
         *  Uses Department ID to build two Lists
         *  Shuffles both list by sending Lists to Shuffle
         *  Pair:
         *  For loop check that a Doctor can't review themselves OR have been reviewed by doctor selected
         *  IF doctor is the same doctor break the for loop Bool =False
         *  ELSE IF the doctor has been paired with the selected doctor break the for loop call DeleteDepartment Bool =False
         *  IF bool is false call CheckReviewed 
         *  ELSE Good Call ListLoop sending the two lists and Department ID
         */

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
                    // USED for debugging    
                    //Console.WriteLine("------------Same DOCTOR----------------");
                        break;                 
                   }
             
                else if (reviewList.Contains(reviewSelected)==true) {
                    check = false;
                   // USED for debugging
                    // Console.WriteLine("-----------------------------Delete called ------------------- Done");
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
                // USED for debugging
                //Console.WriteLine("Calling Loop List");
                ListLoop(doctorList, revList, departID);
            }
          
                 
     return reviewedList;
        }// END CheckReviewed

        /* ListLoop: 
         * After pairing is done ListLoop is called
         * For loop to loop through two lists 
         * At each count add to BuildList and InsertReviewed
         */
        public void ListLoop(List<int> dList, List<int> rList, int departID) {
            // Used for debugging
            // Console.WriteLine("The list size for the FOR LOOP is "+dList.Count);
            for (int count = 0; count < dList.Count; count++)
            {  // Loop through two Lists and call InsertReviewed and build List
                Console.WriteLine("Count is "+count);
                int doc = dList[count];
                int rev = rList[count];
                // USED for debugging
                //Console.WriteLine("The list size is " + dList.Count);
              
                BuildList(doc, rev);
                InsertReviewed(doc, departID, rev);
            }

        }// END ListLoop
    
        /* Shuffle:
         * Get a list in and shuffle
         * Return shuffled list
         */
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
        }// END shuffle

        /*  InsertSaved:
         *  uses two inserts one that is commented out and the other is passed to SavedClass InsertSaved
         *   For doctors the doc =1 and nurse =0
         */       
        public void InsertSaved(String revAnd) {
            // String used to get the month and year
            string sDate = "Date Added: " + DateTime.Now.ToString("MMMM", CultureInfo.InvariantCulture) + " " + DateTime.Now.Year.ToString();
            // For doctors doc=1 nurse=0
            int doctorInt = 1;
            int nurseInt = 0;
            int saveID = 1;
            SavedClass saveClass = new SavedClass();
            // Send to insert saved 
            saveClass.InsertSaved(saveID,revAnd,doctorInt,nurseInt,sDate);

            /* Commented out to use LINQ saveClass.InsertSaved(saveID,revAnd,doctorInt,nurseInt,sDate);
            *try
            *{// INSERT SQL
            *    DBopen();
            *    SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO [SavedReview] (SavedReviewed, SavedDoctor, SavedNurse, SavedDate)" +
            *       "VALUES(@savedRev,@savedDoc,@savedNur,@savedDate)", con);
            *    // Parameters
            *    insertCommand.Parameters.Add(new SQLiteParameter("@savedRev", revAnd));
            *    insertCommand.Parameters.Add(new SQLiteParameter("@savedDoc", doctorInt));
            *    insertCommand.Parameters.Add(new SQLiteParameter("@savedNur", nurseInt));
            *    insertCommand.Parameters.Add(new SQLiteParameter("@savedDate", sDate));
            *
            *    // Execute 
             *   insertCommand.ExecuteNonQuery();
           * }//end try
            *catch (SQLiteException e)
            *{
            *    throw new Exception(e.Message);
            *}
            *finally
            *{
            *    DBClose();
            *} 
             *END comment
             */

        }


        /* Delete Department:
        * When pairing up doctors and no pair can be made
        * Delete from the database
        */
        public void DeleteDepartment(int departID)
        {
            try
            {// SQL delete statement
               DBopen();
                SQLiteCommand sqlCMD;
                sqlCMD = con.CreateCommand();
                sqlCMD.CommandText = "DELETE FROM ReviewedDoctor WHERE ReviewedDepartment=@ID";
                sqlCMD.Parameters.Add(new SQLiteParameter("@ID", departID));
                sqlCMD.ExecuteNonQuery();
                // USED for debug
                // Console.WriteLine("--------------INSIDE DELETE---------------------------------------------------------");
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

    }// END CLASS
}
