using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Final2021
{/* DoctorType CLass:
  * Build a object
  * Insert a new type
  * Update by typeID
  * List of types
  * 
  */
    class DoctorType : DBConnection
    {
        int id;
        string type;
        public DoctorType() { }

        public DoctorType(int id, string type)
        {
            this.id = id;
            this.type = type;
        }
        public DoctorType(string type)
        {

            this.type = type;
        }

        public int Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        /* InsertDoctorType
         * Insert a new type
         * 
         */
        public void InsertDoctorType(string type)
        {
            try
            {
                DBopen();
                SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO DoctorType(Type)VALUES(@type)", con);
                insertCommand.Parameters.Add(new SQLiteParameter("@type", Type));
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

        }// end insert Type
        
        /* ViewType
         * Returns a List of types from the DB
         * 
         * 
         */
        public List<string> ViewType(List<string> typeList)
        {

            try
            {
                DBopen();
                SQLiteDataReader sqlGet;
                SQLiteCommand sqlCMD;
                sqlCMD = con.CreateCommand();
                sqlCMD.CommandText = "SELECT * FROM DoctorType";
                sqlGet = sqlCMD.ExecuteReader();
                while (sqlGet.Read())
                {
                    string getType = sqlGet.GetString(11);
                    typeList.Add(getType);
                }
            }
            catch (SQLiteException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                DBClose();
            }
            return typeList;
        }// END View type
        
        /* UpdateType:
         * Update the database Doctor type by type ID         * 
         * 
         */
        public void UpdateType(int typeID, string type)
        {
            try
            {
                DBopen();
                SQLiteCommand sqlUpdate = new SQLiteCommand("UPDATE DoctorType SET Type=@type WHERE TypeID=@iD", con);
                sqlUpdate.Parameters.Add(new SQLiteParameter("@iD", typeID));
                sqlUpdate.Parameters.Add(new SQLiteParameter("@type", type));             

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
        }// END UPdateType
    }// END class
}
