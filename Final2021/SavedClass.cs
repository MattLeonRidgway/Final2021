using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Final2021
{// USED for LINQ 
    // TABLE
    [Table(Name = "SaveReview")]
    // CLASS for table This is the OBJECT for LINQ
    public class SaveReview {
        //primary key is used just to hold a number and is not used other than here
        [Column(IsPrimaryKey = true)]
        public int SavedID { get; set; }
       [Column()]
        public String SavedReviewed { get; set; }
        [Column()]
        public int SavedDoctor { get; set; }
        [Column()]
        public int SavedNurse { get; set; }
        [Column()]
        public String SavedDate { get; set; }
    }
    // Database name and connection string
    public class PatientLite : DataContext {
       SQLiteCommand sqlCom = new SQLiteCommand();

        private static SQLiteConnection con = new SQLiteConnection(@"Data Source= C:\Users\scoob\OneDrive - Champlain College\Current courses\SDEV 360-81 C#\code\Final2021\PatientLite.db; Version=3; Compress=true;");

       // private static string connectionString = @"Data Source= C:\\Users\\scoob\\OneDrive - Champlain College\\Current courses\\SDEV 360-81 C#\\code\\Final2021\\Final2021\\PatientLite.db";
        public PatientLite() : base(con) {
            Log = Console.Out;
        }
    }
    class SavedClass
    {// Used to insert into SaveReview to hold both nurse and doctor 1 or 0.
        public void InsertSaved(int saveID, String reviewed,int doc,int nurse,String sDate) {

            try {
                PatientLite dbPatientLite = new PatientLite();
                Table<SaveReview> savedReviews = dbPatientLite.GetTable<SaveReview>();
                SaveReview saved = new SaveReview();
                //Everything is being sent when theCalling InsertSaved
                saved.SavedID = saveID;
                saved.SavedReviewed = reviewed;
                // doc =1 nurse =0
                saved.SavedDoctor = doc;
                // nurse=1 doc=0
                saved.SavedNurse = nurse;
                saved.SavedDate = sDate;

                savedReviews.InsertOnSubmit(saved);
                dbPatientLite.SubmitChanges();
            }
            catch (SQLiteException e)
            {
                throw new Exception(e.Message);
            }         
           
        }

      
       
      
      
    }
}
