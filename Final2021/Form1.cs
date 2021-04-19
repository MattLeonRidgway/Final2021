using System;
using System.Windows.Forms;

namespace Final2021
{/* Home Page Form1
  * This is the HOMEPAGE or HOME form used to Navigate
  */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // NOT used
        private void label1_Click(object sender, EventArgs e)
        {

        }
        /* Exit:
         *  Used to Exit the program
         */
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("The application closed  successfully.", "Closed", MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }
        /* Doctor Review
         * Navigate to Doctor review form
         */
        private void btnDocRev_Click(object sender, EventArgs e)
        {
            DoctorReview dreview = new DoctorReview();
            dreview.Show();
            Hide();
        }
        /* Nurse Review
         * Navigate to Nurse review form
         */
        private void btnNurseRev_Click(object sender, EventArgs e)
        {
            NurseReview nreview = new NurseReview();
            nreview.Show();
            Hide();
        }
        /* Doctor Add
         * Navigate to the Add Doctor form 
         */
        private void btnDocAdd_Click(object sender, EventArgs e)
        {
            Doctor doc = new Doctor();
            doc.Show();
            Hide();
        }
        /* Add nurse form
         * This was supposed to be one single form for add and edit
         */
        private void btnAddEditNurse_Click(object sender, EventArgs e)
        {
            Nurse nurs = new Nurse();
            nurs.Show();
            Hide();
        }
        /* Add Data:
         * Navigate to the add form
         */
        private void btnAddInfo_Click(object sender, EventArgs e)
        {
            AddData add = new AddData();
            add.Show();
            Hide();
        }
        /* Edit Data
         * Navigate to edit data form
         */
        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            EditData edit = new EditData();
            edit.Show();
            Hide();
        }
        /* Doctor Edit:
         * Navigate to edit doctor form
         */
        private void btnDoctorEdit_Click(object sender, EventArgs e)
        {
            DoctorEdit docEdit = new DoctorEdit();
            docEdit.Show();
            Hide();
        }
        /* Button1 is the Nurse edit page
         * Navigate to the Nurse Edit form
         * 
         */
        private void button1_Click(object sender, EventArgs e)
        {
            NurseEdit nurseEdit = new NurseEdit();
            nurseEdit.Show();
            Hide();
        }
    }
}
