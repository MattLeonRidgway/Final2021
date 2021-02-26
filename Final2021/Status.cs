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
        // Full Constructor
        public Status(string status, int statusID){
            this.statusType = status;
            this.statusID = statusID;
        }
        // Constructor for only statusType
        public Status(string status){
            this.statusType = status;
            
        }
        public string StatusType { get => statusType; set => statusType = value; }
        public int StatusID { get => statusID; set => statusID = value; }
        // Insert into database statusType TESTED WORKING
        public void InsertStatus(string sType)
        {
           
            try{ 
                DBopen();
                SQLiteCommand insertCommand= new SQLiteCommand("INSERT INTO Status(StatusType)VALUES(?)",con);                
                insertCommand.Parameters.AddWithValue(sType, StatusType);
                insertCommand.ExecuteNonQuery();
            }
            catch (Exception e){
                throw new Exception(e.Message);              
            }
            finally{ 
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
                SQLiteCommand sqlUpdate =new SQLiteCommand("UPDATE Status SET [Type]=@type WHERE [StatusID]=@typeID",con);
              
                sqlUpdate.Parameters.Add(new SQLiteParameter("@typeID"));
                sqlUpdate.Parameters.Add(new SQLiteParameter("@type"));
                sqlUpdate.Parameters["@typeID"].Value = statusID;
                sqlUpdate.Parameters["@type"].Value = sType;

                sqlUpdate.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                throw e;
            }
            finally
            {
                DBClose();
            }
          
        }
    }
}
