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
            // TODO: This line of code loads data into the 'dataSetEditClinicData.Clinic' table. You can move, or remove it, as needed.
            this.clinicTableAdapter.Fill(this.dataSetEditClinicData.Clinic);
            // TODO: This line of code loads data into the 'dataSetEditDepartmentDATA.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.dataSetEditDepartmentDATA.Department);
            // TODO: This line of code loads data into the 'dataSetEditNurseTypeData.NurseType' table. You can move, or remove it, as needed.
            this.nurseTypeTableAdapter.Fill(this.dataSetEditNurseTypeData.NurseType);
            // TODO: This line of code loads data into the 'dataSetEditDoctorTypeData.DoctorType' table. You can move, or remove it, as needed.
            this.doctorTypeTableAdapter.Fill(this.dataSetEditDoctorTypeData.DoctorType);
            // TODO: This line of code loads data into the 'dataSetEDITStatus.Status' table. You can move, or remove it, as needed.
            this.statusTableAdapter.Fill(this.dataSetEDITStatus.Status);



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBxClinic.Clear();
            txtBxDepartment.Clear();
            txtBxDoctorType.Clear();
            txtBxNurseType.Clear();
            txtBxStatus.Clear();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            Status status = new Status();
            if (ValidateClass.isValidString(txtBxStatus.Text)) {
                status.StatusType = txtBxStatus.Text;
                status.StatusID = Int32.Parse(cmboxStatus.SelectedValue.ToString());
                status.UpdateStatus(status.StatusID, status.StatusType);
                txtBxStatus.Clear();
                this.statusTableAdapter.Fill(this.dataSetEDITStatus.Status);
                cmboxStatus.Refresh();

            }
            else
            {
                MessageBox.Show("Correct Errors");
            }
           

        }

        private void btnDoctorType_Click(object sender, EventArgs e)
        {
            DoctorType docType = new DoctorType();
            if (ValidateClass.isValidString(txtBxDoctorType.Text)) {
                docType.Type = txtBxDoctorType.Text;
                docType.Id = Int32.Parse(cmboxDoctorType.SelectedValue.ToString());
                docType.UpdateType(docType.Id,docType.Type);
                txtBxDoctorType.Clear();
                this.doctorTypeTableAdapter.Fill(this.dataSetEditDoctorTypeData.DoctorType);
                cmboxDoctorType.Refresh();
            }
            else
            {
                MessageBox.Show("Correct Errors");
            }
       
        }

        private void btnNurseType_Click(object sender, EventArgs e)
        {
            NurseType nurseType = new NurseType();
            if (ValidateClass.isValidString(txtBxNurseType.Text)) {
                nurseType.Type = txtBxNurseType.Text;
                nurseType.Id = Int32.Parse(cmBxNurseType.SelectedValue.ToString());
                nurseType.UpdateType(nurseType.Id,nurseType.Type);
                txtBxNurseType.Clear();
                this.nurseTypeTableAdapter.Fill(this.dataSetEditNurseTypeData.NurseType);
                cmBxNurseType.Refresh();
            }
            else
            {
                MessageBox.Show("Correct Errors");
            }
    
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            if (ValidateClass.isValidString(txtBxDepartment.Text)) {
                department.DepartmentString = txtBxDepartment.Text;
                department.DepartmentID = Int32.Parse(cmBoxDepartmnet.SelectedValue.ToString());
                department.UpdateDepartment(department.DepartmentID,department.DepartmentString);
                txtBxDepartment.Clear();
                this.departmentTableAdapter.Fill(this.dataSetEditDepartmentDATA.Department);
                cmBoxDepartmnet.Refresh();
            }
            else
            {
                MessageBox.Show("Correct Errors");
            }
           
        }

        private void btnClinic_Click(object sender, EventArgs e)
        {
            Clinic clinic = new Clinic();
            if (ValidateClass.isValidString(txtBxClinic.Text)) {
                clinic.ClinicString = txtBxClinic.Text;
                clinic.ClinicID = Int32.Parse(cmboxClinic.SelectedValue.ToString());
                clinic.UpdateClinic(clinic.ClinicID,clinic.ClinicString);
                txtBxClinic.Clear();
                this.clinicTableAdapter.Fill(this.dataSetEditClinicData.Clinic);
                cmboxClinic.Refresh();

            }
            else
            {
                MessageBox.Show("Correct Errors");
            }
           
        }
    }
}
