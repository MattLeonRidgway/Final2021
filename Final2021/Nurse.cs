using System;
using System.Windows.Forms;

namespace Final2021
{/* Nurse form
  * Used to ADD a new nurse
  */
    public partial class Nurse : Form
    {
        DBConnection connection = new DBConnection();
        NurseClass nurse = new NurseClass();
        public Nurse()
        {
            InitializeComponent();
        }
        /* Exit
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
/* Home
 * Navigate to form 1
 */
        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            Hide();
        }
        //NOT used
        private void lstBxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // LOAD dataset
        private void Nurse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetNurseClinicAdd.Clinic' table. You can move, or remove it, as needed.
            this.clinicTableAdapter.Fill(this.dataSetNurseClinicAdd.Clinic);
            // TODO: This line of code loads data into the 'dataSetNurseDepartmentAdd.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.dataSetNurseDepartmentAdd.Department);
            // TODO: This line of code loads data into the 'dataSetNurseTypeAdd.NurseType' table. You can move, or remove it, as needed.
            this.nurseTypeTableAdapter.Fill(this.dataSetNurseTypeAdd.NurseType);
            // TODO: This line of code loads data into the 'dataSetNurseAddStatus.Status' table. You can move, or remove it, as needed.
            this.statusTableAdapter.Fill(this.dataSetNurseAddStatus.Status);


        }
        /* Add nurse
         * Validate text boxes
         * IF true insert the new Nurse
         * Else show error
         */
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
            {// IF true
                nurse.Status = Int32.Parse(cmboxStatus.SelectedValue.ToString());
                nurse.Type = Int32.Parse(cmboxType.SelectedValue.ToString());
                nurse.Department = Int32.Parse(cmboxDepartment.SelectedValue.ToString());
                nurse.Clinic = Int32.Parse(cmboxClinic.SelectedValue.ToString());

                nurse.InsertNurse(nurse.FName, nurse.MName, nurse.LName, nurse.Status, nurse.Type, nurse.Department,
                    nurse.Clinic, nurse.Email, nurse.Notes);
                txtBxEmail.Clear();
                txtBxFName.Clear();
                txtBxLName.Clear();
                txtBxMName.Clear();
                txtBxNote.Clear();
              
            }
            else
            {// else ERROR
                MessageBox.Show("Correct Errors");
            }
        }
    }
}
