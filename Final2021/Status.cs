using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final2021
{
    class Status: DBConnection
    {
        string statusType;
        int statusID;    
        // Empty default Constructor
        public Status() { }

        public Status(string status, int statusID){
            this.statusType = status;
            this.statusID = statusID;
        }
        public Status(string status){
            this.statusType = status;
            
        }
        public string StatusType { get => statusType; set => statusType = value; }
        public int StatusID { get => statusID; set => statusID = value; }

        public void InsertStatus(string sType)
        {
           
           
               
            //insertCommand.Parameters.Add(sType,StatusType); 
            try
            { 
                DBopen();
                SQLiteCommand insertCommand= new SQLiteCommand("INSERT INTO Status(StatusType)VALUES(?)",con);
                
               insertCommand.Parameters.AddWithValue(sType, StatusType);
                insertCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message); 
              
            }
            finally { 
             DBClose();
            }

           
           
        }// end insert status
        // get a list of status 
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
       public void UpdateStatus(int statusID, string sType)
        {

            try
            {
                DBopen();
                SQLiteCommand sqlUpdate;
                sqlUpdate = con.CreateCommand();
                sqlUpdate.CommandText = "UPDATE INTO Status WHERE StatusID=StatusID(StatusType)" +
                "VALUES(sType);";
                sqlUpdate.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Catch Update status");
            }
            DBClose();
        }
    }
}
