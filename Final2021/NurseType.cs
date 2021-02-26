using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final2021
{
    class NurseType:DBConnection
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
        public void InsertNurseType( string type)
        {
            try
            {
                DBopen();
                SQLiteCommand sql;
                string sqlConnect = con.ToString();
                sql = con.CreateCommand();
                sql.CommandText = "INSERT INTO NurseType(Type) " +
                "VALUES(type); ";
                sql.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Insert Type catch");
            }
            DBClose();
        }// end insert Type
        // get a list Types 
       public List<string> ViewType( List<string> typeList)
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
            catch
            {
                Console.WriteLine("View Type catch");
            }
            DBClose();
            return typeList;
        }// end View type
        public void UpdateType(int typeID, string type)
        {

            try
            {
                DBopen();
                SQLiteCommand sqlUpdate;
                sqlUpdate =con.CreateCommand();
                sqlUpdate.CommandText = "UPDATE INTO NurseType WHERE TypeID=typeID(Type)" +
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
