using System;
using System.Windows.Forms;


namespace Final2021
{
    public partial class AddData : Form
    {
        ValidateClass validat = new ValidateClass();
        Status stat = new Status();
        DoctorType docType = new DoctorType();
        NurseType nurType = new NurseType();
        Department department = new Department();
        Clinic clinic = new Clinic();
        public AddData()
        {
            InitializeComponent();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {

            if (ValidateClass.isValidString(txtBxStatus.Text))
            {
                stat.StatusType = txtBxStatus.Text;
                txtBxStatus.Clear();
                stat.InsertStatus(stat.StatusType);
            }
            else
            {
                txtBxStatus.Clear();
                txtBxStatus.AppendText("Invalid");
            }

        }

        private void btnDoctorType_Click(object sender, EventArgs e)
        {
            if (ValidateClass.isValidString(txtBxDrType.Text))
            {
                docType.Type = txtBxDrType.Text;
                txtBxDrType.Clear();
                docType.InsertDoctorType(docType.Type);
            }
            else
            {
                txtBxDrType.Clear();
                txtBxDrType.AppendText("Invalid");
            }
        }

        private void btnNurseType_Click(object sender, EventArgs e)
        {
            if (ValidateClass.isValidString(txtBxNurseType.Text))
            {
                nurType.Type = txtBxNurseType.Text;
                txtBxNurseType.Clear();
                nurType.InsertNurseType(nurType.Type);
            }
            else
            {
                txtBxNurseType.Clear();
                txtBxNurseType.AppendText("Invalid");

            }
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {

            if (ValidateClass.isValidString(txtBxDepartment.Text))
            {
                department.DepartmentString = txtBxDepartment.Text;
                txtBxDepartment.Clear();
                department.InsertDepartment(department.DepartmentString);
            }
            else
            {
                txtBxDepartment.Clear();
                txtBxDepartment.AppendText("Invalid");
            }
        }

        private void btnClinic_Click(object sender, EventArgs e)
        {

            if (ValidateClass.isValidString(txtBxClinic.Text))
            {
                clinic.ClinicString = txtBxClinic.Text;
                txtBxClinic.Clear();
                clinic.InsertClinic(clinic.ClinicString);
            }
            else
            {
                txtBxClinic.Clear();
                txtBxClinic.AppendText("Invalid");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBxClinic.Clear();
            txtBxDepartment.Clear();
            txtBxNurseType.Clear();
            txtBxDrType.Clear();
            txtBxStatus.Clear();
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
    }
}
