using System;
using System.Windows.Forms;

namespace Final2021
{/* Nurse Review Form
  * generate a list of nurse show in list box
  * pair the nurses and show in list box
  * Saved will show old and current
  */
    public partial class NurseReview : Form
    { NurseClass nur = new NurseClass();
        ReviewedNurse reviewNur = new ReviewedNurse();
        ValidateClass validate = new ValidateClass();
        public NurseReview()
        {
            InitializeComponent();
        }
        /* Exit:
         * Exit program
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
        /* Home:
         * Navigate to Home
         */
        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            Hide();
        }
        /* LOAD datasets
         * 
         */
        private void NurseReview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetNurse.NurseType' table. You can move, or remove it, as needed.
            this.nurseTypeTableAdapter.Fill(this.dataSetNurse.NurseType);
            // TODO: This line of code loads data into the 'dataSetReviewDepartmentNurse.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.dataSetReviewDepartmentNurse.Department);

        }
        /* Generate:
         * Build list of nurses
         */
        private void btnGenerate_Click(object sender, EventArgs e)
        {           
            int department = Int32.Parse(lstBxDepart.SelectedValue.ToString());
            int type = Int32.Parse(lstBxType.SelectedValue.ToString());
            lstBxNurseRev.DataSource = nur.ViewNurse(department,type);
            if (validate.checkList(nur.ViewNurse(department, type))) { 
              btnGenerate.Visible = false;
            btnMakeList.Visible = true;
            }
            else
            {
                MessageBox.Show("Not enough Nurses to build a list");
                btnGenerate.Visible = true;
                btnMakeList.Visible = false;
            }
        }
        /* MakeList:
         * Pair list of nurses 
         */
        private void btnMakeList_Click(object sender, EventArgs e)
        {
            int depart = Int32.Parse(lstBxDepart.SelectedValue.ToString());
            int type = Int32.Parse(lstBxType.SelectedValue.ToString());
            lstBxNurseRev.ClearSelected();
            lstBxNurseRev.DataSource = reviewNur.CheckReviewed(depart, type);
            btnMakeList.Visible = false;
        }
        //NOT used
        private void btnSaved_Click(object sender, EventArgs e)
        {
            
            lstBxNurseRev.DataSource = reviewNur.GetSaved();
        }
        //NOT used
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
