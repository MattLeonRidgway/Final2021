using System;
using System.Windows.Forms;

namespace Final2021
{
    public partial class EditData : Form
    {
        public EditData()
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

        private void EditData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetEditDataDoctorType.DoctorType' table. You can move, or remove it, as needed.
            this.doctorTypeTableAdapter1.Fill(this.dataSetEditDataDoctorType.DoctorType);
            // TODO: This line of code loads data into the 'dataSetEditClinic.Clinic' table. You can move, or remove it, as needed.
            this.clinicTableAdapter.Fill(this.dataSetEditClinic.Clinic);
            // TODO: This line of code loads data into the 'dataSetEditDepartment.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.dataSetEditDepartment.Department);
            // TODO: This line of code loads data into the 'dataSetEditNurseType.NurseType' table. You can move, or remove it, as needed.
            this.nurseTypeTableAdapter.Fill(this.dataSetEditNurseType.NurseType);
            // TODO: This line of code loads data into the 'dataSetEditDoctorType.DoctorType' table. You can move, or remove it, as needed.      
            // TODO: This line of code loads data into the 'dataSetEditStaus.Status' table. You can move, or remove it, as needed.
            this.statusTableAdapter.Fill(this.dataSetEditStaus.Status);


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBxClinic.Clear();
            txtBxDepartment.Clear();
            txtBxDoctorType.Clear();
            txtBxNurseType.Clear();
            txtBxStatus.Clear();
        }
    }
}
