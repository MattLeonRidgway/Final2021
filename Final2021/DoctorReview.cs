using System;
using System.Windows.Forms;

namespace Final2021
{
    public partial class DoctorReview : Form
    { DoctorClass doc = new DoctorClass();
        ReviewedDoctor revDoc = new ReviewedDoctor();
        public DoctorReview()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int department = Int32.Parse(lstBxDepart.SelectedValue.ToString());
            lstBxDocREv.DataSource = doc.ViewDoctor(department);
            btnGen.Visible = true;
            btnGenerate.Visible = false;
        }

        private void DoctorReview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetReviewDoctorDepartment.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.dataSetReviewDoctorDepartment.Department);

        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            int department = Int32.Parse(lstBxDepart.SelectedValue.ToString());
            
            lstBxDocREv.ClearSelected();
            lstBxDocREv.DataSource= revDoc.CheckReviewed(department);
            btnGen.Visible = false;
        }
    }
}
