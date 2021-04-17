using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Final2021
{/* Department Class using the DBConnection
  * Insert a new department
  * UPdate department
  * Get a List of departments
  * Build Department Object 
  */
    class Department : DBConnection
    {
        int departmentID;
        string departmentString;

        public Department() { }
        public Department(string departmentString)
        {

            this.departmentString = departmentString;
        }
        public Department(int departmentID, string departmentString)
        {
            this.departmentID = departmentID;
            this.departmentString = departmentString;
        }

        public int DepartmentID { get => departmentID; set => departmentID = value; }
        public string DepartmentString { get => departmentString; set => departmentString = value; }
        /* InsertDepartment
         * Inserts a new department into the database
         */
        public void InsertDepartment(string departmentString)
        {

            try
            {
                DBopen();
                SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO Department(Department)VALUES(@dep)", con);
                insertCommand.Parameters.Add(new SQLiteParameter("@dep", DepartmentString));
                // Execute SQL
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
        }// end insert department
        /* ViewDepartment
         * Return a List of ALL departments
         */
        public List<string> ViewDepartment(List<string> departList)
        {
           
            try
            { DBopen();
                SQLiteDataReader sqlGet;
                SQLiteCommand sqlCMD;
                sqlCMD = con.CreateCommand();
                sqlCMD.CommandText = "SELECT * FROM Department";
                sqlGet = sqlCMD.ExecuteReader();
                // Loop to add to List from DB
                while (sqlGet.Read())
                {
                    string getDepart = sqlGet.GetString(11);
                    departList.Add(getDepart);
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
            return departList;
        }// END ViewDepartment()
        /* UpdateDepartment:
         * Updates the database using the department ID
         */
        public void UpdateDepartment(int departmentID, string departmentString)
        {
            try
            {
                DBopen();
                SQLiteCommand sqlUpdate = new SQLiteCommand("UPDATE Department SET Department=@department WHERE DepartmentID=@iD", con);
                sqlUpdate.Parameters.Add(new SQLiteParameter("@iD",DepartmentID));
                sqlUpdate.Parameters.Add(new SQLiteParameter("@department",DepartmentString));
         
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
        }// END Update

    }// END CLass
}
