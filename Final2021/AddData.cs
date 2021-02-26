using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Final2021
{
    public partial class AddData : Form        
    {ValidateClass validat=new ValidateClass();
        public AddData()
        {
            InitializeComponent();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            string stat;
            if (ValidateClass.isValidString(txtBxStatus.Text))
            {
                stat = txtBxStatus.Text;
                txtBxStatus.Clear();
                Status status = new Status(stat);
                status.InsertStatus(status.StatusType);
            }
            else {
                txtBxStatus.Clear();
                txtBxStatus.AppendText("Invalid");
            }
           
        }      

        private void btnDoctorType_Click(object sender, EventArgs e)
        {
            string type;
            if (ValidateClass.isValidString(txtBxDrType.Text))
            {
                type = txtBxDrType.Text;
                txtBxDrType.Clear();
                DoctorType dType = new DoctorType(type);
                dType.InsertDoctorType(dType.Type);
            }
            else {
                txtBxDrType.Clear();
                txtBxDrType.AppendText("Invalid");
            }
        }

        private void btnNurseType_Click(object sender, EventArgs e)
        {
            string type;
            if (ValidateClass.isValidString(txtBxNurseType.Text))
            {
                type = txtBxNurseType.Text;
                txtBxNurseType.Clear();
                NurseType nType = new NurseType(type);
                nType.InsertNurseType(nType.Type);
            }
            else {
                txtBxNurseType.Clear();
                txtBxNurseType.AppendText("Invalid");
            
            }
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            string department;
            if (ValidateClass.isValidString(txtBxDepartment.Text))
            {
                department = txtBxDepartment.Text;
                txtBxDepartment.Clear();
                Department depart = new Department(department);
                depart.InsertDepartment(depart.DepartmentString);
            }
            else {
                txtBxDepartment.Clear();
                txtBxDepartment.AppendText("Invalid");
            }
        }

        private void btnClinic_Click(object sender, EventArgs e)
        {
            string clinic;
            if (ValidateClass.isValidString(txtBxClinic.Text))
            {
                clinic = txtBxClinic.Text;
                txtBxClinic.Clear();
                Clinic clnc = new Clinic(clinic);
                clnc.InsertClinic(clnc.ClinicString);
            }
            else {
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
                MessageBox.Show("The application closed  successfully.","Closed", MessageBoxButtons.OK);
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
