using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Final2021
{
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
        public void InsertDepartment(string depart)
        {

            try
            {
                DBopen();
                SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO Department(Department)VALUES(?)", con);
                insertCommand.Parameters.AddWithValue(depart, DepartmentString);
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
        // get a list of departments
        public List<string> ViewDepartment(DBConnection conn, List<string> departList)
        {
            DBopen();
            try
            {
                SQLiteDataReader sqlGet;
                SQLiteCommand sqlCMD;
                sqlCMD = con.CreateCommand();
                sqlCMD.CommandText = "SELECT * FROM Department";
                sqlGet = sqlCMD.ExecuteReader();
                while (sqlGet.Read())
                {
                    string getDepart = sqlGet.GetString(11);
                    departList.Add(getDepart);
                }
            }
            catch
            {
                Console.WriteLine("View Department catch");
            }
            DBClose();
            return departList;
        }// end ViewDepartment()
        public void UpdateDepartment(int departmentID, string departmentType)
        {
            try
            {
                DBopen();
                SQLiteCommand sqlUpdate = new SQLiteCommand("UPDATE Department SET Department=@department WHERE DepartmentID=@iD", con);
                sqlUpdate.Parameters.Add(new SQLiteParameter("@iD"));
                sqlUpdate.Parameters.Add(new SQLiteParameter("@department"));
                sqlUpdate.Parameters["@iD"].Value = departmentID;
                sqlUpdate.Parameters["@department"].Value = departmentType;

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
        }
    }
}
