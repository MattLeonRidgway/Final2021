using System;
using System.Data.SQLite;
/**
 *  DBConnection class opens and closes the database connection
 *  
 */

namespace Final2021
{
    class DBConnection
    {  // This class is used to create the database connection
       // it will have a open connection, closeConnection
       //string dataBaseLocation= @"Data Source= C:\Users\scoob\OneDrive - Champlain College\Current courses\SDEV 360-81 C#\code\Final2021\PatientLite.db; Version=3; Compress=true;";
       // public SQLiteConnection sqlCon= new SQLiteConnection("Data Source=PatientLite.db; Version = 3; New = True; Compress = True; ");
        public SQLiteCommand sqlCom = new SQLiteCommand();

        public SQLiteConnection con = new SQLiteConnection(@"Data Source= C:\Users\scoob\OneDrive - Champlain College\Current courses\SDEV 360-81 C#\code\Final2021\PatientLite.db; Version=3; Compress=true;");

        public DBConnection()
        {

        }// end connection 
        public void DBopen()
        {
            // Try to open sqlConn
            try
            {
                Console.WriteLine("Database connected");
                con.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection Error", ex);
            }
        }
        public void DBClose()
        {
            try
            {
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("DB could not be disconnected", ex);
            }
        }// Close the connection
        public void Query(string query)
        {

            DBopen();
            con.Open();
            sqlCom = con.CreateCommand();
            sqlCom.CommandText = query;
            sqlCom.ExecuteNonQuery();
            con.Close();

        }
    }
}
