using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Final2021
{
    public class SaveReviewed {
        public string SavedReviewed;
        public int SavedDoctor;
        public int SavedNurse;
        public string SavedDate;
        //public IEnumerable<SaveReviewed> Select()
        //{
            
            //SaveReviewed db = new SaveReviewed();
            //return from sav in db.SavedReviewed select sav;
           
        //}

        public void Insert(SaveReviewed newSave)
        {
        //   SaveReviewed db = new SaveReviewed();
          //  db.Insert..InsertOnSubmit(newSave);
            //db.SubmitChanges();
        }
    }
    class SavedClass
    {// For doctors =1 Nurses =0
        public string connectString = @"Data Source= C:\Users\scoob\OneDrive - Champlain College\Current courses\SDEV 360-81 C#\code\Final2021\PatientLite.db; Version=3; Compress=true;";
        public List<String> reviewedList = new List<String>();

        public List<String> LinqToSqlGet(object sender, EventArgs eArgs)
        {

            try
            {
                reviewedList.Clear();
                DataContext db = new DataContext(connectString);
                Table<SaveReviewed> saved = db.GetTable<SaveReviewed>();

                var reviewed = from rev in saved
                               where rev.SavedDoctor == 1
                               select rev;
                foreach (var revs in reviewed) {
                    string toList = revs.SavedReviewed + " "+revs.SavedDate;
                    reviewedList.Add(toList);
                }
            }
            catch (Exception eMess)
            {
                Console.WriteLine(eMess.Message);
            }
            return reviewedList;

        }
      
    }
}
