using System;
using System.Windows.Forms;

namespace Final2021
{/* Doctor Review
  * Generate a list of doctors based on department showing in list box
  * GenClick pairs the doctors and shows in list box
  */
    public partial class DoctorReview : Form
    { DoctorClass doc = new DoctorClass();
        ReviewedDoctor revDoc = new ReviewedDoctor();
        ValidateClass validate = new ValidateClass();

        public DoctorReview()
        {
            InitializeComponent();
        }
        //NOT used
        private void label3_Click(object sender, EventArgs e)
        {

        }
        /* Exit:
         * Used to exit the program 
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
        /* Home
         * Navigate to HOME page
         */
        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            Hide();
        }
        /* Generate
         * Build a list of doctors based on department and show in list box
         * Check list size
         */
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int department = Int32.Parse(lstBxDepart.SelectedValue.ToString());
            lstBxDocREv.DataSource = doc.ViewDoctor(department);
            if (validate.checkList(doc.ViewDoctor(department)))
            {//true
                btnGen.Visible = true;
                btnGenerate.Visible = false;
            }
            else {//false
                MessageBox.Show("Not enough Doctors to build a List");
                btnGen.Visible = false;
                btnGenerate.Visible = true;
            }
   
        }
        // Load dataset
        private void DoctorReview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetReviewDoctorDepartment.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.dataSetReviewDoctorDepartment.Department);

        }
        /* Gen:
         * Pair the doctors and show in List box
         */
        private void btnGen_Click(object sender, EventArgs e)
        {
            int department = Int32.Parse(lstBxDepart.SelectedValue.ToString());
            
            lstBxDocREv.ClearSelected();
            
            lstBxDocREv.DataSource= revDoc.CheckReviewed(department);
            
           //comment out for debugging
             btnGen.Visible = false;
        }
        /* Saved:
         * Show the current and old pairing based on Doctor
         */
        private void btnSaved_Click(object sender, EventArgs e)
        {
            lstBxDocREv.DataSource = revDoc.GetSaved();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lstBxDocREv.DataSource = null;
            lstBxDocREv.Items.Clear();
        }
    }
}
