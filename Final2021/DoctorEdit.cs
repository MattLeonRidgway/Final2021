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
        {

            Form1 home = new Form1();
            home.Show();
            Hide();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBxEmailEDIT.Clear();
            txtBxFNameEDIT.Clear();
            txtBxLNameEDIT.Clear();
            txtBxMNameEDIT.Clear();
            txtBxNoteEDIT.Clear();

        }

        private void DoctorEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetSelectDoctor.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.dataSetSelectDoctor.Doctor);
            // TODO: This line of code loads data into the 'dataSetEditDoctorClinic.Clinic' table. You can move, or remove it, as needed.
            this.clinicTableAdapter.Fill(this.dataSetEditDoctorClinic.Clinic);
            // TODO: This line of code loads data into the 'dataSetEditDoctorDepartment.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.dataSetEditDoctorDepartment.Department);
            // TODO: This line of code loads data into the 'dataSetEditDoctorType.DoctorType' table. You can move, or remove it, as needed.
            this.doctorTypeTableAdapter.Fill(this.dataSetEditDoctorType.DoctorType);
            // TODO: This line of code loads data into the 'dataSetDoctorEditStatus.Status' table. You can move, or remove it, as needed.
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
            string doctor = "Deleted Nurse "+cmBoxSelectDoctor.Text;

            if (MessageBox.Show("Confirm?", doctor, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {               
                doc.deleteDoctor(cmBoxSelectDoctor.SelectedIndex);
                //refresh dataset for combo box
                this.doctorTableAdapter.Fill(this.dataSetSelectDoctor.Doctor);
                cmBoxSelectDoctor.Refresh();
            }
            else
            {
                this.Activate();
            }


        }
    }
}
