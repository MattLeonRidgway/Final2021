using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;


namespace Final2021
{/* ReviewedNurse
  * Pair up a nurse by department and Type
  * Insert into DB
  */
    class ReviewedNurse: DBConnection
    {
      
        // Create a random number generator
        Random ranD = new Random();
        // connect to the NurseClass
        NurseClass nurseClass = new NurseClass();
        // reviewedList
        public List<String> reviewedList = new List<String>();
        /* Shuffle
         * Put a List in and the list get's shuffled
         */
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

        /* BuildList
         * Get a Nurse by IDS and show the nurse Email from Nurse table for nurse and reviewed by nurse
         */
        public List<String> BuildList(int nurID, int reviewedBy)
        {// Get email for each nurse
            String nurseEmail = GetNurse(nurID);
            String revEmail = GetNurse(reviewedBy);
            String nurseSave = "Nurse " + nurseEmail + " Reviewed By " + revEmail;
            // add to list for viewing
            reviewedList.Add(nurseSave);
          
            //Insert into saved
            InsertSaved(nurseSave);
            //return the list that will be viewed
            return reviewedList;
        }// END BuildList
        /* GetNurse
         * Put nurse ID in and get the email address
         */
        public string GetNurse(int nurseID)
        {// Get email for nurse
            String nurseEmail = "";
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
                    nurseEmail = sqlGet.GetString(8);
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
            return nurseEmail;
        }
        // End get nurse
        /* GetSaved
         * Get a List from SAVED 
         */
        public List<String> GetSaved()
        {
            // List of nurses a in saved.
            List<String> reviewedList = new List<String>();
            int nurseInt = 1;
            try
            {
                DBopen();
                SQLiteCommand sqlCMD;
                sqlCMD = con.CreateCommand();
                sqlCMD.CommandText = "SELECT * FROM SaveReview WHERE SavedNurse=@nur";

                sqlCMD.Parameters.Add(new SQLiteParameter("@nur", nurseInt));


                SQLiteDataReader sqlGet = sqlCMD.ExecuteReader();
                while (sqlGet.Read())
                {// get reviewed by doctors

                    string getNurse = sqlGet.GetString(1);
                    string getDate = sqlGet.GetString(4);
                    reviewedList.Add(getNurse + " " + getDate);
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
        }// END get Nurse List from saved
        
        /* InsertReviewed
         * Insert a new nurse
         */
        public void InsertReviewed(int nurseID, int departID, int reviewedBYID, int nurseType)
        {
            // Insert into the DB
            try
            {// the INSERT SQL statement
                DBopen();
                SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO [ReviewedNurse] (ReviewedNurseID, ReviewedDepartment, ReviewedByNurseID, ReviewedNurseType)VALUES(@ID, @depart, @ByID, @type)", con);
                // Parameters
                insertCommand.Parameters.Add(new SQLiteParameter("@ID", nurseID));
                insertCommand.Parameters.Add(new SQLiteParameter("@depart", departID));
                insertCommand.Parameters.Add(new SQLiteParameter("@ByID", reviewedBYID));
                insertCommand.Parameters.Add(new SQLiteParameter("@type", nurseType));
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

        }// END insert into reviewedNurse
        
        /* GetReviewedByNurse
         * List of nurses that have reviewed selected nurse 
        */
        public List<int> GetReviewedByNurse(int nurseID, int departID)
        {
            // List of nurses that have reviewed the selected nurse.
            List<int> reviewedNurse = new List<int>();
            try
            {
                DBopen();
                SQLiteCommand sqlCMD;
                sqlCMD = con.CreateCommand();
                sqlCMD.CommandText = "SELECT * FROM ReviewedNurse WHERE ReviewedDepartment=@departID AND ReviewedNurseID=@nurseID";
                sqlCMD.Parameters.Add(new SQLiteParameter("@departID", departID));
                sqlCMD.Parameters.Add(new SQLiteParameter("@nurseID", nurseID));
                SQLiteDataReader sqlGet = sqlCMD.ExecuteReader();
                while (sqlGet.Read())
                {// get reviewed by nurse
                    reviewedNurse.Add(sqlGet.GetInt32(3));
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
            return reviewedNurse;
        }// END getReviewed By nurse List    
        /* CheckReviewed:
         * Pair up nurse check if paired before or paired with the same nurse
         * 
         */
        // check departId and type for a list of nurses
        public List<String> CheckReviewed(int departID, int type)
        {// Clear the list
            reviewedList.Clear();
            // Make 2 lists of nurse by department ID and type THEY are the same size
            List<int> nurseList = nurseClass.ListIntNurse(departID,type);
            List<int> revList = nurseClass.ListIntNurse(departID,type);

            //Shuffle two lists
            Shuffle(nurseList);
            Shuffle(revList);
            bool check = true;
            // Loop through the two list's create pairing

            for (int count = 0; count < nurseList.Count; count++)
            {// use index of count for each list
                int nurseSelected = nurseList[count];
                int reviewSelected = revList[count];
                // Build list of nurses THAT HAVE reviewed the Selected nurse
                List<int> reviewList = GetReviewedByNurse(nurseSelected, departID);
                // If nurse and reviewer are the same call and start over
                if (nurseSelected == reviewSelected)
                {
                    check = false;
                    // Used for debugging
                   // Console.WriteLine("------------Same NURSE SELECTED----------------");
                    break;
                }
                
                //else if (reviewList.Exists(p=>p.Equals(reviewSelected))==true) { 
                else if (reviewList.Contains(reviewSelected) == true)
                {
                    check = false;
                   // Console.WriteLine("-----------------------------Delete called ------------------- Done");
                    DeleteDepartment(departID);
                    reviewedList.Clear();

                    break;
                }
            }//end For LOOP through two lists
            if (check == false)
            {
                CheckReviewed(departID, type);
            }
            else
            {
             //   Console.WriteLine("Calling Loop List");
                ListLoop(nurseList, revList, departID, type);
            }
            return reviewedList;
        }// END
        
        /* ListLoop
         * Loop both lists send to BuildList and InsertReviewed
         */
        public void ListLoop(List<int> nList, List<int> rList, int departID, int type)
        {//Used for debug
            //Console.WriteLine("The list size for the FOR LOOP is " + nList.Count);
            for (int count = 0; count < nList.Count; count++)
            {
               // Console.WriteLine("Count is " + count);
                int nur = nList[count];
                int rev = rList[count];
               // Console.WriteLine("The list size is " + nList.Count);
                // Loop through two Lists and call InsertReviewed and build List
                BuildList(nur, rev);
                InsertReviewed(nur, departID, rev, type);
            }

        }//END
        /* INSERT saved
         * UPDATE to LINQ
         */
        // Used to insert the reviews so that they are saved current and OLD
       
        public void InsertSaved(String revAnd)
        {
            string sDate = "Date Added: " + DateTime.Now.ToString("MMMM", CultureInfo.InvariantCulture) + " " + DateTime.Now.Year.ToString();
            //for nurse doc=0 nurs=1
            int doctorInt = 0;
            int nurseInt = 1;
            int saveID = 1;// Saved for LINQ ID not used for anything else
            SavedClass saveClass = new SavedClass();
            // Send to insert saved 
            saveClass.InsertSaved(saveID, revAnd, doctorInt, nurseInt, sDate);
            /*
             * NOT USED LINQ instead
            try
            {
                DBopen();
                SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO [SaveReview] (SavedReviewed, SavedDoctor, SavedNurse, SavedDate)" +
                   "VALUES(@savedRev,@savedDoc,@savedNur,@savedDate)", con);
                // Parameters
                insertCommand.Parameters.Add(new SQLiteParameter("@savedRev", revAnd));
                insertCommand.Parameters.Add(new SQLiteParameter("@savedDoc", doctorInt));
                insertCommand.Parameters.Add(new SQLiteParameter("@savedNur", nurseInt));
                insertCommand.Parameters.Add(new SQLiteParameter("@savedDate", sDate));

                // Execute 
                insertCommand.ExecuteNonQuery();
            }//end try
            catch (SQLiteException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                DBClose();
            }*/

        }

        /*Delete Department
         *  Delete by department ID
         */
        public void DeleteDepartment(int departID)
        {// When the nurse can't be paired up anymore delete data in table BY department
            try
            {
                DBopen();
                SQLiteCommand sqlCMD;
                sqlCMD = con.CreateCommand();
                sqlCMD.CommandText = "DELETE FROM ReviewedNurse WHERE ReviewedDepartment=@ID";
                sqlCMD.Parameters.Add(new SQLiteParameter("@ID", departID));
                sqlCMD.ExecuteNonQuery();
                //debug
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

        }//END Delete department 

    }// END CLASS
}
