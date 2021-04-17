using System;
using System.Data.SQLite;

/**
 *  DBConnection class opens and closes the database connection
 *  
 */

namespace Final2021
{
    class DBConnection
    {     
        //Connection string
        public SQLiteConnection con = new SQLiteConnection(@"Data Source= C:\Users\scoob\OneDrive - Champlain College\Current courses\SDEV 360-81 C#\code\Final2021\PatientLite.db; Version=3; Compress=true;");
         /* DBOpen:
          * Opens the database connection
          */
        public void DBopen()
        {
            // Try to open sqlConn
            try
            {
                Console.WriteLine("Database connected");
                con.Open();
            }
            catch (Exception ex)// Show error in console when the db can't open 
            {
                Console.WriteLine("Connection Error", ex);
            }
        }
        /* DBClose:
         * Closes the database connection
         */
        public void DBClose()
        {
            try// Close the connection
            {
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("DB could not be disconnected", ex);
            }
        }// Close the connection
    }// END DBConnection
}
