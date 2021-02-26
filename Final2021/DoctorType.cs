using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final2021
{
    class DoctorType: DBConnection
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
        public void InsertDoctorType(string type)
        {
            try
            {
                DBopen();

                SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO DoctorType(Type)VALUES(?)", con);
                insertCommand.Parameters.AddWithValue(type, Type);
                insertCommand.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally { 
                DBClose();
            }
       
        }// end insert Type
        // get a list Types 
        public List<string> ViewType( List<string> typeList)
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
            catch
            {
                Console.WriteLine("View Type catch");
            }
            DBClose();
            return typeList;
        }// end View type
        public void UpdateType( int typeID, string type)
        {
            try
            {
                DBopen();
                SQLiteCommand sqlUpdate;
                sqlUpdate = con.CreateCommand();
                sqlUpdate.CommandText = "UPDATE INTO DoctorType WHERE TypeID=typeID(Type)" +
                "VALUES(type);";
                sqlUpdate.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Catch Update type");
            }
            DBClose();
        }
    }
}
