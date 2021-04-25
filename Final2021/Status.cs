using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Final2021
{/* Status Class
  * Insert Update view all
  * 
  */
    class Status : DBConnection
    {
        string statusType;
        int statusID;
        // Empty default Constructor
        public Status() { }
        // Full Constructor
        public Status(string status, int statusID)
        {
            this.statusType = status;
            this.statusID = statusID;
        }
        // Constructor for only statusType
        public Status(string status)
        {
            this.statusType = status;

        }
        public string StatusType { get => statusType; set => statusType = value; }
        public int StatusID { get => statusID; set => statusID = value; }
        /* InsertStatus
         * Insert a new status into the DB
         */
        public void InsertStatus(string sType)
        {

            try
            {
                DBopen();
                SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO Status(StatusType)VALUES(@type)", con);
                insertCommand.Parameters.Add(new SQLiteParameter("type",StatusType));
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
        }// END insert status

        /* ViewStatus
         * Return a List of ALL status items
         * 
         */
        
        public List<string> ViewStatus(List<string> statusList)
        {
            try
            {
                DBopen();
                SQLiteDataReader sqlGet;
                SQLiteCommand sqlCMD;
                sqlCMD = con.CreateCommand();
                sqlCMD.CommandText = "SELECT * FROM Status";
                sqlGet = sqlCMD.ExecuteReader();
                while (sqlGet.Read())
                {
                    string getStatus = sqlGet.GetString(11);
                    statusList.Add(getStatus);
                }
            }
            catch
            {
                Console.WriteLine("View Status catch");
            }
            DBClose();
            return statusList;
        }// end ViewStatus()
        /* UpdateStatus
         * Update status by ID
         */
        public void UpdateStatus(int statusID, string sType)
        {

            try
            {
                DBopen();
                SQLiteCommand sqlUpdate = new SQLiteCommand("UPDATE Status SET StatusType=@type WHERE StatusID=@iD", con);
                sqlUpdate.Parameters.Add(new SQLiteParameter("@iD",statusID));
                sqlUpdate.Parameters.Add(new SQLiteParameter("@type",sType));
            

                sqlUpdate.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                DBClose();
                
            }

        }//END UpdateStatus
    }//END class
}
