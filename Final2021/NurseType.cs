using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Final2021
{/* NurseType Class
  * Used to update and Insert a new type
  * Get a list of types
  * 
  */
    class NurseType : DBConnection
    {
        int id;
        string type;

        public NurseType() { }

        public NurseType(int id, string type)
        {
            this.id = id;
            this.type = type;
        }
        public NurseType(string type)
        {
            this.type = type;
        }

        public int Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        /* InsertNurseType
         * Makes a new nurse type
         */
        public void InsertNurseType(string type)
        {
            try
            {
                DBopen();
                SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO NurseType(Type)VALUES(@type)", con);
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

        }// END insert Type
         /* ViewType:
          * Returns a List of nurse types
          */
        public List<string> ViewType(List<string> typeList)
        {
            DBopen();
            try
            {
                SQLiteDataReader sqlGet;
                SQLiteCommand sqlCMD;
                sqlCMD = con.CreateCommand();
                sqlCMD.CommandText = "SELECT * FROM NurseType";
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
        
        /* UpdateType
         * Updates the database based on type ID
         * 
         */
        public void UpdateType(int typeID, string type)
        {

            try
            {
                DBopen();
                SQLiteCommand sqlUpdate = new SQLiteCommand("UPDATE NurseType SET Type=@type WHERE TypeID=@iD", con);
                sqlUpdate.Parameters.Add(new SQLiteParameter("@iD"));
                sqlUpdate.Parameters.Add(new SQLiteParameter("@type"));
                sqlUpdate.Parameters["@iD"].Value = typeID;
                sqlUpdate.Parameters["@type"].Value = type;

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
        }// END 

    }// END class
}
