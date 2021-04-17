using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SQLite;

/* 
    Created by Matt Ridgway
    Class used for LINQ to insert into table
    
 */

namespace Final2021
{
    // TABLE
    [Table(Name = "SaveReview")]
    // CLASS for table This is the OBJECT for LINQ
    public class SaveReview {
        // The primary key is used just to hold a number and is not used other than in the class
        // The database has a primary key
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
    // Database name and connection string using DataContext
    public class PatientLite : DataContext {
       // Connection string
        SQLiteCommand sqlCom = new SQLiteCommand();
        private static SQLiteConnection con = new SQLiteConnection(@"Data Source= C:\Users\scoob\OneDrive - Champlain College\Current courses\SDEV 360-81 C#\code\Final2021\PatientLite.db; Version=3; Compress=true;");
              
        public PatientLite() : base(con) {
            Log = Console.Out;
        }
    }
    class SavedClass
    {// InsertSaved is used to insert either insert a doctor or nurse depending on the call
     // Using nurse and doctor 1 or 0 
        public void InsertSaved(int saveID, String reviewed,int doc,int nurse,String sDate) {
            // Try
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
            // Catch
            catch (SQLiteException e)
            {
                throw new Exception(e.Message);
            }         
           
        }// END InsertSaved   
    }// END CLass
}
