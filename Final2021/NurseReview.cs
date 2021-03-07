using System;
using System.Windows.Forms;

namespace Final2021
{
    public partial class NurseReview : Form
    { NurseClass nur = new NurseClass();
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
            // TODO: This line of code loads data into the 'dataSetReviewDepartmentNurse.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.dataSetReviewDepartmentNurse.Department);

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {           
            int department = Int32.Parse(lstBxDepart.SelectedValue.ToString());
            lstBxNurseRev.DataSource = nur.ViewNurse(department);
        }
    }
}
