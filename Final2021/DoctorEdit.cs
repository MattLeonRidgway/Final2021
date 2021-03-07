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
    public partial class DoctorEdit : Form
    {
        DoctorClass doc = new DoctorClass();
        public DoctorEdit()
        {
            InitializeComponent();
        }
     
    
        private void btnHome_Click(object sender, EventArgs e)
        {// Hides current form and shows the home form

            Form1 home = new Form1();
            home.Show();
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {// Message box confirm message for exit
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

        private void btnCancel_Click(object sender, EventArgs e)
        {// Clears Text boxes
            txtBxEmailEDIT.Clear();
            txtBxFNameEDIT.Clear();
            txtBxLNameEDIT.Clear();
            txtBxMNameEDIT.Clear();
            txtBxNoteEDIT.Clear();

        }

        private void DoctorEdit_Load(object sender, EventArgs e)
        {// Datasets on load form
           
            this.doctorTableAdapter.Fill(this.dataSetSelectDoctor.Doctor);       
            this.clinicTableAdapter.Fill(this.dataSetEditDoctorClinic.Clinic);          
            this.departmentTableAdapter.Fill(this.dataSetEditDoctorDepartment.Department);       
            this.doctorTypeTableAdapter.Fill(this.dataSetEditDoctorType.DoctorType);     
            this.statusTableAdapter.Fill(this.dataSetDoctorEditStatus.Status);


        }

        private void btnFillInSELECTEDDoc_Click(object sender, EventArgs e)
        {
            int getDocID = Int32.Parse(cmBoxSelectDoctor.SelectedValue.ToString());
            doc.getDoctor(getDocID);
            txtBxFNameEDIT.Text = doc.FName;
            txtBxMNameEDIT.Text = doc.MName;
            txtBxLNameEDIT.Text = doc.LName;
            cmBxStatusEDIT.SelectedIndex = doc.Status;
            cmBxTypeEDIT.SelectedIndex = doc.Type;
            cmBxDepartmentEDIT.SelectedIndex = doc.Department;
            cmBxClinicEDIT.SelectedIndex = doc.Clinic;
            txtBxEmailEDIT.Text = doc.Email;
            txtBxNoteEDIT.Text = doc.Notes;

        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDoctorDelete_Click(object sender, EventArgs e)
        {
            string doctor = "Deleted Doctor "+cmBoxSelectDoctor.Text;

            if (MessageBox.Show("Confirm?", doctor, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                doc.deleteDoctor(Int32.Parse(cmBoxSelectDoctor.SelectedValue.ToString()));
                //refresh dataset for combo box
                this.doctorTableAdapter.Fill(this.dataSetSelectDoctor.Doctor);
                cmBoxSelectDoctor.Refresh();
            }
            else
            {
                this.Activate();
            }


        }

        private void btnEDITSave_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (ValidateClass.isValidString(txtBxFNameEDIT.Text))
            {
                doc.FName = txtBxFNameEDIT.Text;
                check = true;
            }
            else
            {
                txtBxFNameEDIT.Clear();
                MessageBox.Show("First Name Error");
                check = false;
            }
            if (ValidateClass.isValidString(txtBxMNameEDIT.Text))
            {
                doc.MName = txtBxMNameEDIT.Text;
                check = true;
            }
            else
            {
                txtBxMNameEDIT.Clear();
                MessageBox.Show("Middle Name Error");
                check = false;
            }
            if (ValidateClass.isValidString(txtBxLNameEDIT.Text))
            {
                doc.LName = txtBxLNameEDIT.Text;
                check = true;
            }
            else
            {
                txtBxLNameEDIT.Clear();
                MessageBox.Show("Last Name Error");
                check = false;
            }
            if (ValidateClass.isValidEmail(txtBxEmailEDIT.Text))
            {
                doc.Email = txtBxEmailEDIT.Text;
                check = true;
            }
            else
            {
                txtBxEmailEDIT.Clear();
                MessageBox.Show("Email Error");
                check = false;
            }
            if (ValidateClass.isValidString(txtBxNoteEDIT.Text))
            {
                doc.Notes = txtBxNoteEDIT.Text;
                check = true;
            }
            else
            {
                txtBxNoteEDIT.Clear();
                MessageBox.Show("Notes Error");
                check = false;
            }
            if (check)
            {
                doc.Status = Int32.Parse(cmBxStatusEDIT.SelectedValue.ToString());
                doc.Type = Int32.Parse(cmBxTypeEDIT.SelectedValue.ToString());
                doc.Department = Int32.Parse(cmBxDepartmentEDIT.SelectedValue.ToString());
                doc.Clinic = Int32.Parse(cmBxClinicEDIT.SelectedValue.ToString());
                int docID = Int32.Parse(cmBoxSelectDoctor.SelectedValue.ToString());
                doc.UpdateDoctor(docID, doc.FName, doc.MName, doc.LName, doc.Status, doc.Type, doc.Department, doc.Clinic,
                    doc.Email, doc.Notes);

                txtBxNoteEDIT.Clear();
                txtBxMNameEDIT.Clear();
                txtBxLNameEDIT.Clear();
                txtBxFNameEDIT.Clear();
                txtBxEmailEDIT.Clear();

            }
        }
    }
}
