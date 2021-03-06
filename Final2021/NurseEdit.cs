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
    public partial class NurseEdit : Form
    {
        NurseClass nur = new NurseClass();
        public NurseEdit()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBxEditEmail.Clear();
            txtBxEditFName.Clear();
            txtBxEditLName.Clear();
            txtBxEditMName.Clear();
            txtBxEditNote.Clear();
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

        private void NurseEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetEditNurseClinic.Clinic' table. You can move, or remove it, as needed.
            this.clinicTableAdapter.Fill(this.dataSetEditNurseClinic.Clinic);
            // TODO: This line of code loads data into the 'dataSetEditNurseDepartment.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.dataSetEditNurseDepartment.Department);
            // TODO: This line of code loads data into the 'dataSetEditNurseType.NurseType' table. You can move, or remove it, as needed.
            this.nurseTypeTableAdapter.Fill(this.dataSetEditNurseType.NurseType);
            // TODO: This line of code loads data into the 'dataSetNurseEditStatus.Status' table. You can move, or remove it, as needed.
            this.statusTableAdapter.Fill(this.dataSetNurseEditStatus.Status);
            // TODO: This line of code loads data into the 'dataSetSelectNurse.Nurse' table. You can move, or remove it, as needed.
            this.nurseTableAdapter.Fill(this.dataSetSelectNurse.Nurse);



        }

        private void btnFillInEDIT_Click(object sender, EventArgs e)
        {
            int getNurseID = Int32.Parse(cmBxSelectNurse.SelectedValue.ToString());
            
            nur.getNurse(getNurseID);
            txtBxEditFName.Text = nur.FName;
            txtBxEditMName.Text = nur.MName;
            txtBxEditLName.Text = nur.LName;         

            cmBxTypeEDIT.SelectedIndex = nur.Type;
            cmBxDepartEDIT.SelectedIndex = nur.Department;
            cmBxClinicEDIT.SelectedIndex = nur.Clinic;

            txtBxEditEmail.Text = nur.Email;
            txtBxEditNote.Text = nur.Notes;
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {

            
        }

        private void btnNurseDelete_Click(object sender, EventArgs e)
        {
            string nurse = "Deleted Nurse "+cmBxSelectNurse.Text;
            if (MessageBox.Show("Confirm?", nurse, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                nur.deleteNurse(cmBxSelectNurse.SelectedIndex);
                //refresh dataset for combo box
                this.nurseTableAdapter.Fill(this.dataSetSelectNurse.Nurse);
                cmBxSelectNurse.Refresh();

            }
            else
            {
                this.Activate();
            }
            
        }
    }
}
