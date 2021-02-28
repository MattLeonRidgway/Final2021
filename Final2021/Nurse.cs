using System;
using System.Windows.Forms;

namespace Final2021
{
    public partial class Nurse : Form
    {
        DBConnection connection = new DBConnection();
        NurseClass nurse = new NurseClass();
        public Nurse()
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

        private void lstBxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Nurse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetNurse.Nurse' table. You can move, or remove it, as needed.
            this.nurseTableAdapter.Fill(this.dataSetNurse.Nurse);
            // TODO: This line of code loads data into the 'dataSetClinic.Clinic' table. You can move, or remove it, as needed.
            this.clinicTableAdapter.Fill(this.dataSetClinic.Clinic);
            // TODO: This line of code loads data into the 'dataSetDepartment.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.dataSetDepartment.Department);
            // TODO: This line of code loads data into the 'dataSetNurseType.NurseType' table. You can move, or remove it, as needed.
            this.nurseTypeTableAdapter.Fill(this.dataSetNurseType.NurseType);
            // TODO: This line of code loads data into the 'dataSet.Status' table. You can move, or remove it, as needed.
            this.statusTableAdapter.Fill(this.dataSet.Status);
            // TODO: This line of code loads data into the 'dataSetClinic.Clinic' table. You can move, or remove it, as needed.
            this.clinicTableAdapter.Fill(this.dataSetClinic.Clinic);
            // TODO: This line of code loads data into the 'dataSetDepartment.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.dataSetDepartment.Department);
            // TODO: This line of code loads data into the 'dataSetNurseType.NurseType' table. You can move, or remove it, as needed.
            this.nurseTypeTableAdapter.Fill(this.dataSetNurseType.NurseType);
            // TODO: This line of code loads data into the 'dataSetStatus.Status' table. You can move, or remove it, as needed.
       
            string radioRuslt = null;
            foreach (Control control in this.groupDxRdBtns.Controls)
            {

                if (control is RadioButton)
                {
                    RadioButton radioBtn = control as RadioButton;
                    if (radioBtn.Checked)
                    {
                        radioRuslt = radioBtn.Text;
                    }
                }

            }

        }

        private void editAddNurse_Click(object sender, EventArgs e)
        {
            bool check = true;
           
            if (ValidateClass.isValidString(txtBxFName.Text))
            {
                nurse.FName = txtBxFName.Text;
            }
            else {

                txtBxFName.Clear();
                txtBxFName.AppendText("Invalid");
                check = false;
            }
            if (ValidateClass.isValidString(txtBxMName.Text))
            {
                nurse.MName = txtBxMName.Text;
            }
            else
            {

                txtBxMName.Clear();
                txtBxMName.AppendText("Invalid");
                check = false;
            }
            if (ValidateClass.isValidString(txtBxLName.Text))
            {
                nurse.LName = txtBxLName.Text;
            }
            else
            {

                txtBxLName.Clear();
                txtBxLName.AppendText("Invalid");
                check = false;
            }
            if (radioBtnMale.Checked | radioBtnFemale.Checked)
            {
                if (radioBtnMale.Checked)
                {
                    nurse.Sex = 'M';
                }
                if (radioBtnFemale.Checked)
                {
                    nurse.Sex = 'F';
                }
            }
            else
            {
                MessageBox.Show("You need to check a sex");
                check = false;
            }
            if (ValidateClass.isValidEmail(txtBxEmail.Text))
            {
                nurse.Email = txtBxEmail.Text;
            }
            else
            {
                txtBxEmail.Clear();
                txtBxEmail.AppendText("Invalid");
                check = false;
            }
            if (ValidateClass.isValidAlphanumeric(txtBxNote.Text))
            {
                nurse.Notes = txtBxNote.Text;
            }
            else
            {
                txtBxNote.Clear();
                txtBxNote.AppendText("Invalid");
                check = false;
            }
            if (check)
            {
                nurse.Status = Int32.Parse(cmboxStatus.SelectedValue.ToString());
                nurse.Type = Int32.Parse(cmboxType.SelectedValue.ToString());
                nurse.Department = Int32.Parse(cmboxDepartment.SelectedValue.ToString());
                nurse.Clinic = Int32.Parse(cmboxClinic.SelectedValue.ToString());

                nurse.InsertNurse(nurse.FName, nurse.MName, nurse.LName, nurse.Sex, nurse.Status, nurse.Type, nurse.Department,
                    nurse.Clinic, nurse.Email, nurse.Notes);
                txtBxEmail.Clear();
                txtBxFName.Clear();
                txtBxLName.Clear();
                txtBxMName.Clear();
                txtBxNote.Clear();
                radioBtnFemale.Checked = false;
                radioBtnMale.Checked = false;
            }
            else
            {
                MessageBox.Show("Correct Errors");
            }
        }
    }
}
