using System;
using System.Windows.Forms;

namespace Final2021
{
    public partial class NurseReview : Form
    { NurseClass nur = new NurseClass();
        ReviewedNurse reviewNur = new ReviewedNurse();
        public NurseReview()
        {
            InitializeComponent();
        }

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

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            Hide();
        }

        private void NurseReview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetNurse.NurseType' table. You can move, or remove it, as needed.
            this.nurseTypeTableAdapter.Fill(this.dataSetNurse.NurseType);
            // TODO: This line of code loads data into the 'dataSetReviewDepartmentNurse.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.dataSetReviewDepartmentNurse.Department);

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {           
            int department = Int32.Parse(lstBxDepart.SelectedValue.ToString());
            int type = Int32.Parse(lstBxType.SelectedValue.ToString());
            lstBxNurseRev.DataSource = nur.ViewNurse(department,type);
            btnGenerate.Visible = false;
            btnMakeList.Visible = true;
        }

        private void btnMakeList_Click(object sender, EventArgs e)
        {
            int depart = Int32.Parse(lstBxDepart.SelectedValue.ToString());
            int type = Int32.Parse(lstBxType.SelectedValue.ToString());
            lstBxNurseRev.ClearSelected();
            lstBxNurseRev.DataSource = reviewNur.CheckReviewed(depart, type);
            btnMakeList.Visible = false;
        }

        private void btnSaved_Click(object sender, EventArgs e)
        {
            
            lstBxNurseRev.DataSource = reviewNur.GetSaved();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
