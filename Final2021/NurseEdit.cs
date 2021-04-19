using System;
using System.Windows.Forms;
/* Edit Nurse
 * Select a Nurse click Fill In the text boxes and combo boxes get info from DB and fills them in
 * Once the text boxes and combo boxes have been edited click save UPDATES the DB.
 * Select a Nurse click Delete will delete the selected nurse from data base.
 * Create a nurseClass 
 * Clear button clears text boxes
 * Exit button will exit the program
 * Home gets the user to the home form
 */
namespace Final2021
{
    public partial class NurseEdit : Form
    {
        NurseClass nur = new NurseClass();

        public NurseEdit()
        {
            InitializeComponent();
        }
        /* Cancel:
         * Clear text boxes
         */
        private void btnCancel_Click(object sender, EventArgs e)
        {// Clear text boxes
            txtBxEditEmail.Clear();
            txtBxEditFName.Clear();
            txtBxEditLName.Clear();
            txtBxEditMName.Clear();
            txtBxEditNote.Clear();
        }
        /* Exit
         * Exit program
         */
        private void btnExit_Click(object sender, EventArgs e)
        {// Message box to confirm exit
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
         * Navigate to the Home form
         */
        private void btnHome_Click(object sender, EventArgs e)
        {// Takes the user home and hides the current form
            Form1 home = new Form1();
            home.Show();
            Hide();
        }
        // LOAD dataset
        private void NurseEdit_Load(object sender, EventArgs e)
        {// Loads the datasets when the form loads
            
            this.clinicTableAdapter.Fill(this.dataSetEditNurseClinic.Clinic);       
            this.departmentTableAdapter.Fill(this.dataSetEditNurseDepartment.Department);          
            this.nurseTypeTableAdapter.Fill(this.dataSetEditNurseType.NurseType);
            this.statusTableAdapter.Fill(this.dataSetNurseEditStatus.Status);
            this.nurseTableAdapter.Fill(this.dataSetSelectNurse.Nurse);
        }
        /* FillInEdit
         * Select a nurse and fill the text boxes from the database
         */
        private void btnFillInEDIT_Click(object sender, EventArgs e)
        {// get the ID from the combo box Select Nurse
            int getNurseID = Int32.Parse(cmBxSelectNurse.SelectedValue.ToString());
            // Calls getNurse sends the nurse ID
            nur.GetNurse(getNurseID);
            txtBxEditFName.Text = nur.FName;
            txtBxEditMName.Text = nur.MName;
            txtBxEditLName.Text = nur.LName;
            cmBoxEDITStatus.SelectedItem = nur.Status;
            cmBxTypeEDIT.SelectedIndex = nur.Type;
            cmBxDepartEDIT.SelectedIndex = nur.Department;
            cmBxClinicEDIT.SelectedIndex = nur.Clinic;

            txtBxEditEmail.Text = nur.Email;
            txtBxEditNote.Text = nur.Notes;
            //refresh dataset and combo box on button click
            this.nurseTableAdapter.Fill(this.dataSetSelectNurse.Nurse);
            cmBxSelectNurse.Refresh();

        }
        // Not used
        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {            
        }
        /* Delete:
         * Deleted the selected nurse
         */
        private void btnNurseDelete_Click(object sender, EventArgs e)
        {// Select Nurse message box confirm delete
            string nurse = "Deleted Nurse "+cmBxSelectNurse.Text;
            if (MessageBox.Show("Confirm?", nurse, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {  
              // sends nurse ID to deleteNurse
                nur.DeleteNurse(Int32.Parse(cmBxSelectNurse.SelectedValue.ToString()));
                //refresh dataset for combo box
                this.nurseTableAdapter.Fill(this.dataSetSelectNurse.Nurse);
                cmBxSelectNurse.Refresh();

            }
            else
            {
                this.Activate();
            }
            
        }
/* Save nurse UPDATE
 * UPDATE the database
 */
        private void btnEditSAVE_Click(object sender, EventArgs e)
        {// UPDATE
            bool check = false;
            // Check text boxes for valid string send error on invalid
            if (ValidateClass.isValidString(txtBxEditFName.Text))
            {
                nur.FName = txtBxEditFName.Text;
                check = true;
            }
            else {
                txtBxEditFName.Clear();
                MessageBox.Show("First Name Error");
                check = false;
            }
            if (ValidateClass.isValidString(txtBxEditMName.Text))
            {
                nur.MName = txtBxEditMName.Text;
                check = true;
            }
            else
            {
                txtBxEditMName.Clear();
                MessageBox.Show("Middle Name Error");
                check = false;
            }
            if (ValidateClass.isValidString(txtBxEditLName.Text))
            {
                nur.LName = txtBxEditLName.Text;
                check = true;
            }
            else
            {
                txtBxEditLName.Clear();
                MessageBox.Show("Last Name Error");
                check = false;
            }
            // check email using regex in ValidateClass
            if (ValidateClass.isValidEmail(txtBxEditEmail.Text))
            {
                nur.Email= txtBxEditEmail.Text;
                check = true;
            }
            else
            {
                txtBxEditEmail.Clear();
                MessageBox.Show("Email Error");
                check = false;
            }
            if (ValidateClass.isValidString(txtBxEditNote.Text))
            {
                nur.Notes= txtBxEditNote.Text;
                check = true;
            }
            else
            {
                txtBxEditNote.Clear();
                MessageBox.Show("Notes Error");
                check = false;
            }
            // fills in NurseClass
            if (check) {
                nur.Status = Int32.Parse(cmBoxEDITStatus.SelectedValue.ToString());
                nur.Type = Int32.Parse(cmBxTypeEDIT.SelectedValue.ToString());
                nur.Department = Int32.Parse(cmBxDepartEDIT.SelectedValue.ToString());
                nur.Clinic = Int32.Parse(cmBxClinicEDIT.SelectedValue.ToString());   
                int nID = Int32.Parse(cmBxSelectNurse.SelectedValue.ToString());
                // sends values to UPDATE
                nur.UpdateNurse(nID, nur.FName, nur.MName, nur.LName, nur.Status, nur.Type, nur.Department, nur.Clinic, nur.Email, nur.Notes);

                txtBxEditEmail.Clear();
                txtBxEditFName.Clear();
                txtBxEditLName.Clear();
                txtBxEditMName.Clear();
                txtBxEditNote.Clear();

            }
        }
    }
}
